# Boas-vindas ao repositório do Devices Factory

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:betrybe/acc-csharp-40-exercises-device-factory.git`.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-40-exercises-device-injection`

  2. Instale as dependências

  - `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique que você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-csharp-40-exercises-device-factory`

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
      - `git status` (deve aparecer uma mensagem tipo essa:  _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-csharp-40-exercises-device-factory`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/betrybe/acc-csharp-40-exercises-device-factory/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/betrybe/acc-csharp-40-exercises-device-factory/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre, após um (ou alguns) `commits` de atualizar o repositório remoto

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

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `main.yml`.

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

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/ZTeR4IbH)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

Você acabou de se tornar o gerente de uma fábrica de dispositivos! Nesta fábrica são produzidos botões que ligam lâmpadas.

Porém, você vê uma oportunidade de ampliar os negócios, e quer adicionar mais produtos à sua fábrica de dispositivos. Então você adiciona um interruptor e uma campainha para o seu portfolio de produtos e quer que os interruptores e botões possam acionar tanto lâmpadas quanto campainhas.

## Criar as classes `Lamp` e `Bell` e a interface `IDevice`

<details>
  <summary> A interface <code>IDevice</code> deve ter os métodos <code>TurnOn()</code> e <code>TurnOff()</code>, ambos retornando <code>void</code> e a propriedade <code>IsOn</code></summary><br />

Crie a interface `IDevice`, na pasta `Tools`, com os métodos `TurnOn()` e `TurnOff()`, ambos sem retorno e a propriedade `IsOn`.
</details>

<details>
  <summary> As classes <code>Lamp</code> e <code>Bell</code> devem receber as suas abstrações via interface <code>IDevice</code></summary><br />

Crie as classes `Lamp` e `Bell` na pasta `Tools` e faça-as receber suas abstrações por interface.
</details>

<details>
  <summary> Os métodos <code>TurnOn()</code> e <code>TurnOff()</code> devem ligar e desligar o dispositivo, respectivamente, alternando o valor da propriedade <code>IsOn</code></summary><br />

As classes `Lamp` e `Bell` devem, inicialmente, estar desligadas e então deve ser possível ligar e desligar conforme seus métodos forem chamados.
</details>

<details>
  <summary> Os métodos <code>TurnOn()</code> e <code>TurnOff()</code> devem disparar uma exceção caso os dispositivos estejam ligados e desligados, respectivamente</summary><br />

A exceção deve ser disparada com a mensagem `<Dispositivo> is already on` caso o dispositivo já esteja ligado ou com a mensagem `<Dispositivo> is already off` caso o dispositivo já esteja desligado.
Exemplo: Caso a classe `Lamp` esteja ligada e o método `TurnOn()` seja invocado, deve ser disparado uma exceção com a mensagem `Lamp is already on`.
</details>

<details>
  <summary> Req 1, 2, 3 e 4 - Testes da classe <code>Lamp</code></summary><br />

Desenvolva os testes que estão vazios nos arquivo `LampTest.cs`. As instruções do que o teste deve avaliar estarão comentadas em cada teste.
</details>

<details>
  <summary> Req 5, 6, 7 e 8 - Testes da classe <code>Bell</code></summary><br />

Desenvolva os testes que estão vazios no arquivo `BellTest.cs`. As instruções do que o teste deve avaliar estarão comentadas em cada teste.
</details>

## Criar a classe `Button`

<details>
  <summary> Crie a classe <code>Button</code></summary><br />

Crie a classe `Button` na pasta Trigger.
</details>

<details>
  <summary> A classe <code>Button</code> deve receber as suas dependências por construtor</summary><br />

A classe `Button` deve receber as suas dependências, um dispositivo, por construtor na propriedade pública de somente leitura `_device`.
</details>

<details>
  <summary> O método <code>Trigger()</code> deve ligar e deligar o dispositivo</summary><br />

O método `Trigger()` deve, alternadamente, ligar e desligar o dispositivo, dependendo do estado do dispositivo.
</details>

<details>
  <summary> Req 8 e 9 - Testes das classes <code>Button</code></summary><br />

Desenvolva um teste no arquivos `ButtonTest.cs` que teste a injeção de dependências, passando diferentes dispositivos para a classe `Button` e acionando o método `Trigger()`.
> Atenção! Este teste deve verificar vários cenários de quantidade de chamadas do método `Trigger()`.
</details>

## Criar a classe `Switcher`

<details>
  <summary> Crie a classe <code>Switcher</code></summary><br />

Crie a classe `Switcher` na pasta Trigger.
</details>

<details>
  <summary> A classe <code>Switcher</code> deve receber as suas dependências por propriedade</summary><br />

A classe `Switcher` deve receber as suas dependências, um dispositivo, por proriedade, sendo armazenada na propriedade privada `_device`.
</details>

<details>
  <summary> O método <code>Trigger()</code> deve ligar e deligar o dispositivo</summary><br />

O método `Trigger()` deve, alternadamente, ligar e desligar o dispositivo, dependendo do estado do dispositivo.
</details>

<details>
  <summary> Req 10 - Testes das classes <code>Switcher</code></summary><br />

Desenvolva um teste no arquivos `SwitcherTest.cs` que teste a injeção de dependências, passando diferentes dispositivos para a classe `Switcher` e acionando o método `Trigger()` para cada dispositivo recebido.
> Atenção! Este teste deve verificar vários cenários de quantidade de chamadas do método `Trigger()`.
</details>


Boa! Agora sua fábrica está pronta para utilizar botões e interruptores iguais em diferentes dispositivos. Sua fábrica poderá expandir os negócios para outros dispositivos facilmente com a reutilização dos botões e interruptores.
