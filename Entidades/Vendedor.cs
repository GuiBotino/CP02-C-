namespace CP02.Entidades
{
    internal class Vendedor : Funcionario
    {
        public Vendedor()
        {

        }

        public Vendedor(string nome, string matricula, double salario) : base(nome, matricula, salario)
        {
 
        }

        public override sealed double CalcularPagamento()
        {
            return Salario;
        }
    }
}
