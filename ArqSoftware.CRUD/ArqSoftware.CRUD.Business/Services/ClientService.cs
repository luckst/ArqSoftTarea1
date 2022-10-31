using ArqSoftware.CRUD.Data.Repositories;
using ArqSoftware.CRUD.Models;
using System.Diagnostics;

namespace ArqSoftware.CRUD.Business.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client Add(Client client)
        {
            try
            {
                client.CreationDate = DateTime.Now;
                return _clientRepository.Add(client);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        public void Delete(int id)
        {
            try
            {
                _clientRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public Client Get(int id)
        {
            try
            {
                return _clientRepository.Get(id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        public List<Client> Get()
        {
            try
            {
                return _clientRepository.Get();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return new List<Client>();
            }
        }

        public void Update(Client client)
        {
            try
            {
                _clientRepository.Update(client);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
