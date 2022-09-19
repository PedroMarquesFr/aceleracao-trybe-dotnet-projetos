# Boas-vindas ao repositório do exercício Dia de Eleição.

Para realizar o projeto, atente-se a cada passo descrito a seguir, e se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-exercises-election-day.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-exercises-election-day`

  2. Instale as dependências

  - `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique que você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora, crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-0x-exercises-election-day`

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
      - `git status` (deve aparecer uma mensagem tipo _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-0x-exercises-election-day`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/betrybe/acc-csharp-0x-exercises-election-day/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/betrybe/acc-csharp-0x-exercises-election-day/pulls) e confira que o seu _Pull Request_ está criado

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

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/ZTeR4IbH)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional, e que compartilhar o seu aprendizado lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

Você, pessoa programadora, foi contratada para trabalhar no time de tecnologia do Tribunal Superior Eleitoral (TSE) e recebeu como demanda a implementação de uma urna eletrônica.

As regras do sistema são as seguintes:
- A pessoa usuária informa o número de eleitores;
- O sistema solicita o número do candidato de 1 a 3;
- O eleitor informa o número do candidato e o sistema armazena em memória a contagem dos votos válidos (de 1 a 3) e nulos (diferente de 1, 2 e 3). Essa sequência se repete até que o programa tenha lido os votos de todos os eleitores;
- O sistema imprime o resultado da votação.

>> **⚠️Importante⚠️:** Para cada requisito do README, você verá dois requisitos associados no avaliador. Isso acontece porque para avaliar os testes deste projeto, o avaliador irá realizar dois testes: um de sucesso e um de falha. Você deve desenvolver o requisito e o seu teste para ter a aprovação em ambos.

Você vai construir essa urna eletrônica, seguindo os seguintes requisitos:
 
## 1 - Faça a leitura do número de eleitores
_Crie a lógica do seu requisito no arquivo src/`election-day/BallotBox.cs`._

<details>
  <summary>Ao ser executado, a primeira tarefa do programa é solicitar o número de eleitores, esperar a entrada da pessoa usuária e retorná-la pela função</summary><br/>

 > Crie essa lógica na função `GetCountVoters()`, que retorna o número lido;
 > ⚠️ Aviso: Se a pessoa usuária não inserir um número **inteiro**, o programa deve aguardar uma nova entrada da pessoa usuária **até** a pessoa usuária inserir um número.

</details>

## 2 - Faça a leitura dos votos
_Crie a lógica do seu requisito no arquivo src/`election-day/BallotBox.cs`._

<details>
  <summary>O próximo passo é fazer a leitura dos votos e armazenar nas variáveis correspondentes.</summary><br/>

 > Crie essa lógica do procedimento `Start(int countVoters)` que recebe o número de votos total (eleitores) por parâmetro;
 > O programa dele solicitar o voto da pessoa usuária e armazenar nas variáveis correspondentes:
 
 > Para o voto no número 1, armazenar na variável receivedOption1;
 > Para o voto no número 2, armazenar na variável receivedOption2;
 > Para o voto no número 3, armazenar na variável receivedOption3;
 > Para o voto nulo (diferente de 1, 2 e 3), armazenar na variável optionNull;
 > O procedimento repetirá a leitura dos votos correspondente ao número de eleitores (countVoters);

</details>

## 3 - Faça a impressão da votação
_Crie a lógica do seu requisito no arquivo src/`election-day/BallotBox.cs`._

<details>
  <summary>Para finalizar, o sistema deve printar o resultado da votação</summary><br/>

 > Crie essa lógica do procedimento `PrintResult()`;
 
 > Para os votos válidos, o programa deve fazer a impressão da seguinte frase:
 > "A opção X recebeu: N voto(s)"
 > Onde X corresponde o número do candidato e N ao total de votos recebido;

 > Para o voto nulo (diferente de 1, 2 e 3), deve fazer a impressão da seguinte frase: 
 > "Total de votos anulados: N voto(s)"
 > Onde N corresponde ao total de votos nulos;

</details>

De olho na dica👀: Você sempre pode executar o programa usando `dotnet run` na pasta `scr/election-day`.

# Exemplo

Observe um exemplo da execução do programa a seguir: 

```
O número de eleitores deve ser um número inteiro maior que zero.
Informe o número de eleitores: 4
Número de eleitores informado 4        
Digite o número do candidato de 1 a 3: 1
Voto registrado.
Digite o número do candidato de 1 a 3: 2
Voto registrado.
Digite o número do candidato de 1 a 3: 1
Voto registrado.
Digite o número do candidato de 1 a 3: 4
Voto registrado.
Votação finalizada!!!!
A opção 1 recebeu: 2 voto(s)
A opção 2 recebeu: 1 voto(s)
A opção 3 recebeu: 0 voto(s)
Total de votos anulados: 1 voto(s)
```

Vamos lá? A partir desse exercício, você certamente será uma pessoa mais bem preparada para usar as estruturas de repetição no mercado de trabalho ! #VQV🚀

Aviso ⚠️: Ao finalizar e submeter o desafio, não se esqueça de avaliar sua experiência preenchendo o formulário. Leva menos de 3 minutos!

---
