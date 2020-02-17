using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguradoraOportunidade.Domain.Entities
{
    public class Link
    {
        public string Href { get; private set; }
        public string Rel { get; private set; }
        public string Type { get; private set; }

        public Link(string href, string rel, string type)
        {
            this.Href = href;
            this.Rel = rel;
            this.Type = type;
        }
    }
}