using JovemProgramador.Data.Repositorio.Interfaces;
using JovemProgramador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramador.Data.Repositorio
{
    public class EventoRepositorio : IEventoRepositorio
    {
        private readonly BancoContexto _bancoContexto;
        public EventoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public EventoModel Inserir(EventoModel evento)
        {
            _bancoContexto.Evento.Add(evento);
            _bancoContexto.SaveChanges();
            return evento;
        }
        public List<EventoModel> BuscarEvento()
        {
            return _bancoContexto.Evento.ToList();
        }

        public EventoModel BuscarId(int id)
        {
            return _bancoContexto.Evento.FirstOrDefault(x => x.Id == id);
        }

        public bool Atualizar(EventoModel evento)
        {
            EventoModel eventoDb = BuscarId(evento.Id);

            if (eventoDb == null)
                return false;

            eventoDb.Nome = evento.Nome;
            eventoDb.Sobre = evento.Sobre;
            eventoDb.Contato = evento.Contato;
            eventoDb.Data = evento.Data;
            eventoDb.Rua = evento.Rua;
            eventoDb.Bairro = evento.Bairro;
            eventoDb.Cidade = evento.Cidade;
            eventoDb.Capacidade = evento.Capacidade;

            _bancoContexto.Evento.Update(eventoDb);
            _bancoContexto.SaveChanges();

            return true;
        }


        public bool Excluir(int id)
        {
            EventoModel evento = BuscarId(id);
            if (evento == null)
                return false;

            _bancoContexto.Evento.Remove(evento);
            _bancoContexto.SaveChanges();

            return true;
        }


        public List<EventoModel>FiltroNome(string nome)
        {
            return _bancoContexto.Evento.Where(x => x.Nome.Contains(nome)).ToList();
        }

        public List<EventoModel>FiltroContato(string contato)
        {
            return _bancoContexto.Evento.Where(x => x.Contato.Contains(contato)).ToList();
        }


        public object BuscarId(object id)
        {
            throw new NotImplementedException();
        }

        public List<EventoModel> FiltroIdade(int idade, string operacao)
        {
            throw new NotImplementedException();
        }


    }
}
