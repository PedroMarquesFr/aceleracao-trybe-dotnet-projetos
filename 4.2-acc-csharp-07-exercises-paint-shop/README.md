
# Boas-vindas ao repositório do exercício Paint Shop

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project/exercise-paint-shop`.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-project/exercise-paint-shop`

  2. Instale as dependências

  - `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique que você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-0x-project/exercise-paint-shop`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o exercício paint-shop` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa:  _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-0x-project/exercise-paint-shop`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-project/exercise-<ATUALIZAR>`/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-project/exercise-<ATUALIZAR>`/pulls) e confira que o seu _Pull Request_ está criado

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

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/PaintShop` ou de seus testes `src/PaintShop.Test`!

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

Vamos supor que uma loja de materiais de construção tenha recebido diversas reclamações de clientes sobre não saber quanta tinta comprar pra pintar suas casas.

- Algumas pessoas compram tinta demais e ficam com latas de tinta sobrando após a reforma.
- Outras pessoas são o contrário. Acabam precisando fazer mais de uma viagem pra comprar mais tinta porque a quantidade comprada anteriormente não deu conta do recado.

Pensando em resolver esse problema, essa loja resolveu contratar uma pessoa desenvolvedora para criar uma biblioteca de classes utilitárias que possa ser importada para o sistema atual da loja, desenvolvido em C#.

A loja inicialmente contratou outra pessoa desenvolvedora, que desenvolveu uma classe `Wall`. 

Essa classe já traz consigo uma uma funcionalidade muito importante, que é a de calcular as áreas individuais de cada parede! Ela já tem as seguintes propriedades:

- `Height` representando a **altura** da parede;
- `Width` representando a **largura** da parede;
- `ExcludedArea` representando a **área da parede que não será pintada**, onde podem haver portas, janelas, etc.
- `PaintableArea` representando a área da parede a ser pintada

> A classe também já está 100% testada e você pode, inclusive utilizar o `WallTest` como inspiração para testar as classes que você irá desenvolver no exercício! 

Todavia, essa a pessoa inicialmnte contratada precisou se afastar do projeto e **a loja decidiu te contratar para dar continuidade ao serviço graças a sua habilidade em .NET**!


![tintas espalhadas](./img/headpainters.gif)
  
> Aviso ⚠️: Antes de começar, certifique-se de que todas as classes e métodos serão criados nos respectivos arquivos, já presentes no projeto. Também se certifique de que todas as classes, propriedades, métodos e construtores são **públicos** (ou seja, possuem o modificador `public` antes da declaração), caso contrário os testes automatizados irão falhar.

## Antes de desenvolver: explicando `TheoryData` e `MemberData`:

Atenção ⚠️: As classes de teste já estão prontas e contêm algumas propriedades que usam a classe `TheoryData` do XUnit, que é algo que você ainda não viu.

O `TheoryData` serve para mandar dados sob a forma da anotação `MemberData`, que funciona de forma parecida com o `InlineData` que você já conhece, definindo os valores que serão passados para o teste.

Para exemplificar melhor, as anotações seguintes possuem o mesmo efeito, passando os valores como parâmetros para o método de teste:


```csharp
[Theory]
[InlineData(1, 2, 3)]
[InlineData(4, 5, 6)]
MétodoDeTeste(int arg1, int arg2, int arg3) {...}
```

```csharp
public static TheoryData<int, int, intData =>
    new TheoryData<int, int, int>
    {
        { 1, 2, 3 },
        { 4, 5, 6 }
    };

