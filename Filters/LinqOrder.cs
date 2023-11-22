using Consumindo_API___Externa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumindo_API___Externa.Filters
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List <Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

            Console.WriteLine("Lista de Artistas Ordenados:\n");

            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }
    }
}
