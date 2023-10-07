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
        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Gibson", "123.321.500-30", "gibson@gibson.com.br", "Nico");
        Cliente cliente2 = new Cliente(02, "Paula", "123.321.500-31", "paula@paula.com.br", "Ines");
        Cliente cliente3 = new Cliente(03, "Claudio", "123.321.500-32", "claudio@claudio.com.br", "Betina");
        Cliente cliente4 = new Cliente(04, "Sergio", "123.321.500-33", "sergio@sergio.com.br", "Núbia");
        Cliente cliente5 = new Cliente(05, "Rogerio", "123.321.500-34", "rogerio@rogerio.com.br", "Vilma");
        // instancias do tipo fornecedor

        //lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "Pets", "14.182.102/0001-80","pets@pets.com.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Dogs", "14.182.102/0001-81","dogs@pets.com.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Cats", "14.182.102/0001-82","cats@pets.com.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Fishs", "14.182.102/0001-90","fishs@pets.com.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Birds", "14.182.102/0001-60","birds@pets.com.br");

         List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            listaFornecedores.Add(fornecedor1);
            listaFornecedores.Add(fornecedor2);
            listaFornecedores.Add(fornecedor3);
            listaFornecedores.Add(fornecedor4);
            listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;        

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
