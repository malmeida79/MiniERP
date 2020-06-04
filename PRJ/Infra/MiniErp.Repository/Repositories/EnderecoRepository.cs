using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniErp.Domain;

namespace MiniErp.Repository.Repositories
{
    public class EnderecoRepository
    {
        public async Task<IEnumerable<Endereco>> Get()
        {
            return new Endereco[] { new Endereco() {
                CepEndereco = "02145000"
            }, new Endereco() {
                CepEndereco = "03912000"
            }
            };
        }

        public async Task<Endereco> Get(int id)
        {
            return new Endereco()
            {

            };
        }

        public async Task<bool> Add(Endereco Endereco)
        {
            return true;
        }

        public async Task<bool> Save(int id, Endereco Endereco)
        {
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            return true;
        }
    }
}
