using System.Data.Common;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProEventos.API.Data;
using ProEventos.API.Models;
using SQLitePCL;

namespace ProEventos.API.Controllers;  

[ApiController]
[Route("api/[controller]")]

public class EventoController : ControllerBase
{
    private readonly DataContext context;

    public EventoController(DataContext context)
    {
            this.context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get(){
        return this.context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento GetById(int id){
        return this.context.Eventos.FirstOrDefault(
            evento => evento.EventoId == id
            );
    }

    [HttpPost]
    public string Post()
    {  
        return "Exemplo de Post";
    }

    public IEnumerable<Evento> _evento = new Evento[] {

        };
}

