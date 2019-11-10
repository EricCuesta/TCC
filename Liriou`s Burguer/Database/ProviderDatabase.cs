using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class ProviderDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_provider provider)
        {
            db.tb_provider.Add(provider);

            db.SaveChanges();
        }

        public Entities.tb_provider ConsultaPorID(int id)
        {
            Entities.tb_provider provider = db.tb_provider.FirstOrDefault(t => t.id_provider == id);

            return provider;
        }

        public List<Entities.tb_provider> ConsultarPorNome(Entities.tb_provider provider)
        {
            List<Entities.tb_provider> list = db.tb_provider.Where(l => l.nm_provider == provider.nm_provider).ToList();

            return list;
        }

        public List<Entities.tb_provider> ConsultarPorTipoDePessoa(Entities.tb_provider provider)
        {
            List<Entities.tb_provider> list = db.tb_provider.Where(l => l.ds_typePerson == provider.ds_typePerson).ToList();

            return list;
        }

        public List<Entities.tb_provider> ConsultarPorNomeTipoDePessoa(Entities.tb_provider provider)
        {
            List<Entities.tb_provider> list = db.tb_provider.Where(l => l.nm_provider == provider.nm_provider && l.ds_typePerson == provider.ds_typePerson).ToList();

            return list;
        }

        public List<Entities.tb_provider> ConsultarTodos()
        {
            List<Entities.tb_provider> list = db.tb_provider.ToList();

            return list;
        }

        public void Alterar(Entities.tb_provider provider)
        {
            Entities.tb_provider list = db.tb_provider.FirstOrDefault(l => l.id_provider == provider.id_provider);
            list.nm_provider = provider.nm_provider;
            list.nm_name = provider.nm_name;
            list.ds_typePerson = provider.ds_typePerson;
            list.nr_identification = provider.nr_identification;
            list.ds_state = provider.ds_state;
            list.nr_cep = provider.nr_cep;
            list.ds_address = provider.ds_address;
            list.ds_note = provider.ds_note;
            list.nr_cellphone = provider.nr_cellphone;
            list.nr_tellphone = provider.nr_tellphone;
            list.ds_email = provider.ds_email;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_provider provider = db.tb_provider.First(t => t.id_provider == id);

            db.tb_provider.Remove(provider);
            db.SaveChanges();
        }
    }
}
