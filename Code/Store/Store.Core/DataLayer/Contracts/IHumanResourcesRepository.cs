using System;
using System.Linq;
using System.Threading.Tasks;
using Store.Core.EntityLayer.HumanResources;

namespace Store.Core.DataLayer.Contracts
{
    public interface IHumanResourcesRepository : IRepository
    {
        IQueryable<Employee> GetEmployees(Int32 pageSize = 10, Int32 pageNumber = 1);

        Task<Employee> GetEmployeeAsync(Employee entity);
    }
}
