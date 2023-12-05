using WsCalculator;
namespace MAUI2023SoapConsumer
{
    public partial class MainPage : ContentPage
    {
        private CalculatorSoapClient _service;
        public MainPage()
        {
            InitializeComponent();

            _service = new CalculatorSoapClient(new CalculatorSoapClient.EndpointConfiguration());
        }

        private async void Somar(object sender, EventArgs e)
        {
            AILoading.IsRunning = true;
            int.TryParse(Number1.Text, out int numb1);
            int.TryParse(Number2.Text, out int numb2);

            LblResult.Text = (await _service.AddAsync(numb1, numb2)).ToString();
            AILoading.IsRunning = false;
        }

        private async void Subtrair(object sender, EventArgs e)
        {
            AILoading.IsRunning = true;
            int.TryParse(Number1.Text, out int numb1);
            int.TryParse(Number2.Text, out int numb2);

            LblResult.Text = (await _service.SubtractAsync(numb1, numb2)).ToString();
            AILoading.IsRunning = false;
        }

        private async void Dividir(object sender, EventArgs e)
        {
            AILoading.IsRunning = true;
            int.TryParse(Number1.Text, out int numb1);
            int.TryParse(Number2.Text, out int numb2);

            LblResult.Text = (await _service.DivideAsync(numb1, numb2)).ToString();
            AILoading.IsRunning = false;
        }

        private async void Multiplicar(object sender, EventArgs e)
        {
            AILoading.IsRunning = true;
            int.TryParse(Number1.Text, out int numb1);
            int.TryParse(Number2.Text, out int numb2);

            LblResult.Text = (await _service.MultiplyAsync(numb1, numb2)).ToString();
            AILoading.IsRunning = false;
        }
    }

}
