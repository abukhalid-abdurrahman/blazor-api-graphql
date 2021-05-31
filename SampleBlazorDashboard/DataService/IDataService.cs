using System.Threading.Tasks;
using SampleBlazorDashboard.DTOs;

namespace SampleBlazorDashboard.DataService
{
    public interface IDataService
    {
        Task<Person[]> GetAllPersons();
    }
}