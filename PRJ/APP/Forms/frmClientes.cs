using System;
using System.ComponentModel;
using System.Windows.Forms;
using MiniErp.Service.BaseApp;
using MiniErp.Domain;

using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace MiniErp.App.Forms
{
    public partial class frmClientes : Form
    {
        private string stringBaseUri = "api/ClientePessoaFisica/";

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            var permissoes = Ambiente.GetPermissoes(this.Name);

            defaultBarForms.NovoClick += new EventHandler(btnNovo_Click);
            defaultBarForms.SalvarClick += new EventHandler(btnSalvar_Click);
            defaultBarForms.EditarClick += new EventHandler(btnEditar_Click);
            defaultBarForms.CancelarClick += new EventHandler(btnCancelar_Click);
            defaultBarForms.ExcluirClick += new EventHandler(btnExcluir_Click);
            defaultBarForms.ImprimirClick += new EventHandler(btnImprimir_Click);

            defaultBarForms.PrimeiroClick += new EventHandler(btnPrimeiro_Click);
            defaultBarForms.AnteriorClick += new EventHandler(btnAnterior_Click);
            defaultBarForms.ProximoClick += new EventHandler(btnProximo_Click);
            defaultBarForms.UltimoClick += new EventHandler(btnUltimo_Click);

            defaultBarForms.FecharClick += new EventHandler(btnFechar_Click);

            defaultBarForms.DefaultFormBar(permissoes);
            dgClientes.DataSource = GetListaPessoaFisica();


        }

        public IEnumerable<ClientePessoaFisica> GetListaPessoaFisica()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Ambiente.GetBaseAppURI());
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(stringBaseUri).Result;
                if (response.IsSuccessStatusCode)
                {
                    var listaPessoas = response.Content.ReadAsStringAsync();
                    var dados = JsonConvert.DeserializeObject<List<ClientePessoaFisica>>(listaPessoas.Result);
                    return dados;
                }
                else
                {
                    Mensagens.Erro("Ocorreu um erro ao listar os clientes!");
                    return null;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimparImagem_Click(object sender, EventArgs e)
        {

        }

        private void btnNovaImagem_Click(object sender, EventArgs e)
        {

        }

        private void txtCpfCnpj_Validating(object sender, CancelEventArgs e)
        {

        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
