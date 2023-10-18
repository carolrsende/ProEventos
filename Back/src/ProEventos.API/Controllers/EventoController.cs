using System.Data.Common;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;  

[ApiController]
[Route("api/[controller]")]

public class EventoController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Evento> Get(){
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id){
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {  
        return "Exemplo de Post";
    }


    public EventoController()
    {
    }

    public IEnumerable<Evento> _evento = new Evento[] {
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .Net 6",
                Local = "Belo Horizonte",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular 11 e Suas Novidades",
                Local = "São Paulo",
                Lote = "2° Lote",
                QtdPessoas = 150,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png"
            }
        };
    }

