# Boas-vindas ao repositório do exercício Farm Classes!

Para realizar o projeto, atente-se a cada passo descrito a seguir, e se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:betrybe/acc-csharp-0x-exercise-farm-classes.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-exercise-farm-classes`

  2. Instale as dependências

  - `dotnet restore`.
  
  1. Crie uma branch a partir da branch `master`

  - Verifique que você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-csharp-0x-exercise-farm-classes`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto farm classes'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-csharp-0x-exercise-farm-classes`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/betrybe/acc-csharp-0x-exercise-farm-classes/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/betrybe/acc-csharp-0x-exercise-farm-classes/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se de sempre após um (ou alguns) `commits` atualizar o repositório remoto

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

  Use o conteúdo sobre [Code Review](https://course.betrybe.com/real-life-engineer/code-review/) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `main.yml`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências

  ### Executando todos os testes

  Para executar os testes com o .NET execute o comando dentro do diretório do seu projeto `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibem a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes ao invés de executá-los.
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

  Você sabia que o LinkedIn é a principal rede social profissional e compartilhar o seu aprendizado lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe esse projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

Parabéns, você recebeu de herança uma fazenda! 🚜🐄🐖

Entretanto, você não tem controle sobre os animais da fazenda, e depois de um mês tentando administrar tudo, percebe que está uma absoluta desordem!

Com isso, você decide usar seus conhecimentos em C# para organizar os diferentes tipos de animal em classes, para que assim consiga se organizar melhor.  
  
> ⚠️ Aviso: Antes de começar, certifique-se de que todas as classes serão criadas nos respectivos arquivos, já criados para esse fim. Também se certifique de que todas as classes, propriedades e construtores são **públicos** (ou seja, possuem o modificador `public` antes da declaração), caso contrário os testes automatizados irão falhar.
 
## 1 - Crie uma classe `Cow`

Primeiramente, vamos ao gado!

<details>
  <summary>A classe <code>Cow</code> deve possuir uma propriedade pública <code>Id</code> do tipo <code>Guid</code> com o valor padrão de <code>Guid.NewGuid();</code></summary><br />

Todos os animais da propriedade deverão possuir identificadores únicos. Por esse motivo vamos usar o tipo <code>Guid</code> para declarar a propriedade que conterá esses Ids.

> Se quiser saber mais sobre a estrutura <code>Guid</code>, nativa do C#, consulte a <a href="https://docs.microsoft.com/pt-br/dotnet/api/system.guid?view=net-6.0" target="_blank">documentação</a>.
  
</details>

<details>
  <summary>A classe <code>Cow</code> deve possuir uma propriedade pública <code>Weight</code> do tipo <code>int</code></summary><br />

Você também precisa saber o peso de cada uma das vacas, então atribua um peso com `int`.
  
</details>

<details>
  <summary>A classe <code>Cow</code> deve possuir uma propriedade pública <code>Breed</code> do tipo <code>string</code></summary><br />

Você também precisa saber qual a raça de cada uma das vacas para depois poder organizar o pasto. Atribua o nome da raça em uma `string`.
  
</details>

<details>
  <summary>A classe <code>Cow</code> deve possuir um construtor público que receba todos os valores das propriedades como parâmetros, exceto o <code>Id</code></summary><br />

Os valores dos parâmetros devem ter a mesma ordem das propriedades elencadas nesse requisito.
  
</details>

<details>
  <summary>O construtor da classe <code>Cow</code> deve <strong>validar</strong> e <strong>atribuir</strong> os valores das propriedades</summary><br />

A atribuição deve ocorrer no corpo do construtor para que ocorra no momento da inicialização dos objetos.

Caso seja passado um `Weight` _menor ou igual a zero_ ou uma `Breed` que seja uma _`string` nula ou vazia_, o construtor deve lançar uma `ArgumentException`.
</details>

<br />

Pronto, os bovinos já estão devidamente organizados. 🐮

## 2 - Crie uma classe `Pig`

Agora é a vez dos porcos!

<details>
  <summary>A classe <code>Pig</code> deve possuir uma propriedade pública <code>Id</code> do tipo <code>Guid</code> com o valor padrão de <code>Guid.NewGuid();</code></summary><br />

Assim como com as vacas, deve ser possível atribuir um `Id` único para cada porco.

> Se quiser saber mais sobre a estrutura <code>Guid</code>, nativa do C#, consulte a <a href="https://docs.microsoft.com/pt-br/dotnet/api/system.guid?view=net-6.0" target="_blank">documentação</a>.
  
</details>

<details>
  <summary>A classe <code>Pig</code> deve possuir uma propriedade pública <code>Age</code> do tipo <code>int</code></summary><br />

Temos muitos porcos jovens e idosos na fazenda. Atribuindo uma idade podemos organizá-los melhor.
  
</details>

<details>
  <summary>A classe <code>Pig</code> deve possuir um construtor público que receba a idade do porco como parâmetro</summary><br />  

A idade deve ser atribuída ao parâmetro correto.
</details>

<details>
  <summary>O construtor da classe <code>Pig</code> deve <strong>validar</strong> e <strong>atribuir</strong> os valores das propriedades</summary><br />

A atribuição deve ocorrer no corpo do construtor para que ocorra no momento da inicialização dos objetos.

Caso seja passado um `Age` _menor que zero_, o construtor deve lançar uma `ArgumentException`.
</details>

<br />

Agora já organizamos os bovinos e suínos. 🐮🐷

## 3 - Crie uma classe `Chicken`

Agora é a vez das galinhas!

<details>
  <summary>A classe <code>Chicken</code> deve possuir uma propriedade pública <code>Id</code> do tipo <code>Guid</code> com o valor padrão de <code>Guid.NewGuid();</code></summary><br />

Assim como com as vacas e porcos, deve ser possível atribuir um `Id` único para cada galinha.

> Se quiser saber mais sobre a estrutura <code>Guid</code>, nativa do C#, consulte a <a href="https://docs.microsoft.com/pt-br/dotnet/api/system.guid?view=net-6.0" target="_blank">documentação</a>.
  
</details>

<details>
  <summary>A classe <code>Chicken</code> deve possuir uma propriedade pública <code>EggsPerWeek</code> do tipo <code>int</code></summary><br />

Precisamos saber quais galinhas são mais produtivas e quantas podem estar com algum problema de saúde. Uma boa métrica para isso é a quantidade de ovos por semana.
  
</details>

<details>
  <summary>A classe <code>Chicken</code> deve possuir uma propriedade pública <code>Mother</code> do tipo <code>Chicken?</code></summary><br />

Você achou que seria uma boa ideia traçar a genealogia materna das galinhas. Por isso, cada galinha poderá ter uma mãe atribuída, caso a mãe também seja parte da sua granja.

Caso contrário, o valor da mãe pode permanecer como `null`. Inclusive é por isso que usamos a interrogação após o tipo `Chicken`: ela permite atribuir o valor `null` a tipos de referência que normalmente não poderiam ser nulos.
  
</details>

<details>
  <summary>A classe <code>Chicken</code> deve possuir um construtor público que receba todos os valores das propriedades como parâmetros, exceto o <code>Id</code></summary><br />

Os valores dos parâmetros devem ter a mesma ordem das propriedades elencadas nesse requisito. Além disso, o parâmetro mother não precisa ser anulável, podendo ter o tipo `Chicken` sem a interrogação.
  
</details>

<details>
  <summary>A classe <code>Chicken</code> deve possuir, em paralelo, <strong>outro</strong> construtor público que receba o <code>EggsPerWeek</code> como parâmetro, mas que não receba nem o <code>Mother</code> nem o <code>Id</code></summary><br />

Nesse caso, não será necessário atribuir um valor à propriedade Mother, que deverá permanecer nula.
  
</details>

<details>
  <summary>Ambos os construtores da classe <code>Chicken</code> devem <strong>validar</strong> e <strong>atribuir</strong> os valores da propriedade <code>EggsPerWeek</code></summary><br />

A atribuição deve ocorrer no corpo do construtor para que ocorra no momento da inicialização dos objetos.

Caso seja passado um `EggsPerWeek` _menor que zero_, o construtor deve lançar uma `ArgumentException`.
</details>

<br />

Parabéns, você separou classes para todos os animais da fazenda. 🐮🐷🐔

Mas o trabalho ainda não acabou!

## 4 - Crie testes unitários pra todas as classes de animais
Agora precisamos ter certeza de que tudo ocorreu bem, então vamos aos Testes usando `xUnit` e `FluentAssertions`!

<details>
  <summary>Os testes devem ser criados na pasta <code>farm-classes.Test</code>, nos arquivos já criado para esse fim</summary><br />

Os arquivos dos testes são `ChickenTest.cs`, `CowTest.cs` e `PigTest.cs`.
  
</details>

<details>
  <summary>
  O <code>CowTest</code> deve testar se a classe <code>Cow</code> possui um construtor válido que atribui corretamente as propriedades <code>Weight</code> e <code>Breed</code>
  </summary><br />

O teste deve verificar:
- se o valor das propriedades é igual ao passado no construtor,
- se é lançada uma `ArgumentException` quando a classe recebe um `Weight` menor ou igual a zero
- se é lançada uma `ArgumentException` quando a classe recebe uma `Breed` nula ou vazia
</details>

<details>
  <summary>
  O <code>PigTest</code> deve testar se a classe <code>Pig</code> possui um construtor válido que atribui corretamente a propriedade <code>Age</code>
  </summary><br />

O teste deve verificar:
- se o valor da `Age` é igual ao passado no construtor,
- se é lançada uma `ArgumentException` quando a classe recebe uma `Age` negativa
</details>

<details>
  <summary>
  O <code>ChickenTest</code> deve testar se a classe <code>Chicken</code> possui um construtor válido que atribui corretamente as propriedades <code>EggsPerWeek</code> e, quando for o caso, <code>Mother</code>
  </summary><br />

O teste deve verificar:
- se o valor das propriedades é igual ao passado no construtor,
- se é possível instanciar a classe com e sem uma `Mother` 
- se é lançada uma `ArgumentException` quando a classe recebe um `EggsPerWeek` negativo
</details>

<br />

Agora sim, pode respirar fundo! Sua fazenda está muito mais gerenciável e as coisas estão começando a se encaixar!
