using BethanysPieShop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDBContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDBContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _appDBContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _appDBContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
