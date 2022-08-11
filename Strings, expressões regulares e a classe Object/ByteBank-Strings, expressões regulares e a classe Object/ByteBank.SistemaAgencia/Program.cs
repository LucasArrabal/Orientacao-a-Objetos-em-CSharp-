using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // teste com numero.4
            string padraoTeste3 = " [0-9]{4,5}-?[0-9]{4} ";
            string testeDoTeste3 = " Meu numero é 12341234 ";
            Match resultadoTeste3 = Regex.Match(testeDoTeste3, padraoTeste3);
            Console.WriteLine(resultadoTeste3.Value);
            Console.ReadLine();
            // teste com numero.3
            string padraoTeste2 = " [0-9]{4,5}[-]{0,1}[0-9]{4} ";
            string testeDoTeste2 = " Meu numero é 12341234 ";
            Match resultadoTeste2 = Regex.Match(testeDoTeste2, padraoTeste2);
            Console.WriteLine(resultadoTeste2.Value);
            Console.ReadLine();

            // teste com numero.2
            string padraoTeste1 = " [0-9]{4,5}[-][0-9]{4} ";
            string testeDoTeste1 = " Meu numero é 1234-1234 ";
            Match resultadoTeste1 = Regex.Match(testeDoTeste1, padraoTeste1);
            Console.WriteLine(resultadoTeste1.Value);
            Console.ReadLine();

            // teste com numero.1 
            string padraoTeste = " [0-9]{4}[-][0-9]{4} ";
            string testeDoTeste = " Meu numero é 1234-1234 ";
            Match resultadoTeste = Regex.Match(testeDoTeste, padraoTeste);
            Console.WriteLine(resultadoTeste.Value);
            Console.ReadLine();

            // teste com numero 
            string padrao = " [0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789] ";
            string testePadrao =" Meu numero é 1234-4567 ";
            Match resultado = Regex.Match(testePadrao, padrao);
            Console.WriteLine(resultado.Value);
            Console.ReadLine();



            string urlTeste = "http://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("http://www.bytebank.com");

            
            Console.WriteLine(urlTeste.StartsWith("http://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));
            Console.ReadLine();

            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());

            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();


            string urlParamentros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar"; 
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParamentros);
            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.Write("Valor de moedaDestino: " + valor + "\n" );

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.Write("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.ReadLine();

            //testando o metodo remove
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEcomercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEcomercial));
            Console.ReadLine();


            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();





            // Testando o IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "kjhfsdjhgsdfjksdf";
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();






            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);


            Console.ReadLine();
        }
    }


}
