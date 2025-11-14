using SQLite;

namespace ProjetoFInalTiago.Models;

public class Usuario
{
    public int Id { get; set; }
    public string NomeDisplay { get; set; }
    public string Senha { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public List<Clima> Buscas { get; set; } = new List<Clima>();
}