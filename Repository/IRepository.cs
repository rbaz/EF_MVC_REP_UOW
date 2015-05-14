﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MVC_Repository_UOW.Repository
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IQueryable<T> GetAll();
        void Edit(T entity);
        void Insert(T entity);
        void Delete(T entity);
    }
}
