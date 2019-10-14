using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class EnterpriseDatabase
    {
        public void Inserir(Entities.tb_enterprise enterprise)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_enterprise.Add(enterprise);

            DB.SaveChanges();
        }

        public List<Entities.tb_enterprise> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_enterprise> list = DB.tb_enterprise.ToList();

            return list;
        }

        public void Alterar(Entities.tb_enterprise enterprise)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_enterprise list = DB.tb_enterprise.First(t => t.id_enterprise == enterprise.id_enterprise);
            list.ds_Address = list.ds_Address;
            list.ds_cellphone = list.ds_cellphone;
            list.ds_cep = list.ds_cep;
            list.ds_city = list.ds_city;
            list.ds_cnpj = list.ds_cnpj;
            list.ds_country = list.ds_country;
            list.ds_email = list.ds_email;
            list.ds_note = list.ds_note;
            list.ds_state = list.ds_state;
            list.ds_tellphone = list.ds_tellphone;
            list.nm_commercialName = list.nm_commercialName;
            list.nm_enterprise = list.nm_enterprise;
            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_enterprise remover = DB.tb_enterprise.First(t => t.id_enterprise == id);

            DB.tb_enterprise.Remove(remover);
            DB.SaveChanges();
        }
    }
}
