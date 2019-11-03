using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class CRMBusiness
    {
        Database.CRMDatabase db = new Database.CRMDatabase();

        public void Inserir(Database.Entities.tb_crm crm)
        {
            db.Inserir(crm);
        }

        public List<Database.Entities.tb_crm> Consultar()
        {
            List<Database.Entities.tb_crm> list = db.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_crm accounts)
        {
            db.Alterar(accounts);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
