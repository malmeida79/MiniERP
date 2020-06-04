using System.Collections.Generic;
using System.Web.Http;
using MiniErp.Domain;
using System.Threading.Tasks;
using MiniErp.Repository.Repositories;

namespace MiniErp.Api.Controllers
{
    public class ClientePessoaJuridicaController : ApiController
    {
        private ClientePessoaJuridicaRepository clientePessoaJuridicaRepository = new ClientePessoaJuridicaRepository();

        // GET: api/ClientePessoaJuridica
        public async Task<IEnumerable<ClientePessoaJuridica>> Get()
        {
            return await clientePessoaJuridicaRepository.Get();
        }

        // GET: api/ClientePessoaJuridica/5
        public async Task<ClientePessoaJuridica> Get(int id)
        {
            return await clientePessoaJuridicaRepository.Get(id);
        }

        // POST: api/ClientePessoaJuridica
        public async Task<bool> Post([FromBody]ClientePessoaJuridica clientePessoaJuridica)
        {
            return await clientePessoaJuridicaRepository.Add(clientePessoaJuridica);
        }

        // PUT: api/ClientePessoaJuridica/5
        public async Task<bool> Put(int id, [FromBody]ClientePessoaJuridica clientePessoaJuridica)
        {
            return await clientePessoaJuridicaRepository.Save(id, clientePessoaJuridica);
        }

        // DELETE: api/ClientePessoaJuridica/5
        public async Task<bool> Delete(int id)
        {
            return await clientePessoaJuridicaRepository.Delete(id);
        }
    }
}
