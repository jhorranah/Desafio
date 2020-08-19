@Formulário
Funcionalidade: formulario
	a fim de cadastrar um formulário padrão
	eu como usuário
	gostaria de cadastrar um formulário

Contexto: Autenticação Válida
	Dado que eu esteja na tela de autenticação
	Quando eu preencher os campos de usuário e senha
		| Email           | Senha     |
		| admin@admin.com | Senha1234 |
	E clicar no botão para entrar
	Então o sistema deverá apresentar a próxima tela

Esquema do Cenário: Cadastro de formulário
	Dado que eu esteja na tela de cadastro de formulário
	E clicar em cadastrar
	E preencher a tabela de Informações Principais "<Nome>"
	E preencher a tabela Palavras Chave "<Palavra>"
	E Vincular Catalogos "<Catalogos>"
	E classisficar catalogos "<Nivel1>"
	E Adicionar Fila "<Atendimento>"
	E Selecionar SLA "<SLA>"
	E Selecionar o calendário "<Calendario>"
	E clicar em gravar
	Então o sistema deverá mostrar a mensagem de "Formulário cadastrado com sucesso."
	E apresentar o formulario cadastrado
	
	Exemplos: 
	| Nome        | Palavra             | Catalogos		 | Nivel1	   | Atendimento		  | SLA			 | Calendario                              |
	| Teste Joana | Teste Palavra Chave | Catalogo Joana | Bugs		   | Financ - Demais Aten | 19 - AUT SLA | Atendimento Padrão com finais de semana | 