[Theory]
[MemberData(nameof(ValidOverloadData))]
MétodoDeTeste(int arg1, int arg2, int arg3) {...}
```

### *Mas se o `TheoryData` é tão mais complexo, porque não usar sempre o `InlineData`?*

É simples: quando queremos passar **objetos** como parâmetros, o `InlineData` não pode ser usado, pois ele só pode passar **tipos de valor**, e não **tipos de referência**! Assim, se quisermos passar instâncias de um objeto (como é o caso do `Wall`, no exemplo do `RoomTest`), precisamos usar um `TheoryData` para instanciar esse objeto e passálo como MemberData!

Mas não se preocupe muito com essa sintaxe, pois a configuração do `TheoryData` já está pronta. Tudo o que você precisa saber é que **os valores contidos nele serão passados como se fosse em um `InlineData`, com a diferença de que podemos também passar objetos**.

## Requisitos:
---
## 1 - Crie uma classe `Room`

Já temos as paredes, agora precisamos representar os cômodos!

<details>
  <summary>A classe <code>Room</code> <strong>não</strong> deve ser estática</summary><br />

Como as paredes, os cômodos também representam ambientes distintos e instanciáveis.

</details>

<details>
  <summary>A classe <code>Room</code> deve possuir uma propriedade pública <code>Walls</code> que seja um array de objetos do tipo <code>Wall</code> que criamos no requisito 2 (ou seja, um <code>Wall[]</code>). Essa propriedade não deve possuir um <code>set</code>.</summary><br />

Ao não atribuirmos um setter a essa propriedade, ela poderá ser atribuída apenas na inicialização, o que faz sentido, pois não deve ser possível alterar a quantidade de paredes de um cômodo sem que ele vire outro cômodo diferente.

</details>

<details>
  <summary>A classe <code>Room</code> deve possuir uma propriedade pública <code>TotalPaintableArea</code> do tipo <code>double</code> que represente toda a superfície a ser pintada</summary><br />

</details>

<details>
  <summary>A classe <code>Room</code> deve possuir um construtor que receba um <code>Wall[]</code> e o atribua à propriedade <code>Walls</code></summary><br />

Ao criar um cômodo, iremos passar as de paredes que o irão compor e, a partir dessa informação, poderemos retornar o total da área a ser pintada para usar na classe de utilidades que criaremos a seguir.

> Dica: para essa classe, o ideal é utilizar a palavra-chave `params` no construtor, pois isso o permitirá receber um dos três inputs a seguir:
>
> - Uma sequência de argumentos do tipo `Wall` separados por vírgula, que será convertida em um `Wall[]` automaticamente sem que ele precise ser inicializado,
> - Um `Wall[]` inicializado previamente (o que seria o único comportamento aceito caso não se usasse o `params`).
> - Nenhum argumento. Nesse caso, teremos um `Wall[]` vazio sendo passado.
> 
> . Para saber mais, veja a documentação [aqui](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/params).
  
</details>

<details>
  <summary>Escreva testes unitários para a classe <code>Room</code> usando <code>xUnit</code> e <code>FluentAssertions</code>!</summary><br />

O arquivo onde os testes deverão ser escritos é o `RoomTest.cs`. Utilize os métodos já delclarados.

Os testes devem verificar:
- se a instanciação é bem sucedida com um `Wall[]` com dois elementos válidos,
- se a propriedade TotalPaintableArea retorna a soma dos valores de `PaintableArea` das paredes passadas pra o cômodo

</details>

---

## 2 - Crie uma classe estática `PaintUtilities`

A classe `PaintUtilities` será nossa principal suite de métodos de utilidades!

<details>
  <summary>A classe <code>PaintUtilities</code> deve ser estática.</summary><br />

A classe não poderá ser instanciada em objetos, já que não representa uma abstração de um objeto real.  
</details>

<details>
  <summary>A classe <code>PaintUtilities</code> deve possuir uma propriedade pública <code>BucketSizeLiters</code> do tipo <code>int</code> com valor <code>20</code></summary><br />

Lembre-se que todo membro da classe `PaintUtilities` deve ser estático. A atribuição do valor pode ser feita de forma direta ou por um construtor estático.
  
</details>

<details>
  <summary>A classe <code>PaintUtilities</code> deve possuir uma propriedade pública <code>SquareMetersPerLiter</code> do tipo <code>int</code> com valor <code>10</code></summary><br />

Lembre-se que todo mebro da classe `PaintUtilities` deve ser estático. A atribuição do valor pode ser feita de forma direta ou por um construtor estático.
  
</details>

<details>
  <summary>A classe <code>PaintUtilities</code> deve possuir uma propriedade pública <code>SquareMetersPerBucket</code> do tipo <code>int</code> com um <code>get</code> explícito e sem um <code>set</code></summary><br />

O método `get` da propriedade `SquareMetersPerBucket` deve calcular a quantidade de metros quadrados que cada balde de tinta irá render utilizando os valores das propriedades BucketSizeLiters e SquareMetersPerLiter.
  
</details>

<details>
  <summary>A classe <code>PaintUtilities</code> deve possuir um método público <code>GetNeededPaintBuckets()</code> com três <code>overloads</code>: um que receba a área em m² com o tipo <code>double</code>, um que receba uma parede do tipo <code>Wall</code> e um que receba um cômodo do tipo <code>Room</code> e retorne a quantidade de tinta a ser usada em <strong>baldes</strong> como <code>int</code>.</summary><br />

O método `GetNeededPaintBuckets()` é o principal método da nossa classe de utilidades. Por isso, ele deve conseguir trabalhar tanto com o valor da área em si quanto com paredes e cômodos.

O valor deve ser retornado em baldes de tinta, não em litros. Para isso, *considere aceitável que ao final da pintura haja alguma sobra, contanto que essa sobra seja **menor que um balde inteiro***.

> Dica :pencil2::  um overload acontece quando declaramos o mesmo método mais de uma vez, mas com parâmetros diferentes em cada uma das declarações. Assim, podemos escolher que tipo de argumento queremos passar (ou se não queremos passar nenhum).
>
> Como a tipagem do C# é estática, o compilador irá saber qual das versões do método usar a partir da forma como o invocamos.
  
</details>

<details>
  <summary>A classe <code>PaintUtilities</code> deve possuir um método público <code>CalculateCost</code> com dois parâmetros. O preimeiro é o preço do balde de tinta, em formato <code>decima</code>. O segundo será dividido em três <code>overloads</code> iguais ao do <code>GetNeededPaintBuckets()</code>: área (<code>double</code>), parede(<code>Wall</code>) ou cômodo (<code>Room</code>). Retorne o custo da tinta como <code>decimal</code>.</summary><br />

O método PaintUtilities deverá utilizar o método GetNeededPaintBuckets() para conseguir a quantidade de baldes a ser comprada e, com essa informação mais o preço do balde passado no parâmetro, retornar o custo total da obra.

Utilize três overloads aqui que façam uso dos três overloads de GetNeededPaintBuckets() que você criou anteriomente.

> Dica :pencil2::  um overload acontece quando declaramos o mesmo método mais de uma vez, mas com parâmetros diferentes em cada uma das declarações. Assim, podemos escolher que tipo de argumento queremos passar (ou se não queremos passar nenhum).
>
> Como a tipagem do C# é estática, o compilador irá saber qual das verões do método usar a partir da forma como invocamos o método.
  
</details>

<details>
  <summary>Escreva testes unitários para a classe estática <code>PaintUtilities</code> usando <code>xUnit</code> e <code>FluentAssertions</code>!</summary><br />

Utilize o arquivo `PaintUtilitiesTest` para criar seus testes. Utilize os métodos já declarados.

O teste deve verificar:
- se a classe estática `PaintUtilities` tem os valores iniciais corretos
- se é possível alterar os valores das propriedades estáticas `BucketSizeLiters` e `SquareMetersPerLiter` e se isso reflete corretamente em `SquareMetersPerBucket`
- se todos os overloads de `GetNeededPaintBuckets` funcionam corretamente
- se todos os overloads de `CalculateCost` funcionam corretamente
</details>

---

Parabéns! Agora os clientes da loja nunca mais terão problemas para comprar tintas e o dono está totalmente satisfeito com sua entrega!
