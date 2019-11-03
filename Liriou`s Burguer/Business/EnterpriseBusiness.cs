using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class EnterpriseBusiness
    {
        Database.EnterpriseDatabase db = new Database.EnterpriseDatabase();

        public void Inserir(Database.Entities.tb_enterprise enterprise)
        {
            db.Inserir(enterprise);
        }

        public List<Database.Entities.tb_enterprise> Consultar()
        {
            List<Database.Entities.tb_enterprise> list = db.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_enterprise enterprise)
        {
            db.Alterar(enterprise);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
