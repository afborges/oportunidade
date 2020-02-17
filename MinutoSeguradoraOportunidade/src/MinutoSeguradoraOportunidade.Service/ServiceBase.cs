using MinutoSeguradoraOportunidade.Domain.Entities;
using MinutoSeguradoraOportunidade.Domain.RSS;
using MinutoSeguradoraOportunidade.Domain.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguradoraOportunidade.Service
{
    public class ServiceBase : IServiceBase
    {
        private readonly IFeedRSS _feedRSS;

        public ServiceBase(IFeedRSS feed)
        {
            this._feedRSS = feed;
        }

        public RSS ObterFeed()
        {
            var feed = this._feedRSS.GetFeed();

            return feed;
        }
    }
}