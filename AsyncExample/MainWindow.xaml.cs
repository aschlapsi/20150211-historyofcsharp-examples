using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace AsyncSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultsTextBox.Text += "\n";
            var url = UrlTextBox.Text;

            try
            {
                var length = await GetWebPageLength(url);
                ResultsTextBox.Text += string.Format("Length of page at '{0}': {1}\n", url, length);
            }
            catch (Exception)
            {
                // in real code: process exception
            }
        }

        public async Task<int> GetWebPageLength(string url)
        {
            var httpClient = new HttpClient();
            return (await httpClient.GetStringAsync(url)).Length;
        }
    }
}
