using ArqSoftware.CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ArqSoftware.CRUD.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Client Add(Client client)
        {
            using (var context = new CrudContext())
            {
                context.Add(client);
                context.SaveChanges();
            }

            return client;
        }

        public void Delete(int id)
        {
            using (var context = new CrudContext())
            {
                var client = context.Find<Client>(id);
                if (client is null)
                    return;

                context.Remove(client);
                context.SaveChanges(true);
            }
        }

        public Client Get(int id)
        {
            using (var context = new CrudContext())
            {
                return context.Find<Client>(id);
            }
        }

        public List<Client> Get()
        {
            using (var context = new CrudContext())
            {
                var clients = context.Set<Client>();
                return clients.ToList();
            }
        }

        public void Update(Client client)
        {
            using (var context = new CrudContext())
            {
                var clients = context.Set<Client>();
                clients.Attach(client);
                context.Entry(client).State = EntityState.Modified;
                context.SaveChanges(true);
            }
        }
    }
}
