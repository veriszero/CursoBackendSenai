public class PessoaJuridica : Clientes
{
    public string cnpj {get;set;}
    public string ie {get;set;}
    public override void PagarImposto(float v)
    {
        this.valor = v;
        this.valorImposto = this.valor * 0.2f;
        this.total = this.valor + this.valorImposto;
    }
}