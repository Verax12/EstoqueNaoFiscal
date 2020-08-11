using EstoqueNaoFiscal.Domain.IRepositorys.Base;
using EstoqueNaoFiscal.Services.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Services.Services.Base
{
    public abstract class ServicesBase<T> : IDisposable, IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;
        public ServicesBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public virtual void Add(T obj)
        {
            _repositoryBase.Add(obj);
        }
        public virtual T GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _repositoryBase.GetAll();
        }
        public virtual void Update(T obj)
        {
            _repositoryBase.Update(obj);
        }
        public virtual void Remove(T obj)
        {
            _repositoryBase.Remove(obj);
        }

        public virtual void Dispose()
        {
            _repositoryBase.Dispose();
        }

    }

}
