using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {
            var artistasOrdenador = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine("Lista de Artistas Ordenados: ");
            foreach (var artista in artistasOrdenador) 
            { 
                Console.WriteLine($"- {artista}"); 
            }
        }
    }
}
