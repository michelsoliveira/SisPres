using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Modelo;

namespace Controle
{
    public class EventoCtrl
    {
        public void InserirEventoUnico(Evento evento)
        {
            try
            {
                EventoDAO dao = new EventoDAO ();
                dao.InserirEventoUnico(evento);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InserirEventoMultiplo(Evento evento)
        {
            try
            {
                EventoDAO dao = new EventoDAO();
                dao.InserirEventoMultiplo(evento);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Evento> BuscarTodosEventos()
        {
            try
            {
                EventoDAO dao = new EventoDAO();

                return dao.BuscarTodosEventos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       

    }
}
