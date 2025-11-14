using Microsoft.EntityFrameworkCore;
using ProjetoFInalTiago.Database;
using ProjetoFInalTiago.Models;

namespace ProjetoFInalTiago.Services;

public class UsuarioService(FinalDbContext dbContext) : IUsuarioService
{
    private FinalDbContext DbContext { get; } = dbContext;

    public async Task<Usuario> GetBuscasByUsuario(int id)
    {
        return await DbContext.Usuarios
            .Where(u => u.Id == id)
            .Include(u => u.Buscas)
            .FirstOrDefaultAsync();
    }

    public async Task<Usuario> GetBuscasByUsuario(Usuario usuario)
    {
        return await GetBuscasByUsuario(usuario.Id);
    }

    public async Task<Usuario> TryLogin(string nomeUsuario, string senha)
    {
        return await DbContext.Usuarios
            .Where(u => u.NomeDisplay == nomeUsuario && u.Senha == senha)
            .FirstOrDefaultAsync();
    }

    public async Task AddNewUsuario(Usuario usuario)
    {
        DbContext.Usuarios.Add(usuario);
        await DbContext.SaveChangesAsync();
    }
}