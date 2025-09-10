using DCP.wpf.Model;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DCP.wpf.ViewModel
{
    public class ExpendHeadViewModel
    {
        public ExpendHead ExpendHead { get; set; }
        public ICommand SaveCommand { get; }

        private readonly HttpClient _httpClient;

        public ExpendHeadViewModel()
        {
            ExpendHead = new ExpendHead();
            SaveCommand = new RelayCommand(async _ => await SaveAsync());

            // Replace with your API URL
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7163")
            };
        }

        private async Task SaveAsync()
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/ExpendHead", ExpendHead);

                if (response.IsSuccessStatusCode)
                {
                    System.Windows.MessageBox.Show("Data sent to API successfully!");
                    ExpendHead = new ExpendHead(); // Reset form
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    System.Windows.MessageBox.Show($"API Error: {error}");
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"Exception: {ex.Message}");
            }
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Func<object, Task> _executeAsync;
        public RelayCommand(Func<object, Task> executeAsync) => _executeAsync = executeAsync;

        public event EventHandler? CanExecuteChanged;
        public bool CanExecute(object? parameter) => true;
        public async void Execute(object? parameter) => await _executeAsync(parameter!);
    }
}
