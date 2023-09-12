﻿using ByteBankIO;
using System.Text;
using System.Text.Unicode;

partial class Program
{

    static void LidandoComfileStreamDiretamente()
    {

        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024]; //1KB      

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                EscreveBuffer(buffer, numeroDeBytesLidos);
            }

            fluxoDoArquivo.Close();

            Console.ReadLine();
        }
    }



    static void EscreveBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write("");
        }

    }
}