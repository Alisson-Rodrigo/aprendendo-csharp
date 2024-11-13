using System;
using System.IO;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Digite a URL do vídeo do YouTube:");
        var url = Console.ReadLine();

        var youtube = new YoutubeClient();

        try
        {
            // Obter informações do vídeo
            var video = await youtube.Videos.GetAsync(url);
            Console.WriteLine($"Título do vídeo: {video.Title}");

            // Obter o manifesto de streams
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

            // Tentar obter o melhor stream muxed (vídeo + áudio)
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            if (streamInfo != null)
            {
                // Definir o nome do arquivo com base no título do vídeo
                var fileName = $"{video.Title}.{streamInfo.Container.Name}";

                Console.WriteLine($"Baixando o vídeo com áudio e vídeo combinados para o arquivo: {fileName}...");
                await youtube.Videos.Streams.DownloadAsync(streamInfo, fileName);
                Console.WriteLine("Download concluído com sucesso!");
            }
            else
            {
                Console.WriteLine("Stream muxed (áudio + vídeo) não disponível. Tentando baixar o áudio separadamente...");

                // Tentar obter o melhor stream de áudio
                var audioStreamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                
                if (audioStreamInfo != null)
                {
                    // Definir o nome do arquivo com base no título do vídeo e no tipo de stream
                    var audioFileName = $"{video.Title}.{audioStreamInfo.Container.Name}";

                    Console.WriteLine($"Baixando apenas o áudio para o arquivo: {audioFileName}...");
                    await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, audioFileName);
                    Console.WriteLine("Download do áudio concluído com sucesso!");
                }
                else
                {
                    Console.WriteLine("Nenhum stream de áudio disponível.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao baixar o vídeo: {ex.Message}");
        }
    }
}
