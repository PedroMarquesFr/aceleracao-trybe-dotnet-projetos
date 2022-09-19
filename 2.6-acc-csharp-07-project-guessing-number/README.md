# Boas-vindas ao repositório do Adivinhe o Número.

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project-guessing-number<ATUALIZAR>.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-project-guessing-number<ATUALIZAR>`

  2. Instale as dependências

  - `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique que você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora, crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-0x-project/exercise-<ATUALIZAR>`

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
      - `git status` (deve aparecer uma mensagem como esta: _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-0x-project/exercise-<ATUALIZAR>`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-project-guessing-number<ATUALIZAR>/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-project-guessing-number<ATUALIZAR>/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre, após um (ou alguns) `commits`, de atualizar o repositório remoto

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

Uma empresa que desenvolve aplicações de console contatou você com uma problemática: `Todos os sistemas desta empresa têm filas longas e as pessoas clientes ficam entediadas enquanto esperam`.
  
  - Você, então, proativamente, propõe a solução de implementar um jogo para os clientes se divertirem enquanto esperam sua vez na fila.
  - A empresa gostou e aceitou, o jogo escolhido então foi o `Adivinhe o Número!`

Então você recebeu a tarefa de implementar esse jogo clássico!

As regras do jogo são bem simples:
- O jogador 1 escolhe um número aleatório;
- O jogador 2 tenta adivinhar esse número;
- O jogador 1 responde se a tentativa do jogador 2 foi correta, abaixo ou acima do número escolhido.
-Essa sequência se repete até que o jogador 2 acerte o número.

>> **⚠️Importante⚠️:** Para cada requisito do README, você verá dois requisitos associados no avaliador. Isso acontece porque para avaliar os testes deste projeto, o avaliador irá realizar dois testes: um de sucesso e um de falha. Você deve desenvolver o requisito e o seu teste para ter a aprovação em ambos.

Seguindo os requisitos desse projeto, vamos construir nosso adversário, o jogador 1:
 
## 1 - Imprima uma mensagem e receba a resposta da pessoa usuária.
_Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

<details>
  <summary>Ao ser executado, a primeira ação do programa deverá ser imprimir uma mensagem de boas-vindas!</summary><br/>

 A mensagem deverá ser exatamente:
 ```
 "---Bem-vindo ao Guessing Game---"
 "Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!"
 ```
  
 > Crie essa lógica na função `Greet()`

</details>

<details>
  <summary>Em seguida, o programa deve esperar a entrada da pessoa usuária e armazená-la na variável `response`.</summary><br />

> Se a pessoa usuária não inserir um número **inteiro**, ou se ele inserir um número **fora do range** (-100, 100), o programa deve imprimir a mensagem: `"Por favor, digite um número inteiro:"`
> 
    > E esperar uma nova entrada da pessoa usuária **até** a pessoa usuária inserir um número válido.
  
</details>

<details>
  <summary>O programa deve, então, converter a entrada da pessoa usuária em um tipo `int` e armazenar na variável `userValue`.</summary><br />

> Crie essa lógica na função `ChooseNumber()`
  
</details>

Você sempre pode executar o programa usando
`dotnet run` na pasta `scr/guessing-number`.

<details>
  <summary> Criar os testes do <strong> primeiro</strong> requisito</summary><br/>

> Deve ser feito em `src/guessing-number.Test/TestFirstReq.cs`
- Se o programa **imprime a mensagem correta**
  > Crie essa lógica na função `TestPrintInitialMessage()`
- Se o programa **recebe a entrada da pessoa usuária**
  > Crie essa lógica na função `TestReceiveUserInputAndConvert()`
- Se o programa **faz a validação do tipo `int`**
  > Crie essa lógica na função `TestReceiveUserInputAndVerifyType()`
- Se o programa **faz a validação do range `-100 e 100`**
  > Crie essa lógica na função `TestReceiveUserInputAndVerifyRange()`

