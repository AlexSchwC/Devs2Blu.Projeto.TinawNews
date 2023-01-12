using Devs2Blu.Projeto.TinawNews.Models;

namespace Devs2Blu.Projeto.TinawNews.Repository
{
    public class NewsRepository
    {
        private readonly NewsDbContext _context;

        public NewsRepository(NewsDbContext context)
        {
            _context = context;
        }
    }
}
