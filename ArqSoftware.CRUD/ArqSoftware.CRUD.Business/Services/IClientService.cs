
using ArqSoftware.CRUD.Models;

namespace ArqSoftware.CRUD.Business.Services
{
    public interface IClientService
    {
        Client Add(Client client);
        void Update(Client client);
        Client Get(int id);
        List<Client> Get();
        void Delete(int id);
    }
}
