using _11___Eventos.Lib;
using _11___Eventos.Lib.Mensageiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11___Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_video_encoder.Click += EventoClick;
        }

        public void EventoClick(object sender, EventArgs args)
        {
            var video = new Video() { Nome = "novo_video.mp4" };
            var encoder = new VideoEncoder();

            encoder.Encoded += new Email().EnviarMensagem;
            encoder.Encoded += new SMS().EnviarMensagem;

            encoder.Encode(video);
        }
    }
}