</details>

## 2 - O programa deve escolher um número aleatório.
_Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

<details>
  <summary>O programa agora deve escolher um número aleatório `entre -100 e 100` e armazenar na variável `randomValue`.</summary><br/>

> Dica: use a função `random.GetInt(x, y)` para escolher números aleatórios.
> Crie essa lógica na função `RandomNumber()`

</details>

<details>
  <summary>Agora, o programa deverá comparar a entrada da pessoa usuária com o número aleatório e analisá-lo</summary><br />

- **Se** a entrada for **maior** que o número aleatório, o programa deverá imprimir a mensagem: `Tente um número MENOR`
- **Se** a entrada for **menor** que o número aleatório, o programa deverá imprimir a mensagem: `Tente um número MAIOR`
- **Se** a entrada for **igual** ao número aleatório, o programa deverá imprimir a mensagem: `ACERTOU!`
> Crie essa lógica na função `AnalyzePlay()`
 
</details>

<details>
  <summary> Criar os testes do <strong>segundo</strong> requisito</summary><br/>

> Deve ser feito em `src/guessing-number.Test/TestSecondReq.cs`
  - Se o programa **escolhe um número aleatório entre -100 e 100**
    > Crie essa lógica na função `TestRandomlyChooseANumber()`
  - Se o programa **compara corretamente a entrada e o número escolhido**
    - para quando o número da pessoa usuária é **menor**
      > Crie essa lógica nas funções `TestProgramComparisonValuesLess()`
    - para quando o número da pessoa usuária é **maior**
      > Crie essa lógica nas funções `TestProgramComparisonValuesBigger()`
    - para quando a pessoa usuária **acertar**
      > Crie essa lógica nas funções `TestProgramComparisonValuesEqual()`

</details>

## 3 - O programa deverá repetir a operação de escolha da pessoa usuária
_Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

<details>
  <summary>Se a pessoa usuária errar o número aleatório, seja para `MAIOR`, seja para `MENOR`, o programa deve receber uma nova tentativa.</summary><br/>

> Lembre-se das validações do número de entrada.

</details>

<details>
  <summary>O programa deve repetir esse procedimento **até** a pessoa usuária acertar o número escolhido aleatoriamente.</summary><br />

> Se você implementou corretamente as funções `ChooseNumber()` e `AnalyzePlay()`, esse requisito irá funcionar; caso contrário, é legal rever essas funções.
 
</details>

<details>
  <summary> Criar os testes do <strong>terceiro</strong> requisito</summary><br/>

> Deve ser feito em `src/guessing-number.Test/TestThirdReq.cs`
  - Se o programa **repete o comportamento até a pessoa usuária acertar.**
    > Crie essa lógica na função `TestFullFlow()`

</details>

# Exemplo

Um exemplo da execução do programa é:
Para um fluxo correto! 
```
---Bem-vindo ao Guessing Game---
Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!
"10"
Tente um número MENOR
"0"
Tente um número MENOR
"-50"
Tente um número MAIOR
"-30"
Tente um número MAIOR
"-21"
ACERTOU!
```

Para um fluxo com verificações de tipo e range!
```
---Bem-vindo ao Guessing Game---
Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!
"teste"
Por favor, digite um número inteiro:
"nao"
Por favor, digite um número inteiro:
"10"
Tente um número MAIOR
"1000"
Por favor, digite um número inteiro:
"50"
Tente um número MAIOR
"77"
ACERTOU!
```


 A partir deste projeto, você poderá se aprofundar nos contextos básicos de C#. Além disso, vai aprender, por meio da prática, sobre o  fluxo de controle de uma aplicação.  

Vamos lá!? Nos vemos quando você acertar o número!✅

⚠️ Aviso: Ao finalizar e submeter o desafio, não se esqueça de avaliar sua experiência preenchendo o formulário. Leva menos de 3 minutos!

---
