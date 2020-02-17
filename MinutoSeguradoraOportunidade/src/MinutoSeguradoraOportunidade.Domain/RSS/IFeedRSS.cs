using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguradoraOportunidade.Domain.RSS
{
    public interface IFeedRSS
    {
        Entities.RSS GetFeed();
    }
}