using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MinutoSeguradoraOportunidade.Infrastructure.RSS.Serializations
{
	[XmlRoot(ElementName = "guid")]
	public class Guid
	{
		[XmlAttribute(AttributeName = "isPermaLink")]
		public string IsPermaLink { get; set; }
		[XmlText]
		public string Text { get; set; }
	}
}