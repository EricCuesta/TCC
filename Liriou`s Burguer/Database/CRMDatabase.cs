using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liriou_s_Burguer.Database;

namespace Liriou_s_Burguer.Database
{
    class CRMDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_crm crm)
        {
            db.tb_crm.Add(crm);

            db.SaveChanges();
        }

        public List<Entities.tb_crm> Consultar()
        {
            List<Entities.tb_crm> list = db.tb_crm.ToList();

            return list;
        }

        public void Alterar(Entities.tb_crm crm)
        {
            Entities.tb_crm list = db.tb_crm.First(t => t.id_client == crm.id_client);
            list.ds_mood = list.ds_mood;
            list.ds_note = list.ds_note;
           
            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_crm remover = db.tb_crm.First(t => t.id_client == id);

            db.tb_crm.Remove(remover);
            db.SaveChanges();
        }
    }
}
