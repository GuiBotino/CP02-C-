namespace CP02.Entidades
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, string matricula, double salario)
        {
            Nome = nome;
            Matricula = matricula;
            Salario = salario;
        }

        public virtual double CalcularPagamento()
        {
            return Salario;
        }
    }
}
