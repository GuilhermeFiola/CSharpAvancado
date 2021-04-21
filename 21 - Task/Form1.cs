using System;
using System.Windows.Forms;
using System.Net;
using System.Threading.Tasks;

namespace _21___Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_download_Click(object sender, EventArgs e)
        {
            var endereco = txt_site.Text;
            var web = new WebClient();

            // Sync
            //var html = web.DownloadString(endereco);

            // TASK - Async
            var html = await web.DownloadStringTaskAsync(new Uri(endereco));
            
            rtx_site.Text = html;
        }
    }
}
