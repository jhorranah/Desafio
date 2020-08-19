@Autenticacao
Funcionalidade: Autenticacao
	A fim de acessar o sistema Tessera
	Como um usuário
	Eu gostaria de realizar a autenticação no sistema


Cenario: Autenticação Válida
	Dado que eu esteja na tela de autenticação
	Quando eu preencher os campos de usuário e senha
		| Email           | Senha     |
		| admin@admin.com | Senha1234 |
	E clicar no botão para entrar
	Então o sistema deverá apresentar a próxima tela

Esquema do Cenario: Autenticação inválida
	Dado que eu esteja na tela de autenticação
	Quando eu preencher o campo de usuário com <usuario>
	E eu preencher o campo de senha com <senha>
	E clicar no botão para entrar
	Então o sistema deverá apresentar a mensagem de <mensagem>

	Exemplos:
	| usuario     | senha     | mensagem                                  |
	| hello@hello | Senha1234 | Os campos marcados com * são obrigatórios |
	|             |           | Os campos marcados com * são obrigatórios |
	|             | Senha1234 | Os campos marcados com * são obrigatórios |
	| sasasa      | 12354     | Os campos marcados com * são obrigatórios |