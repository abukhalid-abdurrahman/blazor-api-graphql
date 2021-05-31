using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SampleBlazorDashboard.DataService;
using SampleBlazorDashboard.DTOs;

namespace SampleBlazorDashboard.Pages
{
    public partial class FetchData
    {
        [Inject] private IDataService _dataService { get; set; }

        private Person[] _persons;

        protected override async Task OnInitializedAsync()
        {
            _persons = await _dataService.GetAllPersons();
        }
    }
}