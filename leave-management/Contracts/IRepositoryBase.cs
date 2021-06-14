using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        // Get All Fields
        ICollection<T> FindAll();

        // Get Field By Id
        T FindById(int id);

        // Create One 
        bool Create(T entity);

        // Update One 
        bool Update(T entity);

        // Delete One 
        bool Delete(T entity);

        // Save Data
        bool Save();
    }
}
