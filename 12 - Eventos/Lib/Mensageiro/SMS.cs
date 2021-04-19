using System;
using static _11___Eventos.Lib.VideoEncoder;

namespace _11___Eventos.Lib.Mensageiro
{
    public class SMS
    {
        public void EnviarMensagem(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"SMS enviado para o video {args.Video.Nome}");
        }

    }
}
