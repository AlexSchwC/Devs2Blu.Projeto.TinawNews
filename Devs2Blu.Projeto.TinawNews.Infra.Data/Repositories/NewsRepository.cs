using Devs2Blu.Projeto.TinawNews.Domain.Entities;
using Devs2Blu.Projeto.TinawNews.Domain.IRepositories;
using Devs2Blu.Projeto.TinawNews.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.TinawNews.Infra.Data.Repositories
{
    public class NewsRepository : BaseRepository<News>, INewsRepository
    {
        private readonly SQLServerContext _context; 
        public NewsRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
