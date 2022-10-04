using NugetSerializarAtribudos.Models;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVenda = new List<Venda>();
Venda v1 = new Venda(1,"Blusa",20.00M, dataAtual);
Venda v2 = new Venda(2,"Calça", 25.00M, dataAtual);

listaVenda.Add(v1);
listaVenda.Add(v2);


string teste = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);


File.WriteAllText("Arquivos/vendas.json", teste);
Console.WriteLine(teste);
Console.ReadLine();


