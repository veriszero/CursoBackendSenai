public abstract class Clientes
{
    public string nome {get;set;}
    public string endereco {get;set;}
    public float valor {get; protected set;}
    public float valorImposto {get; protected set;}
    public float total {get; protected set;}

    public virtual void PagarImposto (float v){
        this.valor = v;
        this.valorImposto = this.valor * 0.1f;
        this.total = this.valor + this.valorImposto;
    }
}