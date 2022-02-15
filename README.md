# Bem vindo ao Dojo React IEBT


Nosso desafio hoje é criar um chat com nossos contatos.
Teremos dois dominios nessa aplicação:
* Os contatos
* As salas de mensagem

Os contatos são entidade compostas por id e nome(brigatóriamente) e podem pertencer a grupos de contatos, ter muitos telefones e emails;
Já salas de mensagem são compostas por id, nome e 1 contato que receberá as mensagens. Para cada mensagem preciso saber seu conteúdo e a data/hora do envio.


Lembre-se dos **principios SOLID** e que tudo deve ser **testável** e **indepentedente**
          
Para hoje vamos precisar de:

  * Criar a estrutura da entidade contato
  * Criar a estrutura da entidade de salas de mensagem
  * Manter o isolamento entre os dominios
  * Criar testes para todas as classes
  * Criar serviço de leitura de contatos
  * Criar serviço de leitura de salas de mensagens
  * Uma surpresa...

Vamos utilizar nesse projeto
  * C#
  * Arquivos de texto para salvar os dados
  * Injeção de dependencias (https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/6.0.2-mauipre.1.22054.8)
  * Testes de unidade (https://docs.microsoft.com/pt-br/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022)

Não se esqueça
  * Não criar dependencias desnecessárias
  * O Contato das salas e o Dominio de Contatos vem do mesmo lugar mas não são a mesma coisa
  * Utilize um pacote de Injeções de dependencias a parte
