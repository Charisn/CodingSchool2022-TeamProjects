using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Session_24_TeamViolet.Shared.ViewModels;
using System.Net.Http.Json;
using CarService.Models.Entities;


namespace Session_24_TeamViolet.Client.Pages
{
    public partial class EngineerList
    {
        private EngineerViewModel _engineerView { get; set; } = new();

        bool isLoading = true;

        bool deletedEngineers = false;

        internal bool SetReadOnly = true;

        List<EngineerViewModel> engineerList = new();

        List<ManagerViewModel> _managerList = new();

        protected override async Task OnInitializedAsync()
        {
            await LoadEngineersFromServer();
            await LoadManagersFromServer();
            isLoading = false;
        }
        private async Task LoadEngineersFromServer()
        {
           engineerList = await httpClient.GetFromJsonAsync<List<EngineerViewModel>>("engineer/getallengineers");            
        }

        private async Task ShowDeletedEngineers()
        {
            deletedEngineers = !deletedEngineers;
            await LoadEngineersFromServer();
        }
        private async Task LoadManagersFromServer()
        {
            _managerList = await httpClient.GetFromJsonAsync<List<ManagerViewModel>>("managers");
        }

        async Task AddEngineer()
        {

            if (string.IsNullOrWhiteSpace(_engineerView.Name))
            {
                await jsRuntime.InvokeVoidAsync("window.alert", ("Name is Required"));
                return;
            }
            if (string.IsNullOrWhiteSpace(_engineerView.Surname))
            {
                await jsRuntime.InvokeVoidAsync("window.alert", ("Surname is Required"));
                return;
            }
            if (_engineerView.SalaryPerMonth == 0)
            {
                await jsRuntime.InvokeVoidAsync("window.alert", ("Salary is Required"));
                return;
            }
            if (_engineerView.ManagerID == Guid.Empty)
            {
                await jsRuntime.InvokeVoidAsync("window.alert", ("Manager Not Selected!"));
                return;
            }
            
            await httpClient.PostAsJsonAsync("engineer", _engineerView);

            _engineerView= new();
            _engineerView.Name = string.Empty;
            _engineerView.Surname = string.Empty;
            _engineerView.SalaryPerMonth = 0;
            _engineerView.ManagerID = Guid.Empty;
            

            await LoadEngineersFromServer();
        }
        async Task DeleteEngineer(EngineerViewModel engineerToDelete)
        {
            var confirm = await jsRuntime.InvokeAsync<bool>("confirmationJS", null);
            if (confirm)
            {
                var response = await httpClient.DeleteAsync($"engineer/{engineerToDelete.ID}");
                response.EnsureSuccessStatusCode();
                await LoadEngineersFromServer();
            }
        }
        async Task InputOnEnterClick(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                await AddEngineer();
            }
        }

        async Task SaveEngineer(EngineerViewModel engineer)
        {
            var confirm = await jsRuntime.InvokeAsync<bool>("confirmationJS", null);
            if (confirm)
            {
                var response = await httpClient.PutAsJsonAsync("engineer", engineer);
                response.EnsureSuccessStatusCode();
                await LoadEngineersFromServer();
            }
        }
    }
}
