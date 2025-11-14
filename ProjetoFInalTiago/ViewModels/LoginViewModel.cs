using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProjetoFInalTiago.Models;
using ProjetoFInalTiago.Services;

namespace ProjetoFInalTiago.ViewModels;

public partial class LoginViewModel(IUsuarioService usuarioService) : ObservableObject
{
    private IUsuarioService _usuarioService = usuarioService;
    
    [ObservableProperty] private Usuario _usuario =  new Usuario();

    [RelayCommand]
    private Task TryLoginAsync()
    {
        return Task.CompletedTask;
    }
}