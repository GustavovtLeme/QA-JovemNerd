#language: pt

Funcionalidade: Acesso ao Nerdcast

Cenário: Acesso ao nerdcast 251
	Dado Acessar a pagina "Http://www.jovemnerd.com.br"
	E clicar em Nerdcast
	E selecionar a pesquisa do nerdcast com a palavra "RPG"
	E clicar no Nerdcast 251
	E iniciar o nerdcast
	E pausar o nerdcast
	Entao encerrar navegador e gerar PDF do que foi acessado