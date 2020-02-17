using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguradoraOportunidade.Domain.Entities
{
    public class Guid
    {
        public string IsPermaLink { get; private set; }
        public string Text { get; private set; }

        public Guid(string isPermaLink, string text)
        {
            this.IsPermaLink = isPermaLink;
            this.Text = text;
        }
    }
}