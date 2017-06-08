using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    /// <summary>
    /// Modelo de Eventos
    /// </summary>
    public class Evento
    {
        
        public int Cod { get; set; }
        public int Evento_cod { get; set; }
        public String Titulo { get; set; }
        public String Descricao { get; set; }
        public String Qtdhoras { get; set; }
        public int Local_cod { get; set; }
        public DateTime Data_ini { get; set; }
        public DateTime Hora_ini { get; set; }
        public DateTime Data_fim { get; set; }
        public DateTime Hora_fim { get; set; }

        public Evento() { }

        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="cod">código do evento</param>
        /// <param name="titulo">titulo do evento</param>
        /// <param name="descricao">breve descrição do evento</param>
        /// <param name="qtdhoras">quantidade de horas complementares do evento</param>
        public Evento(int cod, int evento_cod, string titulo, string descricao, String qtdhoras, int local_cod, DateTime data_ini, DateTime hora_ini, DateTime data_fim, DateTime hora_fim)
        {
            this.Cod = cod;
            this.Evento_cod = evento_cod;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Qtdhoras = qtdhoras;
            this.Local_cod = local_cod;
            this.Data_ini = data_ini;
            this.Hora_ini = hora_ini;
            this.Data_fim = data_fim;
            this.Hora_fim = hora_fim;
        }

    }
}
