using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace _22___Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definição de diversas tarefas
            //Task.Run(() => MetodoUm());
            //Task.Run(() => MetodoUm());
            //Task.Factory.StartNew(MetodoUm);

            // Lista de tarefas com WaitAll
            //var lista = new List<Task>
            //{
            //    Task.Factory.StartNew(MetodoUm),
            //    Task.Factory.StartNew(MetodoUm),
            //    Task.Factory.StartNew(MetodoUm)
            //};

            //Task.WaitAll(lista.ToArray());

            //Método para download de páginas
            var enderecos = new string[] { "http://google.com.br", "http://microsoft.com.br" };
            var listaEnderecos = from end in enderecos select DownloadPagina(end);

            Task.WaitAll(listaEnderecos.ToArray());

            // Se não travar o processo ele termina sem a execução
            Console.ReadKey();
        }

        static void MetodoUm()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Valor: {i} | Thread: {Task.CurrentId}");
            }
        }

        static async Task<string> DownloadPagina(string endereco)
        {
            var web = new WebClient();
            
            // Demonstração de Task com WaitAll e Await para resultado
            var taskHtml = web.DownloadStringTaskAsync(endereco);
            Task.WaitAll(taskHtml);
            var resultado = await taskHtml;
            
            Console.WriteLine($"Download da página \"{endereco}\" foi realizado");
            return resultado;
        }
    }
}
