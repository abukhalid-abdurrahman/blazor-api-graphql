using System.Threading.Tasks;
using SampleBlazorDashboard.DTOs;

namespace SampleBlazorDashboard.DataService
{
    public class DbService : IDataService
    {
        public async Task<Person[]> GetAllPersons()
        {
            return await Task.Run(() => {
                return new Person[]
                {
                    new Person() { Name = "Faridun", Surname = "Berdiev" }, 
                    new Person() { Name = "Sorbon", Surname = "Rashidov" }, 
                    new Person() { Name = "Abubakr", Surname = "Nazirmadov" }, 
                    new Person() { Name = "Faridun", Surname = "Berdiev" }, 
                    new Person() { Name = "Sorbon", Surname = "Rashidov" }, 
                    new Person() { Name = "Abubakr", Surname = "Nazirmadov" }
                };
            });
        }
    }
}