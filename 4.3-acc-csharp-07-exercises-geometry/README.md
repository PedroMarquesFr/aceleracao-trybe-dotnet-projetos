# Boas-vindas ao repositório do exercício Geometry

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-exercise-geometry.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-exercise-geometry`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique que você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-0x-exercise-geometry`

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

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-0x-exercise-geometry`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0xexercise-geometry`/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-exercise-geometry`/pulls) e confira que o seu _Pull Request_ está criado

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

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/Geometry` ou de seus testes `src/Geometry.Test`!

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

Agora, para testar nossos conhecimentos de herança e composição, que tal brincar com algumas formas geométricas? 🟦🟢🔺


 
## 1 - Crie uma classe `Rectangle`

Vamos começar com uma das formas mais simples, que é o retângulo.

<details>
  <summary>A classe <code>Rectangle</code> deve possuir uma propriedade <code>Width</code> e uma propriedade <code>Height</code>, ambas do tipo <code>double</code></summary><br />

Essas propriedades irão representar a largura e a altura do retângulo, respectivamente.
  
</details>

<details>
  <summary>A classe <code>Rectangle</code> deve possuir uma propriedade <code>Area</code> com um getter que utilize a altura e a largura para retornar o valor correto</summary><br />

A área de um retângulo é igual a largura * altura. Essa propriedade não deve ter um setter.
  
</details>

<details>
  <summary>A classe <code>Rectangle</code> deve possuir uma propriedade <code>Perimeter</code> com um getter que utilize a altura e a largura para retornar o valor correto</summary><br />

O perímetro de um retângulo é igual a soma de todos os seus lados. Essa propriedade não deve ter um setter.
  
</details>

<details>
  <summary>A classe <code>Rectangle</code> deve possuir um construtor que receba a altura e a largura como parâmetros, valide se ambas são maiores que zero e atribua os valores de <code>Width</code> e <code>Height</code></summary><br />

Caso algum dos parâmetros seja negativo, deverá ser lançada uma `ArgumentException` com a mensagem `"All sides must be greater than zero"`.
  
</details>

<details>
  <summary>Escreva testes unitários para a classe <code>Rectangle</code></summary><br />

Deve ser testado o seguinte:
- A classe deve designar os valores de `Width` e `Height` corretamente
- A classe deve retornar o valor da `Area` corretamente
- A classe deve lançar uma exceção ao recebe valores menores ou iguais a zero como parâmetros
  
</details>

## 2 - Crie uma classe `Square`

Como você aprendeu nas aulas de matemática, todo quadrado é também um retângulo, mas com todos os lados iguais. Vamos então criar uma classe que reflita isso.

<details>
  <summary>A classe <code>Square</code> deve ser derivada da classe <code>Rectangle</code></summary><br />

Todo quadrado é um subtipo de retângulo, pelo que faz sentido estabelecer aqui uma relação de herança.
  
</details>

<details>
  <summary>A classe <code>Square</code> deve ter um construtor que receba apenas um parâmetro <code>side</code> do tipo <code>double</code></summary><br />

Esse construtor deve repassar o valor de `side` para ambos os parâmetros do construtor da classe base.
  
</details>

<details>
  <summary>Escreva testes unitários para a classe <code>Square</code></summary><br />

Deve ser testado o seguinte:
- A classe deve ser herdeira de `Rectangle`
- `Width` e `Height` devem ser iguais e designados corretamente
- A classe deve retornar o valor da `Area` corretamente
- A classe deve lançar uma exceção ao recebe valores menores ou iguais a zero como parâmetros

</details>
  

## 3 - Crie uma classe `Parallelepiped`

Paralelepípedos são construtos com três dimensões, que possuem seis faces que são retângulos. Vamos criar uma classe que reflita isso.

<details>
  <summary>A classe <code>Parallelepiped</code> deve possuir uma propriedade <code>Width</code>, propriedade <code>Height</code> e uma propriedade <code>Depth</code>, as três do tipo <code>double</code></summary><br />

