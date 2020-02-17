using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguradoraOportunidade.Interface.Console.Models
{
    public class FeedModel
    {
        public string ChannelTitle { get; set; }
        public string ChannelLink { get; set; }
        public string ChannelDescription { get; set; }
        public List<ItemModel> Items { get; set; }
    }
}