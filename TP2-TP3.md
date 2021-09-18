## Teste de performance 2

Uma das maneira de elicitar e documentar requisitos de sistema é através de Casos de Uso. Nessa a elicitação de requisitos baseada em cenários, consultamos os envolvidos para saber o que desejam fazer. Em seguida pedimos para eles descreverem como imaginam que isso será feito utilizando o sistema. E finalmente mapeamos essa descrição em requisitos de sistema, representados como um conjunto de atores e casos de uso. Um conjunto completo de cenários deve descrever tudo que o sistema deveria fazer.

Nessa etapa da disciplina, o aluno vai aplicar seu conhecimento sobre a elicitação e documentação de requisitos utilizando cenários e casos de uso.

Seu objetivo, é especificar 5 requisitos de sistema para o sistema proposto: uma rede social simples baseado em um tema (escolhido pelo aluno, segundo regras definidas pelo professor nas primeiras aulas da disciplina).

#### RF1
| Requisito | Cadastro do usuário |
|---|:---:|
|Atores| Usuário - Sistema |
|Pré-condições|Nenhuma|
|Fluxo Básico|<p> O usuário deve informar um e-mail e senha.<br />Os dados do usuário são armazenados no banco de dados.<br />O sistema gera um link de confirmação de e-mail..<br />O sistema confirma a criação da conta.<br />O usuário é redirecionado para a página de login.<p>
|Fluxo Alternativo|O usuário não preenche todos os campos na tela de cadastro e tenta confirmar a criação da conta. Então uma mensagem de campo obrigatório deverá aparecer para cada campo não preenchido.<br />O usuário informa um e-mail que já foi utilizado. Então deverá aparecer na tela uma mensagem indicando que aquele e-mail está vinculado a alguma conta.
|Regras de validação|Confirmação de senha: O usuário deve inserir novamente a senha para confirmar que digitou corretamente e minimizar os riscos.<br />Validação de senha: Verificar se a senha informada atende aos requisitos de segurança(Deve conter letras e números e um mínimo de 8 dígitos).
|Pós condições| Nenhuma|

<br />
<br />

#### RF2
| Requisito | Login |
|---|:---:|
|Atores| Usuário - Sistema |
|Pré-condições|Usuário previamente cadastrado|
|Fluxo Básico|<p> O usuário deve informar um e-mail e senha previamente cadastrados para poder logar.<br />O sistema deve fazer distinção de caracteres de caixa alta e baixa dos dados inseridos pelo usuário.<br />Se o usuário informar corretamente o e-mail e senha ele será redirecionado para a página inicial.<br /><p>
|Fluxo Alternativo|O usuário informa um e-mail não cadastrado. Então o sistema exibe uma mensagem dizendo que o e-mail não está vinculado a nenhuma conta e gera um link para a página de criação de conta.<br />O usuário insere uma senha incorreta. Então o sistema mostra uma mensagem informando que a senha está incorreta e pede que o usuário insira novamente.
|Regras de validação|Caso o usuário insira incorretamente a senha 3 vezes consecutivas o sistema irá bloquear a tela de login por 5 minutos por questões de segurança. E também irá enviar um e-mail para o e-mail cadastrado informando que alguém está tentando acessar a conta.
|Pós condições| Nenhuma|

<br />
<br />

#### RF3
| Requisito | Criar publicações |
|---|:---:|
|Atores| Sistema |
|Pré-condições|Nenhuma|
|Fluxo Básico|<p> Deve aparecer na página inicial uma caixa de texto em que o usuário poderá digitar o que quiser publicar.<br />Deve ser possível ao usuário anexar imagens no formato JPG e PNG.<br />Deve ser disponibilizada ao usuário ferramentas para a personalização do texto(negrito, itálico, tamanho da fonte).<p>
|Fluxo Alternativo|Caso o usuário não insira nenhum caractere e não anexe nenhuma imagem a publicação não será criada e deverá aparecer para o usuário uma mensagem informando que não foi inserido nenhum caractere.
|Regras de validação|Limitação de caracteres: A publicação deve estar limitada a 255 caracteres.<br />Limitação de tamanho de arquivo: Deve estar limitado ao usuário anexar ao máximo 20mb de imagens.
|Pós condições|A publicação criada deverá aparecer na página de perfil do usuário|

<br />
<br />

#### RF4
| Requisito | Ferramenta de busca |
|---|:---:|
|Atores| Usuários - Sistema |
|Pré-condições|Usuário previamente cadastrado|
|Fluxo Básico|<p> No cabeçalho da página deve conter uma barra de pesquisa.<br />A barra de pesquisa deve ser capaz de identificar texto em publicações, nomes de perfil e grupos.<br />Deve retornar uma página com os resultados encontrados limitados a 20 por página.<p>
|Fluxo Alternativo|Caso o usuário não informe nenhum texto a busca deve retornar nenhum resultado.
|Regras de validação|Limitação de caracteres: A publicação deve estar limitada a 50 caracteres.
|Pós condições|Uma página de resultados deve ser exibida ao ser realizada a busca.|

<br />
<br />

