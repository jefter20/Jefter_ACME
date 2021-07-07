using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jefter_ACME.Dominio;
using Jefter_ACME.Dados;

namespace Jefter_AMCE.Negocios
{
    public class VooNegocios
    {
        public static int Salvar(VooDominio objVoo)
        {
            return new VooDados().Salvar(objVoo);
        }

        public List<VooDominio> Lista()
        {
            return new VooDados().Lista();
        }

        public static int Excluir(VooDominio objVoo)
        {
            return new VooDados().Excluir(objVoo);
        }
    }
}
