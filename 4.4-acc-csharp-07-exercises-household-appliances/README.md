# Boas-vindas ao repositório do exercício Eletrodomésticos

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-exercises-household-appliances`.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-exercises-household-appliances`

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
    - Exemplo: `git checkout -b joaozinho-acc-0x-exercises-household-appliances`

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

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-0x-exercises-household-appliances`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-exercises-household-appliances/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-exercises-household-appliances/pulls) e confira que o seu _Pull Request_ está criado

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

Para entender melhor sobre o polimorfismo utilizando classes abstratas e interface, hoje vamos trabalhar com o conceito de eletrodoméstico. Em uma primeira análise, se quisermos representar uma abstração de um eletrodoméstico no C#, devemos criar uma classe simples, uma classe abstrata ou uma interface?

**É verdade que as três podem funcionar.** Mas um eletrodoméstico não representa um conjunto de funções que podem ser compartilhados entre classes que não possuem nenhuma correlação entre si, pois todos os eletrodomésticos têm uma coisa em comum: eles **SÃO** eletrodomésticos. A partir disso já podemos excluir as interfaces do ponto de vista da melhor forma de representar essa abstração.

Além do mais, um eletrodoméstico é uma definição que nos remete a um objeto específico ou a um conjunto de objetos concretos que são subtipos de eletrodoméstico? É o segundo caso, pois ninguém sai de casa pensando em comprar um eletrodoméstico, e sim em comprar uma geladeira, máquina de lavar, etc. Por isso, o mais adequado aqui é usar uma classe abstrata.

Utilizando esse conceito de eletrodoméstico, vamos praticar agora a criação de classes abstratas, interfaces e relações entre elas!

---
 
## 1 - Crie uma classe abstrata `Appliance`

<details>
  <summary>
    A classe `Appliance` deve ser **abstrata**
  </summary>
  <br />
  Utilize o modificador correto para criar uma classe abstrata
  <br /><br />
</details>

<details>
  <summary>
    A classe <code>Appliance</code> deve ser possuir as propriedades <code>string Brand</code>, <code>string Model</code> e <code>bool IsOn</code>
  </summary>
  <br />
  As propriedades devem ter getters e setters padrão, e não precisam ser abstratas, pois não iremos alterá-las nas classes herdeiras
  <br /><br />
</details>

<details>
  <summary>
    A classe <code>Appliance</code> deve ser possuir um construtor que receba e atribua os valores das propriedades <code>Brand</code> e <code>Model</code> e que receba o valor inicial da propriedade <code>IsOn</code>.
  </summary>
  <br />
  O recebimento inicial do <code>IsOn</code> pode não fazer muito sentido numa situação real, pois nenhum eletrodoméstico vem ligado de fábrica, mas é importante para que consigamos testar o funcionamento correto dessa classe mais pra frente.
  <br /><br />
</details>

---

## 2 - Crie uma interface `ICooker`

Diferentemente da classe `Appliance`, que só pode ser herdada por eletrodomésticos, a interface `ICooker` poderá ser implementada por objetos que não tenham relação entre si, como por exemplo um fogão, uma fogueira e um forno a lenha.

<details>
  <summary>
    A interface <code>ICooker</code> deve designar uma propriedade <code>BoilingTime</code> e uma propriedade <code>MaximumTemperature</code>, a serem utilizadas por classes que a implementarem.
  </summary>
  <br />
  A interface deve ser pública, mas não há necessidade de definir níveis de acesso aos membros definidos na interface, já que eles serão implementados em classes que poderão definir individualmente esse nível de acesso.
  <br /><br />
</details>

<details>
  <summary>
    A interface <code>ICooker</code> deve designar um método <code>void Cook</code> que receba como parâmetro uma <code>string food</code>, a ser implementado por classes que a utilizem.
  </summary>
  <br />
  O método deve receber uma string com o nome da comida a ser cozinhada, o que será repassado às classes que implementarem <code>ICooker</code>, já que os parâmetros fazem parte da assinatura do método.
  <br /><br />
</details>

---

## 3 - Crie uma classe `ElectricStove`

Essa classe representará um fogão cujo funcionamento dependa de energia elétrica.

<details>
  <summary>
    A classe <code>ElectricStove</code> deve ser herdeira de <code>Appliance</code>
  </summary>
  <br />
  Como não definimos nenhum método abstrato, não é necessário fazer nenhum override. Nesse caso, a definição da classe como abstrata foi baseada no fato de que todo elétrodoméstico tem um subtipo, não podendo ser instanciado diretamente.
  <br /><br />
</details>

<details>
  <summary>
    A classe <code>ElectricStove</code> deve ser implementar <code>ICooker</code>
  </summary>
  <br />
  As propriedades e o método de <code>ICooker</code> devem ser implementados diretamente na classe <code>ElectricStove</code>.
  <br /><br />
</details>

<details>
  <summary>
    O construtor de <code>ElectricStove</code> deve receber os valores de <code>Brand</code>, <code>Model</code>, <code>BoilingTime</code>, <code>MaximumTemperature</code> e <code>IsOn</code> e deve repassar os valores relevantes para o construtor da classe base.
  </summary>
  <br />
  As propriedades que são utilizadas no construtor de <code>Appliance</code> devem ser repassadas para serem corretamente atribuídas.
  <br /><br />
  <blockquote>
    <strong>Se liga na dica ✏️:</strong> O valor de <code>IsOn</code> pode ser um parâmetro default com o valor <code>false</code>, já que esse é o comportamento inicial padrão de um fogão.
  </blockquote>
  <br /><br />
</details>

<details>
  <summary>
    O método <code>Cook</code> deve ter uma validação condicional que lançará uma exceção caso o valor de IsOn esteja como falso, e imprima uma mensagem relevante no console caso seja verdadeiro.
  </summary>
  <br />
  Isso irá impedir que o método funcione quando o fogão estiver desligado. Insira também uma mensagem na exceção detalhando o que aconteceu de errado, isso irá ajudar a debugar o código no futuro caso seja necesssário!
  <br /><br />
</details>

<details>
  <summary>
    Implemente um método <code>Bake</code>, que deve funcionar de maneira parecida com o <code>Cook</code>, só que com mensagens diferentes ao executar com sucesso ou ao lançar a exceção.
  </summary>
  <br />
  Esse método será o único membro nativo da classe <code>ElectricStove</code>, já que os demais são definidos inicialmente ou em <code>Appliance</code> ou em <code>ICook</code>.
  <br /><br />
</details>

---

## 4 - Crie uma classe `Microwave`

Essa classe representará um aparelho de microondas.

<details>
  <summary>
    A classe <code>Microwave</code> deve ser herdeira de <code>Appliance</code>
  </summary>
  <br />
  Como não definimos nenhum método abstrato, não é necessário fazer nenhum override. Nesse caso, a definição da classe como abstrata foi baseada no fato de que todo elétrodoméstico tem um subtipo, não podendo ser instanciado diretamente.
  <br /><br />
</details>

<details>
  <summary>
    A classe <code>Microwave</code> deve ser implementar <code>ICooker</code>
  </summary>
  <br />
  As propriedades e o método de <code>ICooker</code> devem ser implementados diretamente na classe <code>Microwave</code>.
  <br /><br />
</details>

<details>
  <summary>
    O construtor de <code>Microwave</code> deve receber os valores de <code>Brand</code>, <code>Model</code>, <code>BoilingTime</code>, <code>MaximumTemperature</code> e <code>IsOn</code> e deve repassar os valores relevantes para o construtor da classe base.
  </summary>
  <br />
  As propriedades que são utilizadas no construtor de <code>Appliance</code> devem ser repassadas para serem corretamente atribuídas.
  <br /><br />
  <blockquote>
    <strong>Se liga na dica ✏️:</strong> O valor de <code>IsOn</code> pode ser um parâmetro default com o valor <code>false</code>, já que esse é o comportamento inicial padrão de um microondas.
  </blockquote>
  <br /><br />
</details>

<details>
  <summary>
    O método <code>Cook</code> deve ter uma validação condicional que lançará uma exceção caso o valor de IsOn esteja como falso, e imprima uma mensagem relevante no console caso seja verdadeiro.
  </summary>
  <br />
  Isso irá impedir que o método funcione quando o microondas estiver desligado. Insira também uma mensagem na exceção detalhando o que aconteceu de errado, isso irá ajudar a debugar o código no futuro caso seja necesssário!

   <blockquote>
    <strong>Se liga na dica ✏️:</strong> Não se esqueça que a mensagem será diferente da mensagem do fogão, já que ambos eletrodomésticos funcionam de forms diferentes. Com isso, teremos duas implementações diferentes da mesma mensagem!
  </blockquote>

  <br /><br />
</details>

<details>
  <summary>
    Implemente um método <code>Heat</code>, que deve funcionar de maneira parecida com o <code>Cook</code>, só que com mensagens diferentes ao executar com sucesso ou ao lançar a exceção.
  </summary>
  <br />
  Esse método será o único membro nativo da classe <code>Microwave</code>, já que os demais são definidos inicialmente ou em <code>Appliance</code> ou em <code>ICook</code>.
  <br /><br />
</details>

---

## 5 - Crie testes para as classes concretas criadas nos requisitos anteriores

Em geral, como interfaces e classes abstratas não são entidades instanciáveis e, inclusive, podem não possuir implementação, não há a necessídade de testá-las diretamente, já que as classes que as implementem/herdem serão sempre testadas individualmente.

<details>
  <summary>
    Implemente o teste <code>TestMicrowave</code> presente na classe de teste <code>ApplianceTests</code> para testar a classe do microondas.
  </summary>
  <br />
  Esse método deverá testar o seguinte:
  <ol>
    <li>O microondas deve ter o valor inicial de <code>IsOn</code> como falso</li>
    <li>O microondas deve ser da marca passada no <code>InlineData</code></li>
    <li>O microondas deve ser do modelo passado no </code>InlineData</code></li>
    <li>O microondas deve ter o tempo de cocção passado no <code>InlineData</code></li>
    <li>O microondas deve ter a temperatura máxima passada no </code>InlineData</code></li>
    <li>O método <code>SwitchPower()</code> deve inverter corretamente o valor de <code>IsOn</code></li>
    <li>O método <code>cook</code> deve lançar uma exceção quando <code>IsOn</code> for falso e não lançar quando for verdadeiro</li>
    <li>O método <code>heat</code> deve lançar uma exceção quando <code>IsOn</code> for falso e não lançar quando for verdadeiro</li>
  </ol>
  <br /><br />
</details>

<details>
  <summary>
    Implemente o teste <code>TestElectricStove</code> presente na classe de teste <code>ApplianceTests</code> para testar a classe do fogão.
  </summary>
  <br />
  Esse método deverá testar o seguinte:
  <ol>
    <li>O fogão deve ter o valor inicial de <code>IsOn</code> como falso</li>
    <li>O fogão deve ser da marca passada no <code>InlineData</code></li>
    <li>O fogão deve ser do modelo passado no </code>InlineData</code></li>
    <li>O fogão deve ter o tempo de cocção passado no <code>InlineData</code></li>
    <li>O fogão deve ter a temperatura máxima passada no </code>InlineData</code></li>
    <li>O método <code>SwitchPower()</code> deve inverter corretamente o valor de <code>IsOn</code></li>
    <li>O método <code>cook</code> deve lançar uma exceção quando <code>IsOn</code> for falso e não lançar quando for verdadeiro</li>
    <li>O método <code>bake</code> deve lançar uma exceção quando <code>IsOn</code> for falso e não lançar quando for verdadeiro</li>
  </ol>
  <br /><br />
</details>

<details>
  <summary>
    Implemente o teste <code>TestPolymorphism</code> presente na classe de teste <code>ApplianceTests</code> para testar a relação de polimorfismo entre as entidades criadas anteriormente.
  </summary>
  <br />
  Esse método deverá testar o seguinte:
  <ol>
    <li>Tanto um fogão quanto um microondas devem ser atribuíveis à classe `Appliance`</li>
    <li>Tanto um fogão quanto um microondas devem ser atribuíveis à interface `ICooker`</li>
  </ol>

  <blockquote>
    <strong>Se liga na dica ✏️:</strong> Sempre que uma classe A é atribuível como uma classe ou interface B, significa que todas as mensagens que B recebe podem ser interpretadas por A, comprovando assim a existência de uma relação polimórfica.
  </blockquote>

  <br /><br />
</details>

---

Agora você já está apto utilizar o polimorfismo no seu dia a dia e a utilizar corretamente as classes abstratas e interfaces, escolhendo sempre a melhor opção de acordo com o contexto no qual estiver trabalhando! #VQV
