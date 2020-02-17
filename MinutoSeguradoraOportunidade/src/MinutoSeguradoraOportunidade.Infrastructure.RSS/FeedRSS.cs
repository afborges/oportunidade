using MinutoSeguradoraOportunidade.Domain.RSS;
using MinutoSeguradoraOportunidade.Domain.RSS.Configurations;
using MinutoSeguradoraOportunidade.Infrastructure.RSS.Serializations;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Xml.Serialization;

namespace MinutoSeguradoraOportunidade.Infrastructure.RSS
{
    public class FeedRSS : IFeedRSS
    {
        private readonly IFeedContext _feedContext;
        private readonly Uri _uri;
        
        public FeedRSS(IFeedContext feedContext)
        {
            this._feedContext = feedContext;
            this._uri = new Uri(this._feedContext.FeedURI());
        }

        public Domain.Entities.RSS GetFeed()
        {
            var client = new HttpClient();
            var rss = client.GetStreamAsync(this._uri).Result;
            var serializer = new XmlSerializer(typeof(Rss));
            var rssFeed = (Rss)serializer.Deserialize(rss);

            var link = new Domain.Entities.Link(rssFeed.Channel.Links.Href, rssFeed.Channel.Links.Rel, rssFeed.Channel.Links.Type);
            var items = new List<Domain.Entities.Item>();

            foreach (var channelItem in rssFeed.Channel.Item)
            {
                if (items.Count == 10)
                {
                    break;
                }

                var guid = new Domain.Entities.Guid(channelItem.Guid.IsPermaLink, channelItem.Guid.Text);
                var item = new Domain.Entities.Item(channelItem.Title, channelItem.Link, channelItem.Comments,
                    channelItem.PubDate, channelItem.Creator, channelItem.Category, guid,
                    channelItem.Description, channelItem.Encoded, channelItem.CommentRss);

                items.Add(item);
            }

            var channel = new Domain.Entities.Channel(rssFeed.Channel.Title, link, rssFeed.Channel.Link, rssFeed.Channel.Description,
                rssFeed.Channel.LastBuildDate, rssFeed.Channel.Language, rssFeed.Channel.UpdatePeriod,
                rssFeed.Channel.Generator, items);

            var rssReturn = new Domain.Entities.RSS(channel, rssFeed.Version, rssFeed.Content, rssFeed.Wfw,
                rssFeed.Dc, rssFeed.Atom, rssFeed.Sy, rssFeed.Slash);

            return rssReturn;
        }
    }
}