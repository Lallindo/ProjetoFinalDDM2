using ProjetoFInalTiago.Views;

namespace ProjetoFInalTiago;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(nameof(Login), typeof(Login));
        Routing.RegisterRoute(nameof(Registro), typeof(Registro));
        Routing.RegisterRoute(nameof(Listagem), typeof(Listagem));
    }
}