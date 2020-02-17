using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinutoSeguradoraOportunidade.Domain.Service;
using MinutoSeguradoraOportunidade.Infrastructure.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using System.Linq;

namespace MinutoSeguradoraOportunidade.Tests.MSTest
{
    [TestClass]
    public class ContaPalavrasTest
    {
        [TestMethod]
        public void ContarPalavras()
        {
            IoC.Resolve(Container);

            var feedService = Container.Resolve<IFeedService>();

            var texto = "<p>Palavra1, Palavra2, Palavra1, Palavra3, palavra1, palavra4 palavra4 palavra5 palavra3 palavra2, palavra6 palavra5 palavra7 palavra7 palavra4 palavra2 palavra3 palavra8 palavra9 palavra1 palavra4 palavra10 palavra11 palavra10</p>";
            var palavras = feedService.ObterPalavras(texto);

            var esperadoPalavra1 = 4;
            var esperadoPalavra2 = 3;
            var esperadoPalavra3 = 3;
            var esperadoPalavra4 = 4;
            var esperadoPalavra5 = 2;
            var esperadoPalavra6 = 1;
            var esperadoPalavra7 = 2;
            var esperadoPalavra8 = 1;
            var esperadoPalavra9 = 1;
            var esperadoPalavra10 = 2;
            var esperadoPalavra11 = 1;
            var esperadoTotal = 11;

            var quantidadePalavra1 = palavras.OcorrenciaPalavras.Where(p => p.Palavra == "palavra1".ToLower()).FirstOrDefault().Quantidade;
            var quantidadePalavra2 = palavras.OcorrenciaPalavras.Where(p => p.Palavra == "palavra2".ToLower()).FirstOrDefault().Quantidade;
            var quantidadePalavra3 = palavras.OcorrenciaPalavras.Where(p => p.Palavra == "palavra3".ToLower()).FirstOrDefault().Quantidade;
            var quantidadePalavra4 = palavras.OcorrenciaPalavras.Where(p => p.Palavra == "palavra4".ToLower()).FirstOrDefault().Quantidade;
            var quantidadePalavra5 = palavras.OcorrenciaPalavras.Where(p => p.Palavra == "palavra5".ToLower()).FirstOrDefault().Quantidade;
            var quantidadePalavra6 = palavras.OcorrenciaPalavras.Where(p => p.Palavra == "palavra6".ToLower()).FirstOrDefault().Quantidade;
            var quantidadePalavra7 = palavras.OcorrenciaPalavras.Where(p => p.Palavra == "palavra7".ToLower()).FirstOrDefault().Quantidade;
            var quantidadePalavra8 = palavras.OcorrenciaPalavras.Where(p => p.Palavra == "palavra8".ToLower()).FirstOrDefault().Quantidade;
            var quantidadePalavra9 = palavras.OcorrenciaPalavras.Where(p => p.Palavra == "palavra9".ToLower()).FirstOrDefault().Quantidade;
            var quantidadePalavra10 = palavras.OcorrenciaPalavras.Where(p => p.Palavra == "palavra10".ToLower()).FirstOrDefault().Quantidade;
            var quantidadePalavra11 = palavras.OcorrenciaPalavras.Where(p => p.Palavra == "palavra11".ToLower()).FirstOrDefault().Quantidade;
            var quantidadeTotal = palavras.OcorrenciaPalavras.Count;

            Assert.AreEqual(esperadoPalavra1, quantidadePalavra1, 0.001, "Palavra 1 não foi contabilizada corretamente");
            Assert.AreEqual(esperadoPalavra2, quantidadePalavra2, 0.001, "Palavra 2 não foi contabilizada corretamente");
            Assert.AreEqual(esperadoPalavra3, quantidadePalavra3, 0.001, "Palavra 3 não foi contabilizada corretamente");
            Assert.AreEqual(esperadoPalavra4, quantidadePalavra4, 0.001, "Palavra 4 não foi contabilizada corretamente");
            Assert.AreEqual(esperadoPalavra5, quantidadePalavra5, 0.001, "Palavra 5 não foi contabilizada corretamente");
            Assert.AreEqual(esperadoPalavra6, quantidadePalavra6, 0.001, "Palavra 6 não foi contabilizada corretamente");
            Assert.AreEqual(esperadoPalavra7, quantidadePalavra7, 0.001, "Palavra 7 não foi contabilizada corretamente");
            Assert.AreEqual(esperadoPalavra8, quantidadePalavra8, 0.001, "Palavra 8 não foi contabilizada corretamente");
            Assert.AreEqual(esperadoPalavra9, quantidadePalavra9, 0.001, "Palavra 9 não foi contabilizada corretamente");
            Assert.AreEqual(esperadoPalavra10, quantidadePalavra10, 0.001, "Palavra 10 não foi contabilizada corretamente");
            Assert.AreEqual(esperadoPalavra11, quantidadePalavra11, 0.001, "Palavra 11 não foi contabilizada corretamente");
            Assert.AreEqual(esperadoTotal, quantidadeTotal, 0.001, "Total palavras não contabilizada corretamente");

        }

        private static UnityContainer Container { get; } = new UnityContainer();
    }
}