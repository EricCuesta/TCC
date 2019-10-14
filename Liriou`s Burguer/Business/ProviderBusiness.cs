using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class ProviderBusiness
    {
        public void Inserir(Database.Entities.tb_provider provider)
        {
            Database.ProviderDatabase DB = new Database.ProviderDatabase();
            DB.Inserir(provider);
        }

        public List<Database.Entities.tb_provider> Consultar()
        {
            Database.ProviderDatabase DB = new Database.ProviderDatabase();
            List<Database.Entities.tb_provider> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_provider provider)
        {
            Database.ProviderDatabase DB = new Database.ProviderDatabase();
            DB.Alterar(provider);
        }

        public void Remover(int id)
        {
            Database.ProviderDatabase DB = new Database.ProviderDatabase();
            DB.Remover(id);
        }
    }
}
