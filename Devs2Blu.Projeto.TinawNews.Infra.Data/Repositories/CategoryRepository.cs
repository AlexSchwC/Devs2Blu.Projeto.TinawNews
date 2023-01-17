using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.Projeto.TinawNews.Domain.Entities;
using Devs2Blu.Projeto.TinawNews.Domain.IRepositories;
using Devs2Blu.Projeto.TinawNews.Infra.Data.Context;

namespace Devs2Blu.Projeto.TinawNews.Infra.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly SQLServerContext _context;
        public CategoryRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
