@Nível
Funcionalidade: CadastroNível
	A fim de cadastrar a classificação de formulário
	eu como administrador
	gostaria de cadastrar uma classificação de formulário

Contexto: Autenticação Válida
	Dado que eu esteja na tela de autenticação
	Quando eu preencher os campos de usuário e senha
		| Email           | Senha     |
		| admin@admin.com | Senha1234 |
	E clicar no botão para entrar
	Então o sistema deverá apresentar a próxima tela

Esquema do Cenario: Cadastro de classificação de formulário
	Dado que eu esteja na tela de cadastro de Classificação
	Quando eu clicar no botão cadastrar
	E selecionar o nível <Nivel>
		| nivel1        | nivel2        | nivel3        | nivel4        | nivel5        | 
		| Teste Joana 1 | Teste Joana 2 | Teste Joana 3 | Teste Joana 4 | Teste Joana 5 |
	E preencher o campo Nível "<Nome>"
	E clicar em adicionar nível
	E clicar em gravar
	Então o sistema deverá apresentar "Classificação cadastrada com sucesso."
	

	Exemplos:
		| Nivel | Nome          |
		| 1     | Teste Joana 1 |
		| 2     | Teste Joana 2 |
		| 3     | Teste Joana 3 |
		| 4     | Teste Joana 4 |
		| 5     | Teste Joana 5 |
		| 6     | Teste Joana 6 |