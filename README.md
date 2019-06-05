# SisLog

# Trabalho Acadêmico - Projeto e Desenvolvimento de um Sistema para Controle de frotas.


# Atenção

Conforme o proposto em sala de aula, foi implementado somente as funcionalidades abaixo:
- Cadastro de Usuários
- Cadastro de Motorista
- Entrada e saída de viagens/veículos


# Desenvolvedores:

WAGNER RODRIGUES NEVES

JONATHAS TOLEDO PEREIRA

PALUAN BATISTA DA SILVA

MARCOS ROBERTO LOPES

IGOR HENRIQUE DA SILVA

MARCIO BRENO BERNARDI BARBARO


# INSTALAÇÃO DO SOFTWARE:

1 - Acessar a Pasta ControleFrotas.

2 - Executar o arquivo PimSql.sql no MySql Workbench. Selecionar todas as linhas e executar. O banco estará criado e pronto apara utilização.

3 - Adequar o banco de dados com o usuario: root e senha: root, para ficar de acordo com o configurado no programa.

4 - Executar o software pelo executável PimFrota.exe

5 - Informar usuário e senha padrão:

Usuário padrão: admin

Senha padrão: admin

Obs: Caso ocorra o erro abaixo ao compilar, basta recompilar o projeto, este bug se da a um problema no Visual Studio, onde já estamos buscando a solução permanente.

Error: Files has invalid value "<<<<<<< HEAD". Illegal characters in path.


# REQUISITOS PARA A INSTALAÇÃO DO SOFTWARE:
Windows 7, 8 ou 10 como sistema operacional.

Mysql workbench como sgbd.

# UTILIZAÇÃO DO SOFTWARE:

Dependências

Algumas rotinas possuem dependências relacionadas umas as outras, ou seja, algumas dependem de outras para existir através de um relacionamento, como por exemplo: para que um viagem possa ser cadastrada, ele deve ter cadastrado um motorista, um veiculo e cidades.

Dependências existentes

VIAGEM > MOTORISTA

Para que uma viagem possa ser cadastrado, é necessário ter pelo menos um motorista cadastrado.

VIAGEM > VEICULO

Para que uma viagem possa ser cadastrado, é necessário ter pelo menos um veiculo cadastrado.

VIAGEM > CIDADE ORIGEM

Para que uma viagem possa ser cadastrado, é necessário ter pelo menos um cidade cadastrada.

VIAGEM > CIDADE DESTINO

Para que uma viagem possa ser cadastrado, é necessário ter pelo menos um cidade cadastrada.
