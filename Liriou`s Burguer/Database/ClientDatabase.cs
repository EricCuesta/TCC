using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class ClientDatabase
    {
        public void Inserir(Entities.tb_client client)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_client.Add(client);

            DB.SaveChanges();
        }

        public List<Entities.tb_client> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_client> list = DB.tb_client.ToList();

            return list;
        }

        public void Alterar(Entities.tb_client client)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_client list = DB.tb_client.First(t => t.id_client == client.id_client);
            list.ds_Address = list.ds_Address;
            list.nr_cellphone = list.nr_cellphone;
            list.ds_cep = list.ds_cep;
            list.ds_country = list.ds_country;
            list.ds_cpf = list.ds_cpf;
            list.ds_email = list.ds_email;
            list.ds_sex = list.ds_sex;
            list.ds_note = list.ds_note;
            list.ds_state = list.ds_state;
            list.nr_tellphone = list.nr_tellphone;
            list.dt_birth = list.dt_birth;
            list.nm_firstName = list.nm_firstName;
            list.nm_lastName = list.nm_lastName;
            
            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_client remover = DB.tb_client.First(t => t.id_client == id);

            DB.tb_client.Remove(remover);
            DB.SaveChanges();
        }

    }
}
