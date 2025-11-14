namespace ProjetoFInalTiago.Models;

public class Clima
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}