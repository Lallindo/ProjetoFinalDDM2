using SQLite;

namespace ProjetoFInalTiago.Models;

public class Usuario
{
    [PrimaryKey,  AutoIncrement]
    public int Id { get; set; }
}