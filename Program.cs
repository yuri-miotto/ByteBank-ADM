using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Parceria;
using Bytebank_ADM.SistemaInterno;
using Bytebank_ADM.Utilitario;
using System.Runtime.CompilerServices;

Auxiliar pedro = new Auxiliar("123456789");
pedro.Nome = "Pedro Malazartes";

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor("987654321");
roberta.Nome = "Roberta Silva";

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações = " + gerenciador.TotalDeBonificacoes);
Console.WriteLine("Total de funcionários = " + Funcionario.TotalDeFuncionarios);

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();
    roberta.Senha = "123";

    ParceiroComercial joao = new ParceiroComercial();
    joao.Senha = "999";

    sistema.Logar(roberta, "123");
    sistema.Logar(roberta, "111");
    sistema.Logar(joao, "999");
}

UsarSistema();



