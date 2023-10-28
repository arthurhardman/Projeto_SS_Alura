using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; // Usado para transformar o Json na lista feita em Musica.cs
        // musicas[1].ExibirDetalhesDaMusica();
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Lady Gaga");
        // LinqFilter.FiltrarMusicasPeloAno(musicas, 2010);

        //var musicasPreferidasDoArthur = new MusicasPreferidas("Arthur");
        //musicasPreferidasDoArthur.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoArthur.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoArthur.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoArthur.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoArthur.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDoArthur.ExibirMusicasFavoritas();

        //musicasPreferidasDoArthur.GerarArquivoJson();

        LinqFilter.FiltrarMusicasPorTonalidade(musicas, 1);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}