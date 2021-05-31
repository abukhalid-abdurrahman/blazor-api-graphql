using System.Threading.Tasks;
using SampleBlazorDashboard.DTOs;

namespace SampleBlazorDashboard.Pages
{
    public partial class FetchData
    {
        private Person[] _persons;

        protected override async Task OnInitializedAsync()
        {
            _persons = new Person[]
            {
                new Person() { Name = "Faridun", Surname = "Berdiev" }, 
                new Person() { Name = "Sorbon", Surname = "Rashidov" }, 
                new Person() { Name = "Abubakr", Surname = "Nazirmadov" }, 
                new Person() { Name = "Faridun", Surname = "Berdiev" }, 
                new Person() { Name = "Sorbon", Surname = "Rashidov" }, 
                new Person() { Name = "Abubakr", Surname = "Nazirmadov" }
            };
        }
    }
}