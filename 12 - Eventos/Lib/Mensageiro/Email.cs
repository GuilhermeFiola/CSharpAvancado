using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _11___Eventos.Lib.VideoEncoder;

namespace _11___Eventos.Lib.Mensageiro
{
    public class Email
    {
        public void EnviarMensagem(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"E-mail enviado para o video {args.Video.Nome}");
        }
    }
}
