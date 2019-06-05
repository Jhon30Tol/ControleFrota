# ControleFrota
SisLog

Trabalho Acadêmico - Projeto e Desenvolvimento de um Sistema para Controle de frotas.
Desenvolvido por:
WAGNER RODRIGUES NEVES

JONATHAS TOLEDO PEREIRA 

PALUAN BATISTA DA SILVA 

MARCOS ROBERTO LOPES 

IGOR HENRIQUE DA SILVA 

MARCIO BRENO BERNARDI BARBARO 


INSTALAÇÃO DO SOFTWARE
1 - Acessar a Pasta ControleFrotas.

2 - Executar o arquivo PimSql.sql no MySql Workbench. Selecionar todas as linhas e executar. O banco estará criado e pronto para utilização.

3 - Executar o software pelo executável PimFrota.exe

4 - Informar usuário e senha padrão:

Usuário padrão: admin

Senha padrão: admin

REQUISITOS PARA A INSTALAÇÃO DO SOFTWARE:
WINDOWS 7, 8 OU 10 COMO SISTEMA OPERACIONAL.

MYSQL WORKBENCH COMO SGBD.

UTILIZAÇÃO DO SOFTWARE
DEPENDÊNCIAS

Algumas rotias possuem dependências relacionadas umas as outras, ou seja, algumas dependem de outras para existir através de um relacionamento, como por exemplo: 
para que um viagem possa ser cadastrada, ele deve ter cadastrado um motorista, um Veiculo e cidades.

DEPENDÊNCIAS EXISTENTES

VIAGEM > MOTORISTA

Para que uma viagem possa ser cadastrado, é necessario ter pelo menos um motorista cadastrado.

VIAGEM > VEICULO

Para que uma viagem possa ser cadastrado, é necessario ter pelo menos um veiculo cadastrado.


VIAGEM > CIDADE ORIGEM

Para que uma viagem possa ser cadastrado, é necessario ter pelo menos um cidade cadastrada.

VIAGEM > CIDADE DESTINO

Para que uma viagem possa ser cadastrado, é necessario ter pelo menos um cidade cadastrada.

