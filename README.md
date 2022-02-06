##### Autor Aquiles Mauro Vieira Caetano(Zero ILumi)
##### Link do GitHub: https://github.com/ZeroILumi.
##### Link do Linkedin: https://www.linkedin.com/in/aquiles-mauro-96b0a3176/.
# Apresentação Pratica de C#:
  * ## Lista de Assuntos tratados nesse projeto:
    1. [x] (1) Instalando ou Atualizando o SDK do .NET.   
    2. [x] (2) Verificando qual a versão do .NET esta sendo utilizada com o comando "dotnet --version" na CLI(Command-Line Interface).
	3. [x] (3) Instalando ou Atualizando(por fora nesse caso) nossa IDE(Integrated Development Environment) o Visual Studio Code.
	4. [x] (4) Instalando a Extensão/Plug-in Portuguese (Brazil) Language Pack for Visual Studio Code para deixar o Visual Studio Code em Português do Brasil.
	5. [x] (5) Instalando a Extensão/Plug-in "C#" para permitir a utilização de códigos C# no Visual Studio Code.
	6. [x] (6) Instalando a Extensão/Plug-in "C# Extensions" do Autor "jchannon" para facilitar o trabalha com "C#" no Visual Studio Code.
 	7. [x] (7) Usando a ajuda do .NET com o comando "dotnet --help" na CLI(Command-Line Interface).
	8. [x] (8) Usando a ajuda do .NET em comandos específicos com o comando "dotnet "comando" --help" na CLI(Command-Line Interface).
	9. [x] (9) Verificando as informações do .NET em geral na CLI(Command-Line Interface) com o comando "dotnet --info".
	10. [x] (10) Verificando os possíveis Templates\Modelos de projetos .NET com o comando de CLI(Command-Line Interface) "dotnet new --list".
	11. [x] (11) Criando um .gitignore para C# com o comando de CLI(Command-Line Interface) "dotnet new gitignore".
	12. [x] (12) Criando uma aplicação\projeto do tipo Console para executar no terminal ou CLI(Command-Line Interface) com o comando de CLI(Command-Line Interface)  "dotnet new console -n "nome_do_projeto"".
	13. [x] (13) Executando nossa aplicação\projeto dentro do terminal ou CLI(Command-Line Interface) com o comando de CLI(Command-Line Interface) "dotnet run".
	14. [x] (14) Restaurando pacotes do projeto C# com o comando de CLI(Command-Line Interface) "dotnet restore".
	15. [x] (15) Compilando o código do nosso projeto sem executá-lo com o comando de CLI(Command-Line Interface) "dotnet build".
    16. [x] (16) Importando o biblioteca System no arquivo Program.cs com a palavra chave using.	
	17. [x] (17) Criando o ponto de "start\inicio" do nosso projeto no arquivo Program.cs com a class Program e seu método static void Main(string[] args).  
	18. [x] (18) Criando um namespace para nosso arquivo Program.cs para permitir a importação de seu conteúdo por outros arquivos com a palavra chave namespace.
	19. [x] (19) Imprimindo\Escrevendo dados no terminal ou CLI(Command-Line Interface) com o comando System.Console.WriteLine("texto_a_ser_escrito_na_CLI(Command-Line Interface)").
	20. [x] (20) Criando um variável para controlar o limite maximo de um loop de for(para).
	21. [x] (21) Para repetir um bloco de código um número predeterminado de vezes controlando o inicio do loop e o fim do loop utilizamos o laço de repetição for(para).
	22. [x] (22) Imprimindo\Escrevendo o valor das variáveis interpolado\junto com um texto no "System.Console.WriteLine($""texto_a_ser_escrito_na_CLI(Command-Line Interface)"{nome_da_variavel}")" com um interpolador de strings representado no C# pelo simbolo de "$".
	23. [ ] (23) 
##  Assunto de número(1):
  * #### Para instalarmos o SDK(Software Development Kit) do .NET para começarmos a utilizar o mesmo temos que ir para a pagina no link: https://dotnet.microsoft.com/en-us/download, depois e necessário clicar em "Download .NET SDK x64" caso sua maquina utilize 64bits no caso a minha utiliza, vou utilizar o .NET 6.0 porém caso eu queira ou necessite utilizar de uma versão mais antiga do .NET basta somente eu clicar em "All .NET versions" e poderei baixar as versões ate o .NET Core 1.0 no presente momento, depois instale o SDK que foi baixado e pronto já pode utilizar o .NET.
