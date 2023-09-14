using Newtonsoft.Json;
using Serializacao.Models;

DateTime dataAtual = DateTime.Now;
List<Produto> produtos = new List<Produto>();

Produto produtoSistemaERP = new Produto(1, "Sistema ERP", 2000.50m, dataAtual);
Produto produtoLicencaVS = new Produto(2, "Licença Visual Studio", 150.50m, dataAtual);

produtos.Add(produtoSistemaERP);
produtos.Add(produtoLicencaVS);

string serializado = JsonConvert.SerializeObject(produtos, Formatting.Indented);

File.WriteAllText("Arquivos/produtos.json", serializado);

