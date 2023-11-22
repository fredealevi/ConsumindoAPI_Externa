using Consumindo_API___Externa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumindo_API___Externa.Filters
{
    public class LinqFilter
    {
        public static void FiltrarTodosOsGeneros(List<Musica> musicas)
        {
            var generos = musicas.Select(generos => generos.Genero).Distinct().ToList();

            foreach(var genero in generos) 
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

            LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();

            Console.WriteLine($"As músicas do artista {artista} são:\n");

            foreach(var musica in musicasDoArtista)
                Console.WriteLine(musica.Nome);
        }

        public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
        {
            var musicaAnoLancamento = musicas.Where(musica => musica.Ano!.Equals(ano)).OrderBy(musicas => musicas.Nome).Distinct().ToList();

            Console.WriteLine($"As músicas lançadas no ano {ano} são:\n");
            foreach(var musica in musicaAnoLancamento)
                Console.WriteLine(musica.Nome);

        }
    }
}
