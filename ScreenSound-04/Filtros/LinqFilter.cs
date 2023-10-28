using ScreenSound_04.Modelos;


namespace ScreenSound_04.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList(); // Distinct: Distinguir e To list: Retornar como lista // variavel criada para selecionar os generos

            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var ArtistasPorGeneros = musicas.Where(musicas => musicas.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

            Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
            foreach (var artista in ArtistasPorGeneros)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string NomeDoArtista)
        {
            var MusicasPorArtistas = musicas.Where(musicas => musicas.Artista!.Equals(NomeDoArtista)).ToList();

            Console.WriteLine($"Exibindo as musicas do Artista >>> {NomeDoArtista}");
            foreach (var musica in MusicasPorArtistas)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }

        public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
        {
            var musicasDoAno = musicas.Where(musica => musica.Ano == ano)
                .OrderBy(musicas => musicas.Nome) 
        .Select(musicas => musicas.Nome) 
                .Distinct() 
                .ToList(); 

            Console.WriteLine($"Músicas de {ano}");
            foreach (var musica in musicasDoAno)
            {
                Console.WriteLine($"- {musica}");
            }
        }

        public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, int tonalidade)
        {
            var MusicasPorTonalidade = musicas.Where(musica => musica.Key == tonalidade).Select(musicas=>musicas.Nome).ToList();

            Console.WriteLine($"Musicas por Tonalidade: {tonalidade}");
            foreach(var musica in MusicasPorTonalidade)
            {
                Console.WriteLine($"- {musica}");
            }
        }

    }
}
