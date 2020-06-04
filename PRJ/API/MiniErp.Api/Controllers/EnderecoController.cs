using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using MiniErp.Domain;
using MiniErp.Repository.Repositories;

namespace MiniErp.Api.Controllers
{
    public class EnderecoController : ApiController
    {
        private EnderecoRepository enderecoRepository = new EnderecoRepository();

        // GET: api/Endereco
        public async Task<IEnumerable<Endereco>> Get()
        {
            return await enderecoRepository.Get();
        }

        // GET: api/Endereco/{id}
        public async Task<Endereco> Get(int id)
        {
            return await enderecoRepository.Get(id);
        }

        // POST: api/Endereco
        public async Task<bool> Post([FromBody]Endereco endereco)
        {
            return await enderecoRepository.Add(endereco);
        }

        // PUT: api/Endereco/5
        public async Task<bool> Put(int id, [FromBody]Endereco endereco)
        {
            return await enderecoRepository.Save(id, endereco);
        }

        // DELETE: api/Endereco/5
        public async Task<bool> Delete(int id)
        {
            return await enderecoRepository.Delete(id);
        }
    }
}
