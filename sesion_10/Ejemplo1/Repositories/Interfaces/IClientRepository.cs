using Ejemplo1.Models;

namespace Ejemplo1.Repositories.Interfaces
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAll();
        Client Get(int id);
        void Add(Client client);
        void Update(Client client);
        void Delete(int id);
        void LoadData();
    }
}