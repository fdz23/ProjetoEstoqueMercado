#language: pt-BR

Funcionalidade: Cadastro de produtos e categorias
Como usuário do sistema
Posso cadastrar uma categoria
Posso cadastrar produtos para cada categoria

@cadastro

Cenario: Cadastrar uma categoria com sucesso
Dado um nome de categoria
Quando preencher seu nome corretamente
E clico em adicionar categoria
Então a categoria deverá existir no banco de dados

Cenario: Cadastrar uma categoria sem sucesso
Dado um nome de categoria ja existente
Quando preencher seu nome corretamente
E clico em adicionar categoria
Então devo receber uma mensagem de erro

Cenario: Cadastrar um produto com sucesso
Dado um produto
Quando preencher seus dados corretamente
E clico em adicionar produto
Então o produto deverá existir no banco de dados

Cenario: Cadastrar um produto sem sucesso
Dado um produto
Quando deixar de preencher algum dado
E clico em adicionar produto
Então devo receber uma mensagem de erro
