using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MinutoSeguradoraOportunidade.Domain.Entities.Palavras
{
    public class Preposicoes
    {
        private static string[] _preoposicoes =
        {
            "a", "ante", "após", "até", "com", "contra", "de", "desde", "em", "entre", "para", "por", "perante",
            "sem", "sob", "sobre", "trás", "afora", "como", "conforme", "consoante", "durante", "exceto",
            "feito", "fora", "mediante", "menos", "salvo", "segundo", "senão", "tirante", "visto", "do",
            "duma", "à", "àquele", "aquele", "duma", "disto", "nas", "num", "nessa", "pelo", "pelas",
            "ao", "aos", "aonde"
        };

        public string Prepocisao { get; private set; }

        public Preposicoes(string preposicao)
        {
            this.Prepocisao = preposicao;
        }

        public static bool EhPreposicao(string palavra)
        {
            if (_preoposicoes.Contains(palavra.ToLower()))
            {
                return true;
            }

            return false;
        }

        public static bool EhPreposicao(Preposicoes palavra)
        {
            if (_preoposicoes.Contains(palavra.Prepocisao.ToLower()))
            {
                return true;
            }

            return false;
        }
    }
}