using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class CRMDatabase
    {
        public void Inserir(Entities.tb_crm crm)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_crm.Add(crm);

            DB.SaveChanges();
        }

        public List<Entities.tb_crm> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_crm> list = DB.tb_crm.ToList();

            return list;
        }

        public void Alterar(Entities.tb_crm crm)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_crm list = DB.tb_crm.First(t => t.id_client == crm.id_client);
            list.ds_mood = list.ds_mood;
            list.ds_note = list.ds_note;
           
            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_crm remover = DB.tb_crm.First(t => t.id_client == id);

            DB.tb_crm.Remove(remover);
            DB.SaveChanges();
        }
    }
}
