using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer__BL_.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();     //retrive list of thing (order - product ..etc)

        IQueryable<T> GetWhere(Expression<Func<T, bool>> filter = null, string includeProperties = "");

        T GetById(int entityId); //retrive one  (order - product ..etc)

        bool Insert(T entity);
        void InsertList(List<T> entity);
        void Update(T entity);
        void UpdateList(List<T> entity);
        void Delete(T entity);
        void Delete(int entityId);



    }
}
