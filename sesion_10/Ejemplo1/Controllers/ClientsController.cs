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

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Client client)
    {
        try{
            _clientRepository.Add(client);
            return RedirectToAction("Index");
        }
        catch (Exception ex){
            return View(client);
        }
        
        return View(client);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var client = _clientRepository.Get(id);
        return View(client);
    }

    [HttpPost]
    public IActionResult Edit(int id, Client client)
    {
        try{
            var oriRecord = _clientRepository.Get(id);
            oriRecord.Name = client.Name;
            oriRecord.Email = client.Email;
            oriRecord.LastName = client.LastName;

            _clientRepository.Update(oriRecord);

            return RedirectToAction("Index");
        }
        catch (Exception ex){
            return View(client);
        }
        
        return View(client);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        _clientRepository.Delete(id);

        return RedirectToAction("Index");
    }
}