## Assunto de número(2):
  * #### Para Verificarmos qual versão do .NET esta instalada em nossa maquina e utilizado o comando "dotnet --version" na CLI(Command-Line Interface) e esse comando ira retornar na interface da CLI no meu caso o Git Bash a versão mais atual do SDK(Software Development Kit) .NET instalada em sua maquina, no meu caso ele esta na versão "6.0.100".
## Assunto de número(3):
  * #### Para instalarmos a IDE(Integrated Development Environment) que sera utilizada para escrever os códigos em breve apresentados o Visual Studio Code devemos ir no link: https://code.visualstudio.com/download, escolher os Sistema Operacional no meu o caso o Windows 10 e escolher entre a versão de 64bits ou 32bits dependendo do seu computador e instalar o "System Installer" depois instalar o Visual Studio Code através do que foi baixado e ele já esta pronto para iniciar a escrita de códigos C# no caso mais não se limita a isso aceitando quasse qualquer linguagem.
## Assunto de número(4):
  * #### Para deixar o Visual Studio Code em Português do Brasil devemos utilizar a Extensão/Plug-in "Portuguese (Brazil) Language Pack for Visual Studio Code"; Dentro do Visual Studio Code vá nesse ícone:
    ![Imagem de Extensão/Plug-in VS Code](Imagens_README/Extensoes_VS_Code_Imagem.png)
  * #### E procure na busca a Extensão/Plug-in Portuguese (Brazil) Language Pack for Visual Studio Code, depois clicar em install e espere instalar depois reinicie o Visual Studio Code.
## Assunto de número(5):
  * #### Para utilizar o C# no Visual Studio Code precisamos baixar e instalar a Extensão/Plug-in "C#" clicando no ícone de Extensão/Plug-in dentro do Visual Studio Code:
    ![Imagem de Extensão/Plug-in VS Code](Imagens_README/Extensoes_VS_Code_Imagem.png)
  * #### Depois pesquise "C#" no campo de busca, baixe e instale e se necessário reinicie o Visual Studio Code e pronto ja pode utilizar o C# dentro do Visual Studio Code. 	
## Assunto de número(6):
  * #### Para facilitar a utilização do C# no Visual Studio Code vamos baixar e instalar a Extensão/Plug-in "C# Extensions" do Autor "jchannon"; Dentro do Visual Studio Code clique no icone de Extensão/Plug-in:
    ![Imagem de Extensão/Plug-in VS Code](Imagens_README/Extensoes_VS_Code_Imagem.png)
  * #### Depois de instalar a Extensão/Plug-in "C# Extensions" reinicie o Visual Studio Code caso seja necessário, agora seu Visual Studio Code tera alguns auxílios para C#. 
## Assunto de número(7):
  * #### Para conseguirmos uma ajuda sobre quais os comandos do .NET podemos executar na CLI(Command-Line Interface), utilizamos na CLI(Command-Line Interface) o comando "dotnet --help" do qual nos ira retornar informações sobre:
    * #### A versão do .NET mais atual instalada no computador;
	* #### Comandos para executar um aplicativo do .NET;
	* #### Opções de RunTime do .NET;
	* #### Comandos do SDK do .NET;
	* #### Opções e Flags do SDK do .NET;
    * #### Comandos adicionais de ferramentas em pacote.
## Assunto de número(8):
  * #### Para conseguirmos uma ajuda sobre um comando especifico do .NET devemos executar na CLI(Command-Line Interface), o comando "dotnet "comando" --help" e no lugar de "comando" colocamos o comando do .NET do qual queremos mais informações como por exemplo "dotnet add --help". 
