using ByteBankIO;
using System.Text;
using System.Text.Unicode;

partial class Program
{
    private static void Main(string[] args)
    {

        var caminhoNovoArquivo = "testaEscrita.txt";
        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 20; i++)
            {
                escritor.WriteLine(true);
                escritor.WriteLine(false);
                escritor.WriteLine(4545454);
                Console.ReadLine();
            }
            escritor.WriteLine("Aplicação Finalizada ...");
        }
        //TestaEscrita();
        //CriarAquivo();
        //CriarAquivoComWrite();

        //    Console.ReadLine();

        //    var enderecoDoArquivo = "contas.txt";

        //    using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        //    {
        //        var leitor = new StreamReader(fluxoDoArquivo);

        //        while (!leitor.EndOfStream)
        //        {
        //            var linha = leitor.ReadLine();
        //            var contaCorrente = ConverterStringParaContaCorrente(linha);

        //            var msg = $"Conta número {contaCorrente.Numero}, ag {contaCorrente.Agencia}, Saldo {contaCorrente.Saldo}";

        //            Console.WriteLine(msg);
        //         }

        //    }
        //}
        //static ContaCorrente ConverterStringParaContaCorrente(String linha)
        //{
        //    var campos = linha.Split(',');
        //    var agencia = campos[0];
        //    var numero = campos[1];
        //    var saldo = campos[2].Replace('.',',') ;
        //    var nomeTitular = campos[3];

        //    var agenciaComInt=int.Parse(agencia);
        //    var numeroComInt = int.Parse(numero);
        //    var saldoComDouble = int.Parse(saldo);

        //    var titular = new Cliente();
        //    titular.Nome = nomeTitular;

        //    var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
        //    resultado.Depositar(saldoComDouble);
        //    resultado.Titular = titular;

        //    return resultado;
    }
}