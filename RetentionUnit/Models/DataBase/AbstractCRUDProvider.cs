using System;
using System.Collections.Generic;
using System.Linq;

namespace RetentionUnit.Models.DataBase
{
    public abstract class AbstractCRUDProvider<T> : BaseProvider, IAbstractCrudProvider
    {
        private Lazy<List<T>> _list;
        public List<T> List => _list.Value;

        public abstract T Get(int id);
        protected abstract List<T> Get();
        public abstract int Create(T newEntity);

        public abstract void Update(T updated);
        public abstract void Delete(int id);


        protected AbstractCRUDProvider(string connectionString) : base(connectionString)
        {
            ReloadLazy();
        }

        public virtual void ReloadLazy()
        {
            _list = new Lazy<List<T>>(() => Get().ToList(), true);
        }
    }

    public interface IAbstractCrudProvider
    {
        void ReloadLazy();
    }
}
