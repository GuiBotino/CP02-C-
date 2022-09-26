namespace CP02.Entidades
{
    internal class Gerente : Funcionario
    {
        public Gerente()
        {

        }

        public Gerente(string nome, string matricula, double salario) : base(nome, matricula, salario)
        {

        }

        public override sealed double CalcularPagamento()
        {
            return Salario;
        }
    }
}
