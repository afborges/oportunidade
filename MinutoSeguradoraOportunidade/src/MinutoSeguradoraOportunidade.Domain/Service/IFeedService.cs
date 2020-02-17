using MinutoSeguradoraOportunidade.Domain.Entities.Palavras;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguradoraOportunidade.Domain.Service
{
    public interface IFeedService : IServiceObter
    {
        Palavras ObterPalavras(string conteudo);
    }
}