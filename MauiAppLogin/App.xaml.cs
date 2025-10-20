namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);    
            {
                window.Width = 400;   // Define a largura
                window.Height = 700;   // Define a altura
            };

            return window;
        }
    }
}