## Assunto de número(9):
  * #### Para verificarmos informações sobre o .NET em geral utilizamos na CLI(Command-Line Interface) o comando "dotnet --info" que nos retorna as seguintes informações sobre o .NET:
    * #### A versão mais atual da SDK que temos instalada do .NET;
	* #### O sha1 do commit da SDK;
	* #### Qual e o Ambiente de runtime, ou seja qual e o nome do sistema operacional, a versão do sistema operacional, a plataforma do sistema operacional, a RID do sistema operacional, e o BasePath(Onde o SDK do .NET esta instalado na maquina).
    * #### Qual e o Host do SDK do .NET, em qual versão ele esta e qual o sha1 de seu commit;
    * #### Quais são todas as SDKs do .NET que estão instaladas em seu computador, com suas versões e onde estão instaladas;
	* #### Quais são todos os .NET Runtimes que estão instalados em seu computador, com seus nomes, versões, caminhos onde estão instaladas.
## Assunto de número(10):
  * #### Para verificarmos quais são os Templates\Modelos de projetos possíveis de se criar com o comando "dotnet new" utilizamos na CLI(Command-Line Interface) o comando "dotnet new --list" que retorna um lista contendo dados sobre os Templates\Modelos de projeto possíveis de se criar com o comando "dotnet new" são esses:
    * #### Nome do Template\Modelo;
	* #### Nome Curto do Template\Modelo;
	* #### Linguagem de programação do Template\Modelo.
## Assunto de número(11):
  * #### Para criarmos um .gitignore de C# automaticamente podemos utilizar o comando de CLI(Command-Line Interface) "dotnet new gitignore" do qual ira criar um arquivo .gitignore pre pronto com todos os arquivos que devem ser ignorados pelo git referentes ao .NET e C#.
## Assunto de número(12):
  * #### Para criarmos uma aplicação\projeto do tipo Console para que o possamos executar em um terminal ou em uma CLI(Command-Line Interface) utilizamos o comando de CLI(Command-Line Interface) "dotnet new console -n "nome_do_projeto"" e no lugar de "nome_do_projeto" colocamos o nome do qual nosso projeto tera, esse comando trara como retorno a criação de uma pasta com o nome do nosso projeto contendo os arquivos de nosso projeto Console, incluindo o arquivo "nome_do_projeto".csproj e o Program.cs do qual sera o arquivo inicial do nosso projeto Console, alem disso cria um pasta chamada obj que contem alguns artefatos do projeto, e depois de abrir no vs code sera criada a pasta bin para os arquivos binarios do projeto como os arquivos .dll e .exe, e uma pasta vs code com um launch.json e tasks.json.
## Assunto de número(13):
  * #### Para executarmos nossa aplicação\projeto de Console no terminal ou na CLI(Command-Line Interface) utilizamos o comando de CLI(Command-Line Interface) "dotnet run" esse comando trara como retorno a restauração dos pacotes do projeto , a compilação\montagem do código do projeto e a execução e processamento de nossos códigos no Program.cs e retorna os dados que devem ser impressos\exibidos no terminal ou CLI(Command-Line Interface).
## Assunto de número(14):
  * #### Para restaurarmos os pacotes de nosso projetos C# utilizamos o comando de CLI(Command-Line Interface) "dotnet restore", esse comando retorna a restauração de todos os pacotes atrelados ao nosso projeto arrumando e atualizando os mesmos.
## Assunto de número(15):
  * #### Para compilarmos\montamos os códigos de nosso projeto C# sem executá-lo utilizamos o comando de CLI(Command-Line Interface) "dotnet build", esse comando retorna a restauração dos pacotes do projeto e o compila sem o executar e mostra a quantidade de Avisos e Erros sobre o mesmo essa compilação\montagem gera os arquivos .dll, .exe e .pdb(são os pontos de debug que tem no projeto) e alguns arquivos relacionado a dependências do projeto C#.
## Assunto de número(16):
  * #### Vamos importar a biblioteca System com a palavra chave using, a palavra chave using nos permite importa bibliotecas, pacotes, arquivos, pastas entre outras coisas para o arquivo da qual ela esta presente escrevendo "using "namespace_do_que_vai_ser_importado_para_o_arquivo_atual"" depois no lugar de "namespace_do_que_vai_ser_importado_para_o_arquivo_atual" coloca-se o namespace da biblioteca, pacote, arquivo que se deseja importar para o arquivo atual. 
