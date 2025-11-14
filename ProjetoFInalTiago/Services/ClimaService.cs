using Microsoft.EntityFrameworkCore;
using ProjetoFInalTiago.Database;
using ProjetoFInalTiago.Models;

namespace ProjetoFInalTiago.Services;

public class ClimaService(FinalDbContext dbContext) : IClimaService
{
    private FinalDbContext DbContext { get; } = dbContext;

    public async Task AddNewClima(Clima clima) 
    {
        DbContext.Climas.Add(clima);
        await DbContext.SaveChangesAsync();
    }
}