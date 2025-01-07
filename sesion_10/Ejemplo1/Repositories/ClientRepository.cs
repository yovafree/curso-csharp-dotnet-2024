using Ejemplo1.Models;
using Ejemplo1.Repositories.Interfaces;

namespace Ejemplo1.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDBContext _context;
        public ClientRepository(AppDBContext context)
        {
            _context = context;   
        }

        public void LoadData()
        {
            List<Client> _clients;
            _clients = new List<Client>
            {
                new Client { Name = "Juan", LastName = "Perez", Email = "juan@gmail.com" },
                new Client { Name = "Maria", LastName = "Lopez", Email = "Maria@gmail.com" },
                new Client { Name = "Pedro", LastName = "Gomez", Email = "Pedro@gmail.com"},
            };

            _context.Clients.AddRange(_clients);
            _context.SaveChanges();
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public Client Get(int id)
        {
            return _context.Clients.Find(id);
        }

        public void Add(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void Update(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var client = _context.Clients.Find(id);
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }
    }
}