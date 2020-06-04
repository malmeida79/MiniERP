using System.Collections.Generic;
using System.Web.Http;
using MiniErp.Domain;
using System.Threading.Tasks;
using MiniErp.Repository.Repositories;

namespace MiniErp.Api.Controllers
{
    public class ClientePessoaFisicaController : ApiController
    {
        private ClientePessoaFisicaRepository clientePessoaFisicaRepository = new ClientePessoaFisicaRepository();

        // GET: api/ClientePessoaFisica
        public async Task<IEnumerable<ClientePessoaFisica>> Get()
        {
            return await clientePessoaFisicaRepository.Get();
        }

        // GET: api/ClientePessoaFisica/5
        public async Task<ClientePessoaFisica> Get(int id)
        {
            return await clientePessoaFisicaRepository.Get(id);
        }

        // POST: api/ClientePessoaFisica
        public async Task<bool> Post([FromBody]ClientePessoaFisica clientePessoaFisica)
        {
            return await clientePessoaFisicaRepository.Add(clientePessoaFisica);
        }

        // PUT: api/ClientePessoaFisica/5
        public async Task<bool> Put(int id, [FromBody]ClientePessoaFisica clientePessoaFisica)
        {
            return await clientePessoaFisicaRepository.Save(id, clientePessoaFisica);
        }

        // DELETE: api/ClientePessoaFisica/5
        public async Task<bool> Delete(int id)
        {
            return await clientePessoaFisicaRepository.Delete(id);
        }
    }
}
