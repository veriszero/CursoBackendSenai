using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Nora Allen", "123.456.789-10", "nora@servivo.com", "gato amarelo"); 
        Cliente cliente2 = new Cliente(02, "Bart Allen", "123.456.789-20", "bart@servivo.com", "gamba"); 
        Cliente cliente3 = new Cliente(03, "Bio Allen", "123.456.789-30", "nora@servivo.com", "fuinha"); 
        Cliente cliente4 = new Cliente(04, "Jay Garrick", "123.456.789-40", "jay@servivo.com", "gato de botas"); 
        Cliente cliente5 = new Cliente(05, "Bila Allen", "123.456.789-50", "bila@servivo.com", "cachorro magro"); 

        List<Cliente>listacliente = new List<Cliente>();
        listacliente.Add(cliente1);
        listacliente.Add(cliente2);
        listacliente.Add(cliente3);
        listacliente.Add(cliente4);
        listacliente.Add(cliente5);

        ViewBag.listaCliente = listacliente;

        Fornecedor fornecedor1 = new Fornecedor(01, "Ração da Hora", "12.100.150/0001-88", "racao@dist.com.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Beautiful Dog", "37.120.150/0001-08", "bdog@dist.com.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Div Anima", "81.145.100/0001-55", "anima@dist.com.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Bira Estofado", "52.180.100/0001-45", "bira@dist.com.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Pet transportes", "91.120.150/0001-12", "pettransp@dist.com.br");

        List<Fornecedor>listafornecedor = new List<Fornecedor>();
        listafornecedor.Add(fornecedor1);
        listafornecedor.Add(fornecedor2);
        listafornecedor.Add(fornecedor3);
        listafornecedor.Add(fornecedor4);
        listafornecedor.Add(fornecedor5);

        ViewBag.listaFornecedor = listafornecedor;  


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
