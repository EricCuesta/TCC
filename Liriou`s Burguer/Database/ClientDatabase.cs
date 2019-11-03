using System.Collections.Generic;
using System.Linq;

namespace Liriou_s_Burguer.Database
{
    class ClientDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_client client)
        {
            db.tb_client.Add(client);

            db.SaveChanges();
        }

        public Entities.tb_client ConsultaPorID(int id)
        {
            Entities.tb_client client = db.tb_client.FirstOrDefault(t => t.id_client == id);

            return client;
        }

        public List<Entities.tb_client> ConsultarPorNome(Entities.tb_client client)
        {
            List<Entities.tb_client> list = db.tb_client.Where(l => l.nm_firstName == client.nm_firstName).ToList();

            return list;
        }

        public List<Entities.tb_client> ConsultarPorRG(Entities.tb_client client)
        {
            List<Entities.tb_client> list = db.tb_client.Where(l => l.nr_rg == client.nr_rg).ToList();

            return list;
        }

        public List<Entities.tb_client> ConsultarPorSexo(Entities.tb_client client)
        {
            List<Entities.tb_client> list = db.tb_client.Where(l => l.ds_sex == client.ds_sex).ToList();

            return list;
        }

        public List<Entities.tb_client> ConsultarPorNomeRG(Entities.tb_client client)
        {
            List<Entities.tb_client> list = db.tb_client.Where(l => l.nm_firstName == client.nm_firstName && l.nr_rg == client.nr_rg).ToList();

            return list;
        }

        public List<Entities.tb_client> ConsultarPorNomeSexo(Entities.tb_client client)
        {
            List<Entities.tb_client> list = db.tb_client.Where(l => l.nm_firstName == client.nm_firstName && l.ds_sex == client.ds_sex).ToList();

            return list;
        }

        public List<Entities.tb_client> ConsultarPorRGSexo(Entities.tb_client client)
        {
            List<Entities.tb_client> list = db.tb_client.Where(l => l.nr_rg == client.nr_rg && l.ds_sex == client.ds_sex).ToList();

            return list;
        }

        public List<Entities.tb_client> ConsultarTodos()
        {
            List<Entities.tb_client> list = db.tb_client.ToList();

            return list;
        }

        public void Alterar(Entities.tb_client client)
        {
            Entities.tb_client list = db.tb_client.FirstOrDefault(l => l.id_client == client.id_client);
            list.nm_firstName = client.nm_firstName;
            list.nm_lastName = client.nm_lastName;
            list.nr_rg = client.nr_rg;
            list.nr_cpf = client.nr_cpf;
            list.ds_sex = client.ds_sex;
            list.dt_birth = client.dt_birth;
            list.ds_state = client.ds_state;
            list.nr_cep = client.nr_cep;
            list.ds_address = client.ds_address;
            list.ds_note = client.ds_note;
            list.nr_cellphone = client.nr_cellphone;
            list.nr_tellphone = client.nr_tellphone;
            list.ds_email = client.ds_email;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_client client = db.tb_client.First(t => t.id_client == id);

            db.tb_client.Remove(client);
            db.SaveChanges();
        }
    }
}
