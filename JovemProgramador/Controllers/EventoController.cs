using JovemProgramador.Data.Repositorio.Interfaces;
using JovemProgramador.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace JovemProgramador.Controllers
{
    public class EventoController: Controller   
    {
        private readonly IConfiguration _configuration;
        private readonly IEventoRepositorio _eventorepositorio;

      public EventoController(IConfiguration configuration, IEventoRepositorio eventoRepositorio)
        {
            _configuration = configuration;
            _eventorepositorio = eventoRepositorio;
        }

        public IActionResult Index(EventoModel filtroEvento)
        {
            List<EventoModel> evento = new();
            if(filtroEvento.Nome !=null)
            {
                return View(_eventorepositorio.FiltroNome(filtroEvento.Nome));
            }
            if(filtroEvento.Id == 0)
            {
                return View(_eventorepositorio.BuscarEvento());
            }
            if(filtroEvento.Contato !=null)
            {
                return View(_eventorepositorio.FiltroContato(filtroEvento.Contato));
            }
            return View(evento);
        }
        
        public IActionResult Adicionar()
        {
            return View();
        }


        public IActionResult Mensagens()
        {
            return View();
        }

        public IActionResult Filtro()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Inserir(EventoModel evento)
        {
          var retorno = _eventorepositorio.Inserir(evento);
            if(retorno != null)
            {
                ViewData["Mensagem2"] = "Dados gravados com sucesso!";
            }
            return View("Index");
        }

        public IActionResult Editar(int id)
        {
            var evento = _eventorepositorio.BuscarId(id);
            return View("Editar", evento);
        }
        
        public IActionResult Atualizar(EventoModel evento)
        {
            var retorno = _eventorepositorio.Atualizar(evento);
            return RedirectToAction("Index");
        }
        
        public IActionResult Excluir(int id)
        {
            var retorno = _eventorepositorio.Excluir(id);
            if(retorno == true)
            {
                TempData["Mensagem2"] = "Evento excluido com sucesso!";
            }
            else
            {
                TempData["Mensagem3"] = "Evento não foi excluido";
            }

            return RedirectToAction("index");
                    
                

        }



    }

}
