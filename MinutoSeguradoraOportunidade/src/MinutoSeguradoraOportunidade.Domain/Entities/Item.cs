using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguradoraOportunidade.Domain.Entities
{
    public class Item
    {
		public string Title { get; private set; }
		public string Link { get; private set; }
		public List<string> Comments { get; private set; }
		public string PubDate { get; private set; }
		public string Creator { get; private set; }
		public List<string> Category { get; private set; }
		public Guid Guid { get; private set; }
		public string Description { get; private set; }
		public string Encoded { get; private set; }
		public string CommentRss { get; private set; }

		public Item(string title, string link, List<string> comments, string pubDate, string creator,
			List<string> category, Guid guid, string description, string encoded, string commentRss)
		{
			this.Title = title;
			this.Link = link;
			this.Comments = comments;
			this.PubDate = pubDate;
			this.Creator = creator;
			this.Category = category;
			this.Guid = guid;
			this.Description = description;
			this.Encoded = encoded;
			this.CommentRss = commentRss;
		}
	}
}