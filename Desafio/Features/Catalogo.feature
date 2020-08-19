@Catalogo
Funcionalidade: Cadastrar Catalogo
	A fim de realizar categorizações de formulário de atendimento
	eu como administrador 
	gostaria de cadastrar catálogos


Contexto: Autenticação Válida
	Dado que eu esteja na tela de autenticação
	Quando eu preencher os campos de usuário e senha
		| Email           | Senha     |
		| admin@admin.com | Senha1234 |
	E clicar no botão para entrar
	Então o sistema deverá apresentar a próxima tela

Cenario: Cadastro de catálogo
	Dado que eu esteja na tela de cadastro de catálogo
	Quando eu clicar em cadastrar
	E preencher os campos Nome do Catalogo e Descrição
	| Nome           | Descricao				|
	| Catalogo Joana | Descrição Catalogo Joana |
	E Selecionar um formulário
	| Formulário                    |
	| Reembolso com Viagens         |
	| Abertura de chamado técnico   |
	| Erros internos no sistema SAP |
	E clicar no botão gravar
	Então o sistema deverá apresentar a mensagem "Catálogo cadastrado com sucesso."
	E mostrar o catalogo adicionado na listagem
