using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguradoraOportunidade.Domain.Entities
{
    public class RSS
    {
		public Channel Channel { get; private set; }
		public string Version { get; private set; }
		public string Content { get; private set; }
		public string Wfw { get; private set; }
		public string Dc { get; private set; }
		public string Atom { get; private set; }
		public string Sy { get; private set; }
		public string Slash { get; private set; }

		public RSS(Channel channel, string version, string content, string wfw,
			string dc, string atom, string sy, string slash)
		{
			this.Channel = channel;
			this.Version = version;
			this.Content = content;
			this.Wfw = wfw;
			this.Dc = dc;
			this.Atom = atom;
			this.Sy = sy;
			this.Slash = slash;
		}
	}
}