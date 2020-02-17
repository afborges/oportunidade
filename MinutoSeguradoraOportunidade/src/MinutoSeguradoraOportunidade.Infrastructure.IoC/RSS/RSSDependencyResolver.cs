using MinutoSeguradoraOportunidade.Domain.RSS;
using MinutoSeguradoraOportunidade.Domain.RSS.Configurations;
using MinutoSeguradoraOportunidade.Infrastructure.RSS;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Lifetime;

namespace MinutoSeguradoraOportunidade.Infrastructure.IoC.RSS
{
    public static class RSSDependencyResolver
    {
        public static void RegisterDependencies(UnityContainer container)
        {
            container.RegisterType<IFeedRSS, FeedRSS>(new HierarchicalLifetimeManager());

            //Configuracoes
            container.RegisterType<IFeedContext, FeedContext>(new HierarchicalLifetimeManager());
        }
    }
}