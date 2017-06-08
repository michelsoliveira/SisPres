using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Modelo;

namespace Controle
{
    public class LocalizacaoCtrl
    {
        public List<Localizacao> BuscarTodasLocalizacoes()
        {
            try
            {
                LocalizacaoDAO dao = new LocalizacaoDAO();

                return dao.BuscarTodasLocalizacoes();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    
    
    }
}
