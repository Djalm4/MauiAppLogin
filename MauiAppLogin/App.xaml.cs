namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Opcional: manter MainPage consistente com a Window criada
            // MainPage = new MainPage();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Cria explicitamente a Page que será usada na Window
            var page = new MainPage();

            // Cria e configura a Window diretamente (não chamar base.CreateWindow que pode retornar null)
            var window = new Window(page)
            {
                Width = 400,   // Define a largura
                Height = 700   // Define a altura
            };

            // Atualiza MainPage para refletir a página principal (opcional, mas útil em algumas APIs)
            MainPage = page;

            return window;
        }
    }
}