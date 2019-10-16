using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class ProviderDatabase
    {

        public void Inserir(Entities.tb_provider provider)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_provider.Add(provider);

            DB.SaveChanges();
        }

        public List<Entities.tb_provider> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_provider> list = DB.tb_provider.ToList();

            return list;
        }

        public void Alterar(Entities.tb_provider provider)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_provider list = DB.tb_provider.First(t => t.id_provider == provider.id_provider);
            list.ds_Address = list.ds_Address;
            list.nr_cellphone = list.nr_cellphone;
            list.ds_cep = list.ds_cep;
            
            list.ds_cnpj = list.ds_cnpj;
            list.ds_country = list.ds_country;
            list.ds_email = list.ds_email;
            list.ds_note = list.ds_note;
            list.ds_state = list.ds_state;
            list.nr_tellphone = list.nr_tellphone;
            list.nm_Name = list.nm_Name;
            list.nm_provider = list.nm_provider;
            

            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_provider remover = DB.tb_provider.First(t => t.id_provider == id);

            DB.tb_provider.Remove(remover);
            DB.SaveChanges();
        }
    }
}
