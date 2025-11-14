using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFInalTiago.ViewModels;

namespace ProjetoFInalTiago.Views;

public partial class Login : ContentPage
{
    public Login(LoginViewModel  viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}