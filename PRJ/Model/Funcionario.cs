namespace MiniErp.Model.model
{
    public class Funcionario : Pessoa
    {
        public int IdFuncionario { get; set; }
        public Usuario Usuario { get; set; }
        public Departamento Departamento { get; set; }
    }
}
