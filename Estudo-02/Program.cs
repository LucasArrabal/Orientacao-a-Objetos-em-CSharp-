using Estudo_02.Models;

Pessoa p1 = new Pessoa("Lucas","Arrabal", 19);
Pessoa p2 = new Pessoa("Jopa","Arrabal", 19);
Pessoa p3 = new Pessoa("Lucio","Arrabal", 19);
Pessoa p4 = new Pessoa("Cesar","Arrabal", 19);
p1.Apresentar();

Curso ADS = new Curso();
ADS.Nome = "ADS";

ADS.Alunos = new List<Pessoa>();

ADS.AdicionarAluno(p1);
ADS.AdicionarAluno(p2);
ADS.AdicionarAluno(p3);
ADS.AdicionarAluno(p4);

ADS.ListarAlunos();
ADS.ObterNumAlunos();
