using MinutoSeguradoraOportunidade.Domain.Entities;
using MinutoSeguradoraOportunidade.Domain.Entities.Palavras;
using MinutoSeguradoraOportunidade.Domain.RSS;
using MinutoSeguradoraOportunidade.Domain.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguradoraOportunidade.Service.Feeds
{
    public class FeedService : IFeedService
    {
        private readonly IFeedRSS _feed;

        public FeedService(IFeedRSS feed)
        {
            this._feed = feed;
        }

        public RSS ObterFeed()
        {
            var feed = this._feed.GetFeed();

            return feed;
        }

        public Palavras ObterPalavras(string conteudo)
        {
            var palavras = new Palavras(conteudo);

            return palavras;
        }
    }
}