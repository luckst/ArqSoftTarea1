using ArqSoftware.CRUD.Models;

namespace ArqSoftware.CRUD.Data.Repositories
{
    public interface IClientRepository
    {
        Client Add(Client client);
        void Update(Client client);
        Client Get(int id);
        List<Client> Get();
        void Delete(int id);
    }
}
