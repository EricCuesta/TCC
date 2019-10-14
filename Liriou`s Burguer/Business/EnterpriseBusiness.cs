using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class EnterpriseBusiness
    {
        public void Inserir(Database.Entities.tb_enterprise enterprise)
        {
            Database.EnterpriseDatabase DB = new Database.EnterpriseDatabase();
            DB.Inserir(enterprise);
        }

        public List<Database.Entities.tb_enterprise> Consultar()
        {
            Database.EnterpriseDatabase DB = new Database.EnterpriseDatabase();
            List<Database.Entities.tb_enterprise> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_enterprise enterprise)
        {
            Database.EnterpriseDatabase DB = new Database.EnterpriseDatabase();
            DB.Alterar(enterprise);
        }

        public void Remover(int id)
        {
            Database.EnterpriseDatabase DB = new Database.EnterpriseDatabase();
            DB.Remover(id);
        }
    }
}
