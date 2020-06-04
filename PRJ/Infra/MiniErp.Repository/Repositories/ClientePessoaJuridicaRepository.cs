using System.Collections.Generic;
using System.Threading.Tasks;
using MiniErp.Domain;

namespace MiniErp.Repository.Repositories
{
    public class ClientePessoaJuridicaRepository
    {
        public async Task<IEnumerable<ClientePessoaJuridica>> Get()
        {
            return new ClientePessoaJuridica[] { new ClientePessoaJuridica() { }, new ClientePessoaJuridica() { } };
        }

        public async Task<ClientePessoaJuridica> Get(int id)
        {
            return new ClientePessoaJuridica() { };
        }

        public async Task<bool> Add(ClientePessoaJuridica clientePessoaJuridica)
        {
            return true;
        }

        public async Task<bool> Save(int id, ClientePessoaJuridica clientePessoaJuridica)
        {
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            return true;
        }
    }
}
