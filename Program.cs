using CP02.Entidades;
using CP02.Entidades.Enums;

List<Produto> produtos = new List<Produto>();
List<Pedido> pedidos = new List<Pedido>();
List<Funcionario> funcionarios = new List<Funcionario>();

int opcao = 0;

do
{
    Console.WriteLine("1 - Cadastrar Produto");
    Console.WriteLine("2 - Cadastrar Funcionário");
    Console.WriteLine("3 - Cadastrar Pedido");
    Console.WriteLine("4 - Listar Produtos");
    Console.WriteLine("5 - Listar Clientes");
    Console.WriteLine("6 - Listar Pedidos");
    Console.WriteLine("7 - Calcular Pagamento");
    Console.WriteLine("8 - Sair");
    Console.Write("Opcao: ");

    opcao = int.Parse(Console.ReadLine());

    Console.Clear();

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Cadastrar Produto");
            Produto produto = new Produto();

            Console.Write("Id: ");
            produto.Id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Valor: ");
            produto.Valor = double.Parse(Console.ReadLine());

            produtos.Add(produto);
            break;

        case 2:
            Console.WriteLine("Cadastrar Funcionário");
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Matrícula: ");
            funcionario.Matricula = Console.ReadLine();

            Console.Write("Email: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            funcionarios.Add(funcionario);

            break;

        case 3:
            Console.WriteLine("Efetuar venda");
            Pedido pedido = new Pedido();

            Console.Write("Quantos itens irão compor o pedido? ");
            int qtdItens = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdItens; i++)
            {
                ItemPedido item = new ItemPedido();

                Console.Write($"Id do Produto {i + 1}: ");
                int idProduto = int.Parse(Console.ReadLine());

                item.Produto = produtos.Find(produto => produto.Id == idProduto);
                item.Valor = item.Produto.Valor;

                Console.Write($"Quantidade do Produto {i + 1}: ");
                item.Quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine(item.SubTotal());

                pedido.AdicionarItem(item);
            }

            Console.Write("Matrícula do Funcionário: ");
            string matriculaFuncionario = Console.ReadLine();

            pedido.Funcionario = funcionarios.Find(funcionario => funcionario.Matricula == matriculaFuncionario);

            pedido.DataPedido = DateTime.Now;
            pedido.Status = StatusPedido.Processando;
            pedido.CalcularValor();

            pedidos.Add(pedido);

            break;

        case 4:
            Console.WriteLine("Listar Produtos");

            produtos.ForEach(produto =>
            {
                Console.WriteLine(produto);
            });

            break;

        case 5:
            Console.WriteLine("Listar Funcionários");

            funcionarios.ForEach(funcionario =>
            {
                Console.WriteLine(funcionario);
            });

            break;

        case 6:
            Console.WriteLine("Listar Pedidos");

            pedidos.ForEach(pedido =>
            {
                Console.WriteLine(pedido);
            });

            break;

        case 7:
            funcionarios.ForEach(funcionario =>
            {
                Console.WriteLine(funcionario.CalcularPagamento());
            });
    }

    Console.ReadKey();
    Console.Clear();
} while (opcao != 8);
