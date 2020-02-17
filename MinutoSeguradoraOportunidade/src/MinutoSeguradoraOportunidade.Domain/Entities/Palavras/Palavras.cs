using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace MinutoSeguradoraOportunidade.Domain.Entities.Palavras
{
    public class Palavras
    {
        private string _conteudo;
        private List<Palavras> _palavras = new List<Palavras>();
        private List<string> _palavrasJaListadas = new List<string>();

        public string Palavra { get; private set; }
        public int Quantidade { get; private set; }
        public List<Palavras> OcorrenciaPalavras => this._palavras.OrderByDescending(p => p.Quantidade).ToList();

        public Palavras(string conteudo)
        {
            this._conteudo = conteudo;

            this.ListarPalavras();
        }

        private Palavras(string palavra, int quantidade)
        {
            this.Palavra = palavra;
            this.Quantidade = quantidade;
        }

        private void ListarPalavras()
        {
            this.LimparTags();
            this.LimparPontuacao();

            var palavras = this._conteudo.Split(" ");

            foreach (var palavra in palavras)
            {
                if (!Artigos.EhArtigo(palavra) && !Preposicoes.EhPreposicao(palavra))
                {
                    if (this._palavrasJaListadas.Contains(palavra.ToLower()))
                    {
                        var ocorrencia = this._palavras.Where(p => p.Palavra == palavra.ToLower()).FirstOrDefault();
                        var nOcorrencia = new Palavras(ocorrencia.Palavra.ToLower(), ocorrencia.Quantidade + 1);

                        this._palavras.Remove(ocorrencia);
                        this._palavras.Add(nOcorrencia);
                    }
                    else
                    {
                        var nOcorrencia = new Palavras(palavra.ToLower(), 1);

                        this._palavras.Add(nOcorrencia);
                        this._palavrasJaListadas.Add(palavra.ToLower());
                    }
                }
            }
        }

        private void LimparTags()
        {
            this._conteudo = Regex.Replace(this._conteudo, "<.*?>", string.Empty);
        }

        private void LimparPontuacao()
        {
            this._conteudo = this._conteudo.Replace(",", "").Replace(".", "").Replace(";", "").Replace("!", "!").Replace("?", "").Replace(":", "").Replace(@"/", "").Replace(@"\", "").Replace("(", "").Replace(")", "");
        }
    }
}