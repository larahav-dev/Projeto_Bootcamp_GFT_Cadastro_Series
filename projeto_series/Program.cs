using System;

namespace projeto_series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
        string opcaoUsuario = ObterOpcaoUsuario();
       
        while (opcaoUsuario.ToUpper() != "X")
         {
             switch (opcaoUsuario)
           {
             case "1":
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
                throw new ArgumentOutOfRangeException();
            }
            opcaoUsuario = ObterOpcaoUsuario();
         }

         Console.WriteLine("Seja sempre bem-vindo");
         Console.ReadLine();
        
        }
        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach(var serie in lista)
            {
                var excluido = serie.retornaExcluido();

            Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*" : ""));
            }
        }
          private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1} ", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o genêro entre as opções acima: ");
            int EntradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string EntradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de inicio da série: ");
            int EntradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string EntradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie
            (
                id: repositorio.ProximoId(),
                genero: (Genero)EntradaGenero,
                titulo: EntradaTitulo,
                ano: EntradaAno,
                descricao: EntradaDescricao
            );

            repositorio.insere(novaSerie);
        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o ID da série: ");
            int IndiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1} ", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o genêro entre as opções acima: ");
            int EntradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string EntradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de inicio da série: ");
            int EntradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string EntradaDescricao = Console.ReadLine();

            Serie AtualizaSerie = new Serie
            (
                id: IndiceSerie,
                genero: (Genero)EntradaGenero,
                titulo: EntradaTitulo,
                ano: EntradaAno,
                descricao: EntradaDescricao
            );

            repositorio.Atualiza(IndiceSerie, AtualizaSerie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o ID da série: ");
            int IndiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(IndiceSerie);
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o ID da série: ");
            int IndiceSerie = int.Parse(Console.ReadLine());

            var Serie = repositorio.RetornaPorId(IndiceSerie);

            Console.WriteLine(Serie);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Apresento Project Séries");
            Console.WriteLine("Informe à opção desejada");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir novo série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série ");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }


}
