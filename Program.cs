using SoundTrack.Menu;
using SoundTrack.Model;

class Program 
{
    static void Main()
    {
        List<Banda> bandasRegistradas = new List<Banda>();
        List<Podcast> podcastList = new List<Podcast>();

        Banda person = new("Linkin Park", new List<int> { 10, 20, 10 });
        Musica musica = new("forever alone", 45);
        person.AddMusic(musica);
        bandasRegistradas.Add(person);

        Podcast podcast = new("reino animal", "Gustavo");
        podcastList.Add(podcast);

        Episodio episodio = new(1, "Teste episodio", 45);
        podcast.AddEpisodio(episodio);

        Dictionary<int, Menu<Banda>> opcoes = new();

        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuMostrarBandas());
        opcoes.Add(3, new MenuAvaliarUmaBanda());
        opcoes.Add(4, new MenuExibirMedia());
        opcoes.Add(5, new MenuProcurePorUmaBanda());
        opcoes.Add(6, new MenuRegistrarMusica());

        Dictionary<int, Menu<Podcast>> opcoesPodcast = new();

        opcoesPodcast.Add(7, new MenuRegistrarPodcast());
        opcoesPodcast.Add(8, new MenuMostrarPodcast());
        opcoesPodcast.Add(9, new MenuProcurarUmPodcast());
        opcoesPodcast.Add(10, new MenuRegistrarEpisodio());

        void ExibirLogo()
        {
            Console.WriteLine("Boas vindas ao Screen Sound");
        }


        void MenuOpcao()
        {
            Console.WriteLine("Digite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a media de uma banda");
            Console.WriteLine("Digite 5 para procurar por uma banda");
            Console.WriteLine("Digite 6 para registrar uma musica para a banda");
            Console.WriteLine("Digite 7 para registrar um podcast");
            Console.WriteLine("Digite 8 para mostrar todos os podcast");
            Console.WriteLine("Digite 9 para procurar por um podcast");
            Console.WriteLine("Digite 10 para adicionar um episodio ao podcast");
            Console.WriteLine("Digite -1 para sair do programa");
        }

        void ExibirOpcoesDoMenu()
        {
            MenuOpcao();

            Console.WriteLine("\nDigite a sua opção: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine()!);

            if(opcoes.ContainsKey(opcaoEscolhida)) 
            { 
                var menuExibido = opcoes[opcaoEscolhida];

                if(menuExibido != null)
                {
                    menuExibido.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                }

                
            }
            else if (opcoesPodcast.ContainsKey(opcaoEscolhida))
            {
                var podcastExibido = opcoesPodcast[opcaoEscolhida];

                if (podcastExibido != null)
                {
                    podcastExibido.Executar(podcastList);
                    ExibirOpcoesDoMenu();
                }
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }

        ExibirOpcoesDoMenu();
    }
}