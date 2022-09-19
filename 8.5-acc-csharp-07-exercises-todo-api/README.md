# Boas-vindas ao repositório do exercício Lista de Tarefas

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-exercises-todo-api.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-exercises-todo-api`

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
    - Exemplo: `git checkout -b joaozinho-acc-0x-exercises-todo-api`

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

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-0x-exercises-todo-api`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-exercises-todo-api/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-exercises-todo-api/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre de, após um (ou alguns) `commits`, atualizar o repositório remoto

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

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/TodoApi` ou de seus testes `src/TodoApi.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste específico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibe a descrição completa de como utilizar o comando.
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

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/ZTeR4IbH)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

Depois de aprender sobre a arquitetura REST, agora é hora de colocar esse conhecimento em prática. Para isso, temos aqui uma API de coisas a fazer, porém essa API não está seguindo as práticas do padrão REST, e o seu trabalho será modificar essa API para deixá-la em acordo com a arquitetura REST.

> De olho na dica👀: Os testes deste projeto foram projetados para utilizar **Testes de integração**. Você irá encontrar a configuração de um teste de integração já implementada no construtor da classe `TestTodoItemsController` em `src/TodoApi.Test/TodoItemsControllerTest.cs`. 
> Utilize o atributo `_client` da classe `TestTodoItemsController` para fazer requisições aos endpoints da sua aplicação e, assim, conseguir testá-los. É muito importante que você utilize os dados recebidos por parâmetros em seus testes, pois eles serão usados para validar a funcionalidade dos testes.
> O banco de dados inicial usado nos testes será o retorno do método `GetTodoTestList`. Modifique os dados de entrada conforme achar necessidade, alterando o retorno desse método.


## 1 - Corrigir as rotas de buscar Tarefas

<details>
  <summary>A rota GET <code>/api/todoItems</code> deve retornar uma lista de tarefas</summary><br />

  Essa rota deve retornar um `JSON` contendo a lista de tarefas e um status code de sucesso `Ok`.
</details>

<details>
  <summary>A rota GET <code>/api/todoItems/{id}</code> deve retornar a tarefa adequada</summary>
  <br />

  Essa rota deve retornar um `JSON` com os dados da tarefa associada ao `id` informado como parâmetro e um status code de sucesso `Ok`. Ou um status code not found caso o `id` informado não exista no banco de dados.
</details>

<details>
  <summary>Implemente os testes de status code</summary>
  <br />

  Implemente os testes de integração em `src/TodoApi.Test/TestTodoItemsController.cs` no método `TestGetRoutesStatusCode`.

  Este teste recebe uma rota e um status code como parâmetro e deve fazer uma request do tipo `GET` para o endpoint recebido e verificar se o retorno contém o `StatusCode` adequado recebido como parâmetro.
</details>

## 2 - Corrigir a rota de deletar tarefas

<details>
  <summary>A rota DELETE <code>/api/todoItems/{id}</code> deve deletar a tarefa adequada</summary><br />

  Essa rota deve retornar um status code de sucesso `NoContent 204` caso o {id} seja encontrado e deletado com sucesso. Ou um status code not found, caso o `id` informado não exista no banco de dados.
</details>

<details>
  <summary>Implemente os testes de status code</summary>
  <br />

  Implemente os testes de integração em `src/TodoApi.Test/TestTodoItemsController.cs` no método `TestDeleteRouteStatusCode`.

  Este teste recebe uma rota com id e um status code como parâmetro e deve fazer uma request do tipo `DELETE` para o endpoint recebido e verificar se o retorno contém o `StatusCode` adequado recebido como parâmetro.

  O teste também deve verificar se a tarefa com o ID passado por parâmetro foi deletada adequadamente.
</details>

## 3 - Corrigir a rota de adicionar tarefas

<details>
  <summary>A rota POST <code>/api/todoItems</code> deve inserir uma tarefa</summary><br />

  Essa rota deve retornar um status code de sucesso `Created` `201`, caso o `JSON` de entrada seja inserido corretamente no banco de dados.

  Essa rota deve retornar um status code `BadRequest` `400`, caso os dados de entrada não sejam válidos.
</details>

<details>
  <summary>Implemente os testes de status code</summary>
  <br />

  Implemente os testes de integração em `src/TodoApi.Test/TestTodoItemsController.cs` no método `TestPostRouteStatusCode`.

  Este teste recebe uma rota, uma tarefa e um status code como parâmetro e deve fazer uma request do tipo `POST` para o endpoint recebido e verificar se o retorno contém o `StatusCode` adequado recebido como parâmetro.

  O teste também deve verificar se a tarefa passada como parâmetro foi adicionada com sucesso.
</details>

## 4 - Corrija a rota de modificar tarefas

<details>
  <summary>A rota PUT <code>/api/todoItems/{id}</code> deve modificar uma tarefa</summary><br />

  Essa rota deve retornar o status code `NotFound` `404`, caso o Id passado como parâmetro não exista no banco de dados.

  Essa rota deve retornar `Ok` `200`, caso exista o Id passado como parâmetro e o `JSON` seja válido para modificar o atributo.

  Essa rota deve retornar um status code `BadRequest` `400`, caso o Id passado como parâmetro seja válido e os dados de entrada não sejam válidos.
</details>

<details>
  <summary>Implemente os testes de status code dessa rota</summary>
  <br />

  Implemente os testes de integração em `src/TodoApi.Test/TestTodoItemsController.cs` no método `TestPutRouteStatusCode`.

  Este teste recebe uma rota, uma tarefa e um status code como parâmetro e deve fazer uma request do tipo `PUT` para o endpoint recebido e verificar se o retorno contém o `StatusCode` adequado recebido como parâmetro.

  O teste também deve verificar se a tarefa passada como parâmetro foi modificada com sucesso.
</details>

## Extra - Não Avaliativo (Deploy usando o Heroku)
<details>
  <summary>Faça o Deploy de sua API no Heroku utilizando Docker e Heroku App</summary><br />
</details>
