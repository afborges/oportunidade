using Microsoft.Extensions.Configuration;
using MinutoSeguradoraOportunidade.Domain.RSS.Configurations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MinutoSeguradoraOportunidade.Infrastructure.RSS
{
    public class FeedContext : IFeedContext
    {
        private readonly IConfiguration _configuration;

        public FeedContext()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            this._configuration = configuration;
        }

        public string FeedURI()
        {
            var feedURI = this._configuration["URI"];

            return feedURI;
        }
    }
}