// See https://aka.ms/new-console-template for more information

/*
Teste de criação dos objetos e inserção de dados:

PessoaFisica pf = new PessoaFisica();

pf.nome = "Joaquim sa silva";
pf.cpf="000.000.000-01";
pf.endereco = "Rua sem saida, 0";
pf.PagarImposto(100);
System.Console.WriteLine(pf.total);

PessoaJuridica pj = new PessoaJuridica();

pj.nome = "Jiraia japan";
pj.cnpj = "200.222.333.0001-12";
pj.endereco = "Rua tau, 100";
pj.PagarImposto(100);

System.Console.WriteLine(pj.total);
*/
//Aplicação da atividade

float valor;
System.Console.WriteLine("Informe o nome Cliente:");
string valNome = Console.ReadLine();
System.Console.WriteLine("Informe o Endereço:");
string valEndereco = Console.ReadLine();
System.Console.WriteLine("Pessoa Física digite 'f' para Jurídica 'j':");
string tipo = Console.ReadLine();

if (tipo == "f"){

    PessoaFisica pf = new PessoaFisica();
    pf.nome = valNome;
    pf.endereco = valEndereco;
    System.Console.WriteLine("Informe o CPF:");
    pf.cpf = Console.ReadLine();
    System.Console.WriteLine("Informe o RG:");
    pf.rg = Console.ReadLine();
    System.Console.WriteLine("Informe o Valor da compra:");
    valor = float.Parse(Console.ReadLine());
    pf.PagarImposto(valor);

    System.Console.WriteLine("------Pessoa Física-------");
    System.Console.WriteLine("Nome...........:"+pf.nome);
    System.Console.WriteLine("Endereço.......:"+pf.endereco);
    System.Console.WriteLine("CPF............:"+pf.cpf);
    System.Console.WriteLine("RG.............:"+pf.rg);
    System.Console.WriteLine("Valor da compra:"+pf.valor.ToString("C"));
    System.Console.WriteLine("Imposto........:"+pf.valorImposto.ToString("C"));
    System.Console.WriteLine("Total a pagar  :"+pf.total.ToString("C"));
   

}else 
    if(tipo == "j"){

        PessoaJuridica pj = new PessoaJuridica();
        pj.nome = valNome;
        pj.endereco = valEndereco;
        System.Console.WriteLine("Informe o CNPJ:");
        pj.cnpj = Console.ReadLine();
        System.Console.WriteLine("Informe o IE:");
        pj.ie = Console.ReadLine();
        System.Console.WriteLine("Informe o Valor da compra:");
        valor = float.Parse(Console.ReadLine());
        pj.PagarImposto(valor);

        System.Console.WriteLine("------Pessoa Física-------");
        System.Console.WriteLine("Nome...........:"+pj.nome);
        System.Console.WriteLine("Endereço.......:"+pj.endereco);
        System.Console.WriteLine("CNPJ...........:"+pj.cnpj);
        System.Console.WriteLine("IE.............:"+pj.ie);
        System.Console.WriteLine("Valor da compra:"+pj.valor.ToString("C"));
        System.Console.WriteLine("Imposto........:"+pj.valorImposto.ToString("C"));
        System.Console.WriteLine("Total a pagar  :"+pj.total.ToString("C"));
}
