namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        // Sobrescreve o método CreateWindow para definir o tamanho da janela e a página inicial
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new Login()) // Abre direto no Login
            {
                Width = 400,
                Height = 700
            };

            return window;
        }


    }
}