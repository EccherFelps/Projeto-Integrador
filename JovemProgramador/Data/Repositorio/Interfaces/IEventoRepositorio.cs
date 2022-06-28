using JovemProgramador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramador.Data.Repositorio.Interfaces
{
    public interface IEventoRepositorio 
    {
        EventoModel Inserir(EventoModel evento);

        List<EventoModel> BuscarEvento();

        EventoModel BuscarId(int id);

        bool Atualizar(EventoModel evento);

        bool Excluir(int id);


        List<EventoModel> FiltroNome(string nome);
        List<EventoModel> FiltroContato(string contato);
        object BuscarId(object id);
   
    }
}
