using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain
{
    public interface IEmployeeRepository
    {
        Employee GetByCode(string code);
        int GetCount();
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
        void Save(Employee entity);
        void Delete(int id);
    }
}
