using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class CRMBusiness
    {
        public void Inserir(Database.Entities.tb_crm crm)
        {
            Database.CRMDatabase DB = new Database.CRMDatabase();
            DB.Inserir(crm);
        }

        public List<Database.Entities.tb_crm> Consultar()
        {
            Database.CRMDatabase DB = new Database.CRMDatabase();
            List<Database.Entities.tb_crm> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_crm accounts)
        {
            Database.CRMDatabase DB = new Database.CRMDatabase();
            DB.Alterar(accounts);
        }

        public void Remover(int id)
        {
            Database.CRMDatabase DB = new Database.CRMDatabase();
            DB.Remover(id);
        }
    }
}
