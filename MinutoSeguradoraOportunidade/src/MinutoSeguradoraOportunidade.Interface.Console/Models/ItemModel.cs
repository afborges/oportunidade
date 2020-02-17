using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguradoraOportunidade.Interface.Console.Models
{
    public class ItemModel
    {
        public string ItemTitle { get; set; }
        public string ItemLink { get; set; }
        public string ItemCreator { get; set; }
        public List<string> ItemCategories { get; set; }
        public string ItemDescription { get; set; }
        public string ItemContent { get; set; }
    }
}