using System.Windows.Forms;

namespace MiniErp.Service.BaseApp
{
    public static class Mensagens
    {
        public static string MsgErro = string.Empty;

        public static void Alerta(string mensagem)
        {
            mensagem = mensagem.Replace(@"''", @"'").Replace(@"\\", @"\").Replace(@"""", "");
            MessageBox.Show(mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Erro(string mensagem)
        {
            mensagem = mensagem.Replace(@"''", @"'").Replace(@"\\", @"\").Replace(@"""", "");
            MessageBox.Show(mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Confirm(string mensagem)
        {
            mensagem = mensagem.Replace(@"''", @"'").Replace(@"\\", @"\").Replace(@"""", "");
            MessageBox.Show(mensagem, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}

