# Boas-vindas ao repositório do projeto Servidor de Delivery

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project-delivery-server.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-project-delivery-server`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique se você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-csharp-0x-project-delivery-server`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa: _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-csharp-0x-project-delivery-server`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-project-delivery-server/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-project-delivery-server/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente.

  - Lembre-se sempre, após um (ou alguns) `commits`, de atualizar o repositório remoto.

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-0x`.

  Caso tenha alguma dúvida, [aqui tem um video explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibem a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/PsefzL2e)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

Boas-vindas ao Servidor de Delivery, uma projeto para implementar esse serviço essencial para sua empresa.

Você recebeu a demanda para iniciar o desenvolvimento de um servidor de delivery de comidas assincrono.

Nesse projeto, você vai treinar como implementar tarefas que deverão executar em segundo plano para não travar o fluxo principal.

## 1 - Implementar o Item do pedido e seus testes
`Crie sua lógica em src/delivery-server/Item.cs`

<details>
  <summary>Criar a classe Item</summary><br />

Cada item deve ter:
- Uma variável **Name**, do tipo `string`
- Uma variável **Price**, do tipo `double`
- Uma variável **TimeToPrepare**, do tipo `int`
  
</details>

<details>
  <summary>Criar o construtor da classe Item</summary><br />

A classe Item deve receber os parâmetros Nome, Preço e Tempo de preparo por construtor e atribuir as variáveis da classe.
  
</details>

<details>
  <summary>Criar o teste para a classe Item</summary><br />

`Crie sua lógica em src/delivery-server.Test/TestReq1.cs`

Crie a verificação se a classe Item é criada corretamente.
  
</details>

## 2 - Implementar a classe Order e seus testes
`Crie sua lógica em src/delivery-server/Order.cs`

<details>
  <summary>Criar a classe Order</summary><br />

Cada Order deve ter:
- Uma variável **OrderItem**, do tipo `Item`
- Uma variável **Quantity**, do tipo `int`
- Uma variável **OrderPrice**, do tipo `double`
- Uma variável **IsReady**, do tipo `bool`
- Uma variável **IsSend**, do tipo `bool`
  
</details>

<details>
  <summary>Criar o construtor da classe Order</summary><br />

A classe Item deve receber os parâmetros orderItem, quantidade por construtor e atribuir as variáveis da classe.

O construtor deve calcular o preço do pedido, multiplicando o preço do item por sua quantidade.

O construtor deve definir as variáveis `IsReady` e IsSend como **falso**.

</details>

<details>
  <summary>Criar uma tarefa para preparar o item</summary><br />

Implemente a função `Process()`, que deverá esperar o **tempo de preparo do item * a quantidade**.
E só então alterar a variável `IsReady` para **verdadeiro**.

Essa tarefa é chamada no construtor da classe Order.

</details>

<details>
  <summary>Criar o teste para a classe Order</summary><br />

`Crie sua lógica em src/delivery-server.Test/TestReq2.cs`

Crie a verificação se a classe Item é criada corretamente.
  
</details>

## 3 - Implementar o processamento dos pedidos e seus testes
`Crie sua lógica em src/delivery-server/ProcessOrder.cs`

De olho na dica: Você pode usar o projeto em `src/delivery-server.Use` para testar o delivery server.

<details>
  <summary>Criar a classe ProcessOrder</summary><br />

Cada item deve ter:
- Uma variável **OrdersList**, do tipo `ArrayList`
- Uma variável **TimeToCheck**, do tipo `int`
  
</details>

<details>
  <summary>Criar o construtor da classe ProcessOrder</summary><br />

O construtor deve alterar a variável TimeToCheck para `1`.
  > Esse será o valor de espera para cada checagem
  
O construtor deve iniciar um novo ArrayList().

O construtor deve imprimir a string `"SERVER:> Controlador de delivery iniciado!"`.

Usaremos a biblioteca [`TimeSpan`](https://docs.microsoft.com/pt-br/dotnet/api/system.timespan?view=net-6.0) para executar uma tarefa a cada espaço de tempo.
</details>

<details>
  <summary>Criar a função para adicionar pedidos</summary><br />

Implemente a função `AddOrder()`

A função deve receber um Item e uma quantidade, então deve criar um objeto do tipo `Order` e adicionar ao array list.

Por fim, a função deve imprimir a string `$"SERVER:> 3 * arroz adicionados"`
  > para uma entrada: AddOrder(new Item("arroz", 1.0, 1000), 3);

</details>

<details>
  <summary>Completar a implementação da função DeliveryReadyOrders</summary><br />

A função deve ser executada a cada TimeToCheck segundos.
  > Já está implementado!

A cada tick de tempo, a função deve percorrer a lista de pedidos, e para cada pedido em que a variável **IsReady está verdadeira e ao mesmo tempo IsSend está falsa**
 > Deve imprimir a string `$"SERVER:> O pedido de {order.Quantity} {order.OrderItem.Name} no valor de {order.OrderPrice} Reais foi enviado!"`
 > e então alterar a variavel IsSend para verdadeira.

Se nenhum pedido for enviado naquele tick de tempo, a função deve imprimir a string `"SERVER:> Nenhum pedido está pronto para enviar!"`
  
</details>

<details>
  <summary>Criar o teste para a classe ProcessOrder</summary><br />

`Crie sua lógica em src/delivery-server.Test/TestReq3.cs`

Crie a verificação se a classe ProcessOrder é criada corretamente.

Crie a verificação se a função AddOrder adiciona um pedido corretamente.
  
</details>
