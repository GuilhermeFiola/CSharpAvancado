using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11___Eventos.Lib
{
    public class VideoEncoder
    {
        //public delegate void VideoEncoderHandler(Video video);
        //public event VideoEncoderHandler Encoded;

        public event EventHandler<VideoEventArgs> Encoded;

        public void Encode(Video video)
        {
            Console.WriteLine($"Codificando o video...");
            Thread.Sleep(2000);
            Console.WriteLine($"Video convertido!");

            Encoded(this, new VideoEventArgs() { Video = video });
        }

        public class VideoEventArgs : EventArgs
        {
            public Video Video { get; set; }
        }
    }
}
