using System;
namespace DIO.Series
{    class Program
    {   static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {   string opcaoUsuario = ObterOpcaoUsuario();
            while(opcaoUsuario.ToUpper() != "X")
            {   switch (opcaoUsuario)
                {   case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        Console.WriteLine("Opção não reconhecida!");
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos servicos");
            Console.WriteLine();
        }
        private static void ListarSeries()
        {   Console.WriteLine("Listar series:");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {   Console.WriteLine("Nenhuma série encontrada");
                return;
            }        
            foreach (var serie in lista)
            {   var excluido = serie.retornaExcluido();
                if (!excluido)
                {   Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());}
            }
        }
        private static void InserirSerie()
        {   Console.WriteLine("Inserir nova série:");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {   Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));}
            Console.Write("Digite  o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o ano de Inicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();
            Serie novaSerie = new Serie(id: repositorio.ProximoId(), genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);
            repositorio.Insere(novaSerie);
        }
        private static void AtualizarSerie()
        {   Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {   Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));}
            Console.Write("Digite  o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o ano de Inicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();
            Serie atualizaSerie = new Serie(id: indiceSerie, genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);
            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }
        private static void ExcluirSerie()
        {   Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            int proximo = repositorio.ProximoId();
            if (indiceSerie < proximo)
            {   Serie Excluir = repositorio.RetornaPorId(indiceSerie);
                string titulo = Excluir.retornaTitulo();
                Console.WriteLine("Tem certeza que deseja excluir: {0}", titulo);
                Console.WriteLine("1 - Sim");
                Console.WriteLine("0 - Não");
                int confirmacao = int.Parse(Console.ReadLine());
                if (confirmacao == 1)
                    {   repositorio.Exclui(indiceSerie);}}
            else {Console.WriteLine("Id não encontrado");}
        }
        private static void VisualizarSerie()
        {   Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            int proximo = repositorio.ProximoId();
            if (indiceSerie < proximo)
            {   var serie = repositorio.RetornaPorId(indiceSerie);
                Console.WriteLine(serie);}
            else {Console.WriteLine("Id não encontrado");}
        }
        private static string ObterOpcaoUsuario()
        {   Console.WriteLine();
            Console.WriteLine("DIO Series a seu dispor!");
            Console.WriteLine("Informe a opcao desejada:");
            Console.WriteLine("1 - Listar Series");
            Console.WriteLine("2 - Inserir nova serie");
            Console.WriteLine("3 - Atualizar serie");
            Console.WriteLine("4 - Excluir serie");
            Console.WriteLine("5 - Visualizar serie");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
}}}