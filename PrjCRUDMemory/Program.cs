// See https://aka.ms/new-console-template for more information
namespace PrjCRUDMemory{
   public class Progam {

       static SerieRepositorio repositorio = new SerieRepositorio();
       static void Main(string[] args){
            string opcaousuario=MenuUsuario();
            while (opcaousuario.ToUpper()!="X")
            {
                switch (opcaousuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2" :
                        InserirSerie();
                        break;
                    case "3" : 
                         AtualizarSerie();
                        break;
                    case "4":
                        //ExcluirSerie();
                        break;
                    case "C" :
                        Console.Clear();
                        break;
                    
                    default : 
                        throw new ArgumentOutOfRangeException();
                }
                opcaousuario = MenuUsuario();
            
                
            }
       }

        private static void VisualizarSerie(){
            Console.Write("Digite o id da série: ");
            int indiceSerie =int.Parse(Console.ReadLine());
            var serie = repositorio.RetonaPorId(indiceSerie);
            Console.WriteLine(serie);
        }

       private static void ExcluirSerie(){
           Console.Write("Digite o id da série: ");
           int indiceSerie = int.Parse(Console.ReadLine());
           repositorio.Exclui(indiceSerie);
       }
       private static void AtualizarSerie(){
           Console.WriteLine("Digite o id da série: ");
           int indiceSerie = int.Parse(Console.ReadLine());
           foreach (int i in Enum.GetValues(typeof(Genero)))
           {
               Console.WriteLine("{0} - {1}", i,Enum.GetName(typeof(Genero),i));
               
           }
           Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescrição = Console.ReadLine();
               Serie atualizarSerie = new Serie(id: indiceSerie, 
                   genero: (Genero) entradaGenero, 
                   titulo: entradaTitulo,
                   descricao: entradaDescrição,
                   ano:  entradaAno);
            repositorio.Atualizar(indiceSerie,atualizarSerie);

       }

        private static void InserirSerie(){
            Console.WriteLine("Inserir nova série");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}",i,Enum.GetName(typeof(Genero),i));
               
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescrição = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(), 
                   genero: (Genero) entradaGenero, 
                   titulo: entradaTitulo,
                   descricao: entradaDescrição,
                   ano:  entradaAno);
            repositorio.Insere(novaSerie);
        }

        private static void ListarSeries(){
            Console.WriteLine("Lista Séries");
            var lista = repositorio.Lista();

            if (lista.Count==0){
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retonarExcluido();
                Console.WriteLine("ID {0}: - {1} - {2}", serie.retornaID(), serie.retornaTitulo, serie.retonarExcluido(), (excluido? "Excluído" : "Não excluído"));
                
            }
            Console.ReadKey();
        }


       private static string MenuUsuario(){
           Console.WriteLine();
           Console.WriteLine("Informe a opção desejada");
           Console.WriteLine("1. Listar séries");
           Console.WriteLine("2. Inserir nova série");
           Console.WriteLine("3. Atualizar série");
           Console.WriteLine("4. Excluir Série");
           Console.WriteLine("5. Visualizr série");
           Console.WriteLine("C. Limpar tela");
           Console.WriteLine("X - Sair");
           Console.WriteLine();

           string opcaousuario=Console.ReadLine().ToUpper();
           Console.WriteLine();
           return opcaousuario;

       }
   }


}


