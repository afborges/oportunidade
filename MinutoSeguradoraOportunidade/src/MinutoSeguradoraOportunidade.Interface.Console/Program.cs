using MinutoSeguradoraOportunidade.Domain.Service;
using MinutoSeguradoraOportunidade.Infrastructure.IoC;
using MinutoSeguradoraOportunidade.Interface.Console.Models;
using MinutoSeguradoraOportunidade.Service.Feeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Unity;

namespace MinutoSeguradoraOportunidade.Interface.Console
{
    class Program
    {
        private static UnityContainer Container { get; } = new UnityContainer();

        static void Main(string[] args)
        {
            IoC.Resolve(Container);

            var feedService = Container.Resolve<IFeedService>();
            var feed = feedService.ObterFeed();

            var items = new List<ItemModel>();
            var feedModel = new FeedModel
            {
                ChannelTitle = feed.Channel.Title,
                ChannelLink = feed.Channel.Link,
                ChannelDescription = feed.Channel.Description
            };

            foreach (var item in feed.Channel.Itens)
            {
                var itemModel = new ItemModel
                {
                    ItemTitle = item.Title,
                    ItemLink = item.Link,
                    ItemCreator = item.Creator,
                    ItemCategories = item.Category,
                    ItemDescription = item.Description,
                    ItemContent = item.Encoded
                };

                items.Add(itemModel);
            }

            feedModel.Items = items;

            System.Console.WriteLine("Descrição do Feed:");
            System.Console.WriteLine($"Título: { feedModel.ChannelTitle }");
            System.Console.WriteLine($"Link: { feedModel.ChannelLink }");
            System.Console.WriteLine($"Descrição: { feedModel.ChannelDescription }");
            System.Console.WriteLine();
            System.Console.WriteLine("Ítens:");
            foreach (var item in feedModel.Items)
            {
                System.Console.WriteLine($"Título: { item.ItemTitle }");
                System.Console.WriteLine($"Link: { item.ItemLink }");
                System.Console.WriteLine($"Autor: { item.ItemCreator }");
                System.Console.WriteLine("Categorias:");
                foreach (var categoria in item.ItemCategories)
                {
                    System.Console.WriteLine($"{ categoria }");
                }
                System.Console.WriteLine($"Descrição: { item.ItemDescription }");
                System.Console.WriteLine();

                var palavras = feedService.ObterPalavras(item.ItemContent);

                System.Console.WriteLine($"O conteúdo desse ítem tópico { palavras.OcorrenciaPalavras.Count } palavras");
                System.Console.WriteLine("As 10 palavras mais repetidas desse tópico são:");
                var c = 0;
                foreach (var palavra in palavras.OcorrenciaPalavras)
                {
                    if (c == 10)
                    {
                        break;
                    }

                    System.Console.WriteLine($"{ c + 1 } - \"{ palavra.Palavra }\" com { palavra.Quantidade } ocorrências");

                    c++;
                }

                System.Console.WriteLine();
                System.Console.WriteLine("*******************************************************");
                System.Console.WriteLine();
            }
            

            System.Console.ReadKey();
        }
    }
}