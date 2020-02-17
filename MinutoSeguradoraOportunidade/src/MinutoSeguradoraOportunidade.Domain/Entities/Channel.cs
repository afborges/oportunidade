using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguradoraOportunidade.Domain.Entities
{
    public class Channel
    {
		public string Title { get; private set; }
		public Link Links { get; private set; }
		public string Link { get; private set; }
		public string Description { get; private set; }
		public string LastBuildDate { get; private set; }
		public string Language { get; private set; }
		public string UpdatePeriod { get; private set; }
		public string UpdateFrequency { get; private set; }
		public string Generator { get; private set; }
		public List<Item> Itens { get; private set; }

		public Channel(string title, Link links, string link, string description,
			string lastBuildDate, string language, string updatedPeriod,
			string generator, List<Item> itens)
		{
			this.Title = title;
			this.Links = links;
			this.Link = link;
			this.Description = description;
			this.LastBuildDate = lastBuildDate;
			this.Language = language;
			this.UpdatePeriod = updatedPeriod;
			this.Generator = generator;
			this.Itens = itens;
		}
	}
}