Essas propriedades irão representar a largura, a altura e a profundidade do paralelepípedo, respectivamente.
  
</details>

<details>
  <summary>A classe <code>Parallelepiped</code> deve possuir uma propriedade <code>Volume</code> com um getter que utilize a altura, a largura e a profundidade para retornar o valor correto</summary><br />

O volume de um paralelepípedo é igual a largura * altura * profundidade. Essa propriedade não deve ter um setter.
  
</details>


<details>
  <summary>A classe <code>Parallelepiped</code> deve possuir uma propriedade <code>FaceA</code>, uma propriedade <code>FaceB</code> e uma propriedade <code>FaceC</code>, as três do tipo `Rectangle`, utilizando altura, largura e profundidade para retornar retângulos que representem as suas faces</summary><br />

As faces devem representar o seguinte:
- Produto entre altura e largura
- Produto entre altura e profundidade
- Produto entre largura e profundidade
  
</details>

<details>
  <summary>A classe <code>Parallelepiped</code> deve possuir uma propriedade <code>SurfaceArea</code> com um getter que utilize as áreas das três faces para retornar o total da área de superfície</summary><br />

Some as áreas de todas as faces para retornar o valor da área de superfície do paralelepípedo.

Dica ✏️: Lembre-se que cada uma das três faces definidas deve ter sua área somada duas vezes, pois o paralelepípedo tem 6 faces, sendo que cada uma delas se repete uma vez.
  
</details>

<details>
  <summary>A classe <code>Parallelepiped</code> deve possuir um construtor que receba a altura, largura e profundidade como parâmetros, valide se todas são maiores que zero e atribua os valores de <code>Width</code>, <code>Height</code> e <code>Depth</code></summary><br />

Caso algum dos parâmetros seja negativo, deverá ser lançada uma `ArgumentException` com a mensagem `"All sides must be greater than zero"`.
  
</details>

<details>
  <summary>Escreva testes unitários para a classe <code>Parallelepiped</code></summary><br />

Deve ser testado o seguinte:
- `Width`, `Height` e `Depth` devem ser designados corretamente
- O volume deve retornar o valor correto
- A área de superfície deve retornar o valor correto
- As faces devem retornar as áreas corretas

</details>

## 4 - Crie uma classe `Cube`
Os cubos são subtipos de Paralelepípedos, mas suas faces são quadrados, o que torna a sua composição levemente diferente da classe base. Que tal especificarmos melhor essa característica?


<details>
  <summary>A classe <code>Cube</code> deve ser herdeira da classe <code>Parallelepiped</code></summary><br />

O primeiro passo aqui é definir a relação de herança entre as duas classes.
  
</details>

<details>
  <summary>A classe <code>Cube</code> deve ser ter uma propriedade <code>Side</code> do tipo double</summary><br />

Como temos todos os lados iguais, faz sentido podermos acessar o valor dos lados sem precisar especificar de qual lado estamos falando.
  
</details>

<details>
  <summary>A classe <code>Cube</code> deve ter um construtor que receba apenas um valor de <code>side</code>, repasse esse valor para todos os parâmetros da da classe <code>Parallelepiped</code> e o atribua à propriedade <code>Side</code></summary><br />
  
</details>

<details>
  <summary>Por fim, sobrescreva as propriedades <code>FaceA</code>, <code>FaceB</code> e <code>FaceC</code> da classe base para que o tipo retornado pelas três seja um <code>Square</code>, e não um <code>Rectangle</code></summary><br />

Como não existem propriedades virtuais, para sobrescrevê-las você pode simplesmente utilizar o modificador `new`.
  
</details>

<details>
  <summary>Escreva testes unitários para a classe <code>Cube</code></summary><br />

Deve ser testado o seguinte:
- A classe deve ser herdeira de `Parallelepiped`
- `Side` deve ser designado corretamente
- Todas as faces devem ser iguais e do tipo `Square`
- O volume deve ser retornado corretamente

</details>

Parabéns, agora você domina a utilização de composição e herança e pode ir rumo aos próximos desafios!
