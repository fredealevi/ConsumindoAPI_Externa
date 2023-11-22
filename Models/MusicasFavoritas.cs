using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Consumindo_API___Externa.Models
{
    public class MusicasFavoritas
    {
        public MusicasFavoritas(string nome)
        {
            Nome = nome;
            Favoritas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            Favoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favoritas de {Nome}");

            foreach (var musica in Favoritas)
                Console.WriteLine($" - {musica.Nome} - artista {musica.Artista}");
            
            Console.WriteLine();
        }


        public string Nome { get; set; }
        public List<Musica> Favoritas { get; set; }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = Favoritas
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
        }

        public void GerarDocumentoTXTComAsMusicasFavoritas()
        {
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
            using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
            {
                arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
                foreach (var musica in Favoritas)
                {
                    arquivo.WriteLine($"- {musica.Nome}");
                }
            }
            Console.WriteLine("txt gerado com sucesso!");
        }

    }
}
