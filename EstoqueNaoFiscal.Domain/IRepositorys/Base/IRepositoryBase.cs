﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Domain.IRepositorys.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T obj);

        T GetById(int id);

        IEnumerable<T> GetAll();

        void Update(T obj);

        void Remove(T obj);

        void Dispose();
    }
}
