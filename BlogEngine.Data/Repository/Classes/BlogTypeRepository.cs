﻿using BlogEngine.Data.Repository.Interfaces;
using BlogEngine.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Data.Repository.Classes
{
    public class BlogTypeRepository : Repository<BlogType>, IBlogTypeRepository
    {
        public BlogTypeRepository(DbContext context) : base(context)
        {
        }

        public BlogType GetByUrl(string url)
        {
            BlogType blogType = BlogEngineDb.BlogTypes.Include(bt => bt.Blogs).SingleOrDefault(bt => bt.Url == url);
            return blogType;
        }
    }
}
