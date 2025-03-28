namespace HexagonAPI.Models;

public class Usuario
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? EstadoCivil { get; set; }
    public string? CPF { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
}