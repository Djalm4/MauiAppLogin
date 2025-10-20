namespace MauiAppLogin;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			List<DadosUsuario> lista_usuarios = new List<DadosUsuario>()
			{
				new DadosUsuario()
				{
					Usuario = "admin", Senha = "123"
				},

				new DadosUsuario()
				{
					Usuario = "Djalma",
					Senha = "5400"
				}
			};

			DadosUsuario dadosDigitados = new DadosUsuario()
			{
				Usuario = txt_usuario.Text,
				Senha = txt_senha.Text
			};

            //Biblioteca LINQ
			if(lista_usuarios.Any(i => (dadosDigitados.Usuario == i.Usuario && dadosDigitados.Senha == i.Senha) ))
			{
				await SecureStorage.Default.SetAsync("usuario_logado", dadosDigitados.Usuario);

				// Corrigido para usar Windows[0].Page
				if (Application.Current?.Windows.Count > 0)
				{
					Application.Current.Windows[0].Page = new Protegida();
				}
			}
			else 
			{
				throw new Exception("Usuário ou senha inválidos.");
            }
        }
        catch (Exception ex)
		{
			await DisplayAlert("Error", ex.Message, "Close");
		}
    }
}