## Assunto de número(17):
  * #### Vamos criar um ponto de "start\inicio" para a nosso projeto no arquivo Program.cs com a class Program e seu método static void Main(string[] args), isso para quando dermos o comando dotnet run execute o que estiver dentro do método Main() da class Program no arquivo Program.cs, o retorno desse método Main() se da nessa execução de código.
## Assunto de número(18):
  * #### Para permitir a importação do conteúdo de nosso arquivo Program.cs utilizaremos um namespace que e criado com a palavra chave "namespace "nome_do_namespace"" no lugar de "nome_do_namespace" coloca-se o nome do qual devera ser escrito no using para importar o conteúdo deste arquivo em outros arquivos. 
## Assunto de número(19):
  * #### Para imprimir\escrever dados no console no C# utilizamos um comando de "System" chamado de "System.Console.WriteLine("texto_a_ser_escrito_na_CLI(Command-Line Interface)")", e no lugar de "texto_a_ser_escrito_na_CLI(Command-Line Interface)" escreva o texto do qual você deseja que seja impresso\escrito no terminal ou na CLI(Command-Line Interface), o WriteLine escreve e pula uma linha diferentemente do Write.
## Assunto de número(20):
  * #### Para controlar quantas vezes um loop de for(para) vai repetir o bloco de código atrelado a ele vamos utilizar um variável aqui chamada de "numero_de_vezes" e seu valor sera a quantidade de vezes que o loop sera repetido.
## Assunto de número(21):
  * #### Para criar um loop de um bloco de código controlando o inicio e fim desse loop nos utilizamos o laço de repetição for(para) que na pratica e assim "for(int inicio = "valor_inicial_do_loop"; inicio < "valor_final_do_loop"; inicio++)" geralmente o var\int que armazena o valor inicial do loop aqui "inicio" e chamada de "i" esse int "i" recebe um valor numérico inteiro aqui chamado de "valor_inicial_do_loop" no qual representa o valor de onde o loop se iniciara; Depois temos o controle do número de vezes que o loop repetira com o valor final aqui chamado de "valor_final_do_loop" que também e um valor numérico inteiro e uma comparação que deve ser FALSA\FALSE para que o loop seja quebrado aqui representa pelo menor que "<" nesse caso o loop só acabara quando o "valor_inicial_do_loop" for igual ou maior que o "valor_final_do_loop" pois isso torna a condição da comparação FALSA\FALSE e o loop só ocorrera quando ela for Verdadeira\TRUE; Por ultimo mais não menos importante temos o "quebrador de loop" ou incremento ou decremento nesse caso incremento do qual a responsabilidade se da em aumentar o diminuir o valor do "valor_inicial_do_loop" que esta na var "inicio" a fim de quebrar a condição do loop de for tornando-a FALSA\FALSE e assim encerrando o loop de for sem isso o loop seria eterno, caso a condição não seja quebrada pelo "quebrador de loop" devido a uma situação por exemplo onde o loop só se quebrara caso o "valor_inicial_do_loop" seja maior que o "valor_final_do_loop" um ação de decremento ou "--" geraria também um loop eterno,sendo necessário nessa situação um incremento ou "++" para quebrar esse loop de for.  
## Assunto de número(22):
  * #### Para interpolar\juntar um texto com o valor de uma ou mais variáveis no C# em uma impressão\escrita no terminal ou na CLI(Command-Line Interface) utilizamos um interpolador de string no System.Console.WriteLine que e representado no C# pelo simbolo de "$" e o valor das variáveis entre chaves "{"}" o comando interpolando valor de variáveis e texto\string fica assim "System.Console.WriteLine(""texto_a_ser_escrito_na_CLI(Command-Line Interface)"{"nome_da_variavel}")" onde colocamos no lugar de "texto_a_ser_escrito_na_CLI(Command-Line Interface)" o texto\string que queremos que seja escrito no termina ou na CLI(Command-Line Interface) e no lugar de "{"nome_da_variavel"}" colocamos o nome_da_variavel cujo o valor queremos que seja interpolado e impreso junto com o texto\string no terminal ou na CLI(Command-Line Interface);