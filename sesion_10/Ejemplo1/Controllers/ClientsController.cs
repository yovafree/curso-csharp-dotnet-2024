using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ejemplo1.Models;
using Ejemplo1.Repositories.Interfaces;

namespace Ejemplo1.Controllers;
public class ClientsController : Controller
{
    private readonly IClientRepository _clientRepository;
    public ClientsController(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }
    public IActionResult Index()
    {
        ViewBag.Clients = _clientRepository.GetAll();
        return View();
    }

    public IActionResult View(int id)
    {
        var client = _clientRepository.Get(id);
        return View(client);
    }
}