using MinutoSeguradoraOportunidade.Domain.Service;
using MinutoSeguradoraOportunidade.Service;
using MinutoSeguradoraOportunidade.Service.Feeds;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Lifetime;

namespace MinutoSeguradoraOportunidade.Infrastructure.IoC.Services
{
    public static class ServiceDependencyResolver
    {
        public static void RegisterDependencies(UnityContainer container)
        {
            container.RegisterType<IFeedService, FeedService>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceBase, ServiceBase>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceObter, ServiceBase>(new HierarchicalLifetimeManager());
        }
    }
}