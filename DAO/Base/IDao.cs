using System.Collections.Generic;

namespace DAO.Base
{
    public interface IDao<T>
    {
        T Insert(T model);
        bool Update(T model);
        T Find(params object[] keys);
        IEnumerable<T> All();
        IEnumerable<T> All(params NameAndValue[] nameAndValues);
        bool Delete(T model);
    }
}
