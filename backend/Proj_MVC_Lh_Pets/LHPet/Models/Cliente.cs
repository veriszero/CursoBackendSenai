namespace LHPet.Models;
//prop - para criar propriendade 
public class Cliente
{
    public int Id {get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Paciente { get; set; }    

    //ctor (snippets)-  para criar um construtor 
    public Cliente(int ind, string nome, string cpf, string email, string paciente)
    {
        this.Id = ind;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
    }
}