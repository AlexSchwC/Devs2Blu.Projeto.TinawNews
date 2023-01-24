using Devs2Blu.Projeto.TinawNews.Domain.DTO;
using Devs2Blu.Projeto.TinawNews.Domain.IRepositories;
using Devs2Blu.Projeto.TinawNews.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.TinawNews.Application.Services.SQLServerServices
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _repository;
        public NewsService(INewsRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Delete(NewsDTO entity)
        {
            throw new NotImplementedException();
        }

        public List<NewsDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(news => new NewsDTO()
                {
                    id = news.Id,
                    title = news.Title,
                    description = news.Description,
                    categoryId = news.CategoryId,
                    createdOn = news.CreatedOn,
                    published = news.Published,
                }).ToList();
        }

        public Task<NewsDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(NewsDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
