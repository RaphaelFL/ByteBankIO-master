using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void CriarAquivo()
    {
        var caminhoNovoArquivo = "contasExportatada.csv";
        using (var fluoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }
    static void CriarAquivoComWrite()
    {
        var caminhoNovoArquivo = "contaExportada.csv";
        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.WriteLine("456, 65433, 456.0, Pedro");
        }
    }
    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "texxte.txt";
        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 20; i++)
            {
                escritor.WriteLine($"linha {i}");
                escritor.WriteLine($"linha {i} foi salva no arquivo. Aperte enter...");
                Console.ReadLine();
            }
        }
    }
}