#### RF5
| Requisito | Fazer conexões |
|---|:---:|
|Atores| Usuários - Sistema |
|Pré-condições|Usuário previamente cadastrado|
|Fluxo Básico|<p> O usuário pode enviar a outro usuário uma solicitação de conexão.<br />O usuário que receber a solicitação terá a possibilidade de aceitar ou recusar a conexão.<br />Usuários com conexões estabelecidas ganham uma visibilidade maior das informações dos seus perfis.<br />Se o usuário aceitar a solicitação uma nova conexão deverá ser estabelecida.<p>
|Fluxo Alternativo|Nenhum.
|Regras de validação|Nenhuma
|Pós condições|Caso a solicitação seja recusada, o usuário não poderá enviar uma nova solicitação dentro do prazo de uma semana.

<br />

## Teste de performance 3

O documento de especificação de requisitos de software é uma descrição completa do comportamento do sistema a ser desenvolvido. Esse documento contém vários tópicos relacionados a etapa de engenharia de requisitos. De modo geral, são desenvolvidos nesta documentação tópicos como: o propósito, o escopo do projeto (indicando o que faz parte do projeto e o que não faz), os requisitos de usuário, os requisitos de sistema (utilizando casos de uso para descrever a interação do usuário com o sistema) e a matriz de rastreabilidade de requisitos.

Seu objetivo neste TP, é produzir um documento de especificação de requisito de software (seguindo o modelo simplificado sugerido nessa etapa) para uma rede social simples baseado em um tema (escolhido pelo aluno, segundo regras definidas pelo professor nas primeiras aulas da disciplina).

Você também deverá incluir algum tópico adicional no documento de especificação de requisitos de software, pesquisando na literatura recomendada, suporte para desenvolver o tópico. Algumas sugestões de tópico adicional: requisitos não funcionais, usuários e características, público-alvo, glossário de termos.

### Especificação de requisitos

#### Introdução

O objetivo deste documento é apresentar os objetivos dessa aplicação de rede social bem como apresentar os requisitos que o sistema deve atender em diferentes níveis de detalhamento.

#### Escopo do Produto

Este é um projeto de uma rede social que tem como objetivo criar uma vasta base de usuários que criem conexões e compartilhem informações entre si, baseado em temas religiosos, interesses em comum e localização geográfica.
Os usuários poderão formar grupos, criar conexões, criar publicações, compartilhar publicações. Alterar informações do perfil e interesses.

#### Público Alvo

Igrejas e grupos religiosos.

#### Requisitos do usuário

Cadastro do usuário = O usuário deve informar o seu e-mail e uma senha para poder se cadastrar.<br />
Login = O usuário deve inserir corretamente um e-mail e senha cadastrados previamente.<br />
Criar publicações= O usuário deve inserir um texto ou anexar uma imagem da sua máquina.<br />
Ferramenta de busca = O usuário deve informar um texto a ser buscado.<br />
Fazer conexões= O usuário deverá solicitar a outro usuário para realizar uma conexão.<br />
Sistema de comentários em publicações= O usuário deve informar um texto como comentário em alguma publicação.<br />
Grupos= O usuário poderá entrar em um grupo ou criar um novo grupo.<br />
Configurações de informações da conta = O usuário pode alterar informações de dados da sua conta sempre que achar necessário.

#### Requisitos de sistema

Cadastro do usuário = O sistema deve receber as informações inseridas pelo usuário e salvar no banco de dados.<br />
Login = O sistema deve validar as informações inseridas pelo usuário de acordo com as informações cadastradas no banco de dados.<br />
Criar publicações= O sistema deve receber um texto do usuário e retornar uma publicação na página de perfil do usuário.<br />
Ferramenta de busca = O sistema deve receber um texto inserido pelo usuário e não fazer distinção a caracteres de caixa alta e caixa baixa.<br />
Fazer conexões= O sistema deve enviar uma notificação ao usuário que está recebendo a solicitação de conexão para que ele aceite ou não.<br />
Sistema de comentários em publicações= O sistema deve receber o texto do usuário e retornar um comentário que poderá ser apagado pelo usuário caso ele ache necessário.<br />
Grupos= O sistema deve criar um grupo de acordo com os parametros definidos pelo usuário e caso o usuário convide outros usuários a este grupo, o sistema deverá enviar uma notificação de convite.<br />
Guias= O sistema deve mostrar guias rápidas para o feed, perfil, caixa de mensagens, configurações.<br />
Configurações de informações da conta = O sistema deve alterar as informações solicitadas pelo usuário no banco.

#### Matriz de rastreabilidade de requisitos

Requisito|Status|Prioridade|Complexidade
---|---|---|---
Cadastro do usuário|Não iniciado|Alta|Baixa
Validação do login|Não iniciado|Alta|Média
Publicações|Não iniciado|Média|Alta
Ferramenta de busca|Não iniciado|Média|Baixa
Conexões entre usuários|Não iniciado|Média|Alta
Comentários em publicações|Não iniciado|Baixa|Média
Grupos|Não iniciado|Baixa|Alta
Configurações da conta|Não iniciado|Alta|Média
