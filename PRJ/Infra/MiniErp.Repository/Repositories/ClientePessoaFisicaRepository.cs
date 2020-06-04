using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiniErp.Domain;

namespace MiniErp.Repository.Repositories
{
    public class ClientePessoaFisicaRepository
    {
        public async Task<IEnumerable<ClientePessoaFisica>> Get()
        {
            return new ClientePessoaFisica[] { new ClientePessoaFisica() {
                IDPessoa = 1,
                NomePessoa = "Marcos Almeida",
                Cpf = "123.456.789-01",
                Saldo = Convert.ToDecimal("125,12"),
                DataUltimaCompra = DateTime.Now.AddDays(-6)
            }, new ClientePessoaFisica() {
                IDPessoa = 2,
                NomePessoa = "Marcelo Bogás",
                Cpf = "123.456.789-01",
                Saldo = Convert.ToDecimal("200,12"),
                DataUltimaCompra = DateTime.Now.AddDays(-10)
            }
            };
        }

        public async Task<ClientePessoaFisica> Get(int id)
        {
            return new ClientePessoaFisica() { };
        }

        public async Task<bool> Add(ClientePessoaFisica clientePessoaFisica)
        {
            return true;
        }

        public async Task<bool> Save(int id, ClientePessoaFisica clientePessoaFisica)
        {
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            return true;
        }
    }
}
