using CP02.Entidades.Enums;

namespace CP02.Entidades
{
    internal class Pedido
    {
        public DateTime DataPedido { get; set; }
        public double Valor { get; set; }
        public StatusPedido Status { get; set; }
        public Funcionario Funcionario { get; set; }
        public List<ItemPedido> Itens { get; set; }

        public void AdicionarItem(ItemPedido item)
        {
            if (Itens == null)
            {
                Itens = new List<ItemPedido>();
            }

            Itens.Add(item);
        }

        public void CalcularValor()
        {
            double soma = 0;

            Itens.ForEach(item =>
            {
                soma += item.SubTotal();
            });

            Valor = soma;
        }

        public override string ToString()
        {
            return $"{DataPedido} | {Valor} | {Status}";
        }
    }
}
