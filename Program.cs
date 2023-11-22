using Consumindo_API___Externa.Filters;
using Consumindo_API___Externa.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string api = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(api);

        //LinqFilter.FiltrarTodosOsGeneros(musicas);

        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");

        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        // LinqFilter.FiltrarMusicasPorAno(musicas, "2014");

        //var musicasPreferidasDaniel = new MusicasFavoritas("Daniel");

        //musicasPreferidasDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDaniel.AdicionarMusicasFavoritas(musicas[13]);
        //musicasPreferidasDaniel.AdicionarMusicasFavoritas(musicas[50]);
        //musicasPreferidasDaniel.AdicionarMusicasFavoritas(musicas[502]);
        //musicasPreferidasDaniel.AdicionarMusicasFavoritas(musicas[1993]);

        //musicasPreferidasDaniel.ExibirMusicasFavoritas();

        var musicasPreferidasPedro = new MusicasFavoritas("Pedro");

        musicasPreferidasPedro.AdicionarMusicasFavoritas(musicas[300]);
        musicasPreferidasPedro.AdicionarMusicasFavoritas(musicas[830]);
        musicasPreferidasPedro.AdicionarMusicasFavoritas(musicas[309]);
        musicasPreferidasPedro.AdicionarMusicasFavoritas(musicas[1512]);
        musicasPreferidasPedro.AdicionarMusicasFavoritas(musicas[990]);

        musicasPreferidasPedro.ExibirMusicasFavoritas();

        // musicasPreferidasPedro.GerarArquivoJson();
        musicasPreferidasPedro.GerarDocumentoTXTComAsMusicasFavoritas();
    }

    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

