using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\PC-QUARTO\Documents\Visual Studio 2017\Projects\Curso\Arquivos\file1.txt";
            string destino = @"C:\Users\PC-QUARTO\Documents\Visual Studio 2017\Projects\Curso\Arquivos\file2.txt";

            FileStream fs = null;
            StreamReader sr = null;
            /*
            try
            {
                FileInfo arquivo = new FileInfo(caminho);
                //arquivo.CopyTo(destino);
                string[] linhas = File.ReadAllLines(caminho);
                foreach (var item in linhas)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("Um erro ocorreu " + e.Message ) ;
            }
            */
            try
            {
                fs = new FileStream(caminho, FileMode.Open);
                sr = new StreamReader(fs);

                string linha = sr.ReadLine();
                Console.WriteLine(linha);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }
            Console.ReadKey();
        }
        
    }
}
