using AppRpgEtec.ViewModels.Usuarios;

namespace AppRpgEtec.Views.Usuarios;

public partial class CadastroView : ContentView
{
	UsuarioViewModel viewModel;
	public CadastroView()
	{
		InitializeComponent();
		BindingContext = viewModel;

	}
}