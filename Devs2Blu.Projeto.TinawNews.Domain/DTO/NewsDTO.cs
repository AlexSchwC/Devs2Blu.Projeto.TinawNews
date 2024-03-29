﻿using Devs2Blu.Projeto.TinawNews.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.TinawNews.Domain.DTO
{
    public class NewsDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime? createdOn { get; set; }
        public bool published { get; set; }
        public int categoryId { get; set; }
        public virtual CategoryDTO? category { get; set; }

        public News mapToEntity()
        {
            return new News()
            {
                Id = id,
                Title = title,
                Description = description,
                CreatedOn = createdOn,
                Published = published,
                CategoryId = categoryId
            };
        }

        public NewsDTO mapToDTO(News news)
        {
            return new NewsDTO()
            {
                id = news.Id,
                title = news.Title,
                description = news.Description,
                categoryId = news.CategoryId,
                createdOn = news.CreatedOn,
                published = news.Published,
                category = new CategoryDTO()
                {
                    id = news.Category.Id,
                    name = news.Category.Name
                }
            };
        }
    }
}
