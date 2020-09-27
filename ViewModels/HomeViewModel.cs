using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<BethanysPieShop.Models.Pie> Pies { get; set; }
    }
}
