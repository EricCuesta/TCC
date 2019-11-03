using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class EnterpriseDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_enterprise enterprise)
        {
            db.tb_enterprise.Add(enterprise);

            db.SaveChanges();
        }

        public List<Entities.tb_enterprise> Consultar()
        {
            List<Entities.tb_enterprise> list = db.tb_enterprise.ToList();

            return list;
        }

        public void Alterar(Entities.tb_enterprise enterprise)
        {
            Entities.tb_enterprise list = db.tb_enterprise.First(t => t.id_enterprise == enterprise.id_enterprise);
            list.ds_address = list.ds_address;
            list.nr_cellphone = list.nr_cellphone;
            list.nr_cep = list.nr_cep;            
            list.nr_identification = list.nr_identification;
            list.ds_email = list.ds_email;
            list.ds_note = list.ds_note;
            list.ds_state = list.ds_state;
            list.nr_tellphone = list.nr_tellphone;
            list.nm_commercialName = list.nm_commercialName;
            list.nm_enterprise = list.nm_enterprise;
            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_enterprise remover = db.tb_enterprise.First(t => t.id_enterprise == id);

            db.tb_enterprise.Remove(remover);
            db.SaveChanges();
        }
    }
}
