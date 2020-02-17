using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MinutoSeguradoraOportunidade.Domain.Entities.Palavras
{
    public class Artigos
    {
        private static string[] _artigos =
        {
            "a", "as", "o", "os", "uma", "umas", "um", "uns"
        };

        public string Artigo { get; private set; }

        public Artigos(string artigo)
        {
            this.Artigo = artigo;
        }

        public static bool EhArtigo(string palavra)
        {
            if (_artigos.Contains(palavra.ToLower()))
            {
                return true;
            }

            return false;
        }

        public static bool EhArtigo(Artigos palavra)
        {
            if (_artigos.Contains(palavra.Artigo.ToLower()))
            {
                return true;
            }

            return false;
        }
    }
}