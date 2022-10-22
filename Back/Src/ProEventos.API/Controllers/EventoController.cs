using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11",
                Local = "Porto Alegre",
                Lote = "1º lote",
                QtdePessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto.png"
            },
            
                new Evento(){
                EventoId = 2,
                Tema = "Angular 12",
                Local = "Porto Alegre",
                Lote = "2º lote",
                QtdePessoas = 250,
                DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto1.png"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get(){

            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id){ 

            return _evento.Where(evento => evento.EventoId == id); //evento é uma variável criada aqui agora
            
        }
    }
}
