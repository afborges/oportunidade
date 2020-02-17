using MinutoSeguradoraOportunidade.Infrastructure.IoC.RSS;
using MinutoSeguradoraOportunidade.Infrastructure.IoC.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace MinutoSeguradoraOportunidade.Infrastructure.IoC
{
    public static class IoC
    {
        public static void Resolve(UnityContainer container)
        {
            ServiceDependencyResolver.RegisterDependencies(container);
            RSSDependencyResolver.RegisterDependencies(container);
        }
    }
}