# Desafio Técnico - Desenvolvedor de Software Backend C# - Automatiza Sistemas

## Instruções

O teste consiste na implementação de uma API em C# conforme os requisitos e critérios estabelecidos abaixo:

- Faça um fork privado deste repositório e adicionar o usuário "fabricio@automatizasitemas.com.br" como colaborador.
- Utilize o formato Markdown para descrever todas as informações relevantes para o projeto.
- O candidato deve realizar as tarefas descritas no teste e garantir que o repositório contenha o código-fonte completo, juntamente com um arquivo explicativo em Markdown descrevendo as soluções adotadas.
- O candidato tem um prazo de 7 dias para finalizar o projeto.

Ao concluir, o candidato deve enviar um e-mail para fabricio@automatizasitemas.com.br com o assunto "Vaga Backend - [NOME]", informando que finalizou o teste.

Todas as alterações feitas após o envio do e-mail serão desconsideradas.

Certifique-se de seguir as instruções detalhadamente e boa sorte!

## Observações

- O candidato tem liberdade para escolher a estrutura do projeto e bibliotecas adicionais que julgar adequados para a realização do teste.
- É importante seguir as boas práticas de desenvolvimento e manter um código limpo e legível.
- Inclua no arquivo explicativo em Markdown informações sobre como executar o projeto, incluindo a configuração dos bancos de dados.

## Descrição do Projeto

As Funcionalidades devem realizar operações de CRUD (Create, Read, Update, Delete) completo para os recursos "Produto" e "Marca". 

## Funcionalidades

## Cadastro de marcas

1. A "Marca" deve conter os seguintes atributos:  Marca(Id (Chave), Descrição,Status).
2. Os endpoints esperados são:
   
``` html
   POST /api/marcas: cadastrar uma nova marca.
   GET /api/marcas: listar todas as marcas.
   GET /api/marcas/{id}: Retorna os detalhes de uma marca específica pelo id.
   PUT /api/marcas/{id}: Atualiza os dados de uma marca existente.
   DELETE /api/marcas/{id}: Remove uma marca do sistema.
```

3. Implemente uma regra de validação para o atributo "Descrição". A descrição deve conter mais de 3 e menos 100 caracteres, o sistema deve retornar uma mensagem de erro apropriada em caso de tentativa de criação ou atualização de um produto com descrição inválida.

4. O registro da marca não deve ser removido do banco de dados, o Status deve ser alterado para 'REMOVIDO'.
 
## Cadastro de Produtos

1. O "Produto" deve conter os seguintes atributos: Produto (Id, Descrição, Preço de Venda, MarcaId , Estoque, Status).
2. Os endpoints esperados são:

``` html
   POST /api/produtos: cadastrar um novo produto.
   GET /api/produtos: listar todos os produtos.
   GET /api/produtos/{id}: Retorna os detalhes de um produto específico pelo id.
   PUT /api/produtos/{id}: Atualiza os dados de um produto existente.
   DELETE /api/produtos/{id}: Remove um produto do sistema.
```

3. Implemente uma regra de validação para o atributo "Descrição" do produto. A descrição deve conter mais de 3 e menos 300 caracteres, o sistema deve retornar uma mensagem de erro apropriada em caso de tentativa de criação ou atualização de um produto com descrição inválida.

3. Implemente uma regra de validação para o atributo "Preço de Venda" do produto. O preço não pode ser negativo, e o sistema deve retornar uma mensagem de erro apropriada em caso de tentativa de criação ou atualização de um produto com preço inválido.

4. Implemente uma regra de validação para o atributo "Estoque" do produto. O estoque não pode ser negativo, e o sistema deve retornar uma mensagem de erro apropriada em caso de tentativa de criação ou atualização de um produto com estoque inválido.

5. Adicione um campo calculado ao produto chamado "ValorTotalEstoque " que represente o valor total do produto em estoque (Preço de venda x Quantidade em Estoque). Esse campo deve ser retornado na consulta de detalhes do produto.
 
6. O registro do produto não deve ser removido do banco de dados, o Status deve ser alterado para 'REMOVIDO'.
   
## Consulta das imagens produto no banco de imagens

1. Implemente um endpint no recurso "catalogo" para obter as imagens do produto em uma api de banco de imagens consultando pelo codigo de barras.
   
``` html
   GET /api/catalogo/{ean}/imagens: obtem as imagens do produto relacionados ao codigo de barras informado.
```

2. Consuma a API de catalogo de de produtos
   
``` html
    https://catalogofake.com/api/catalogo/{ean}: obtem os dados do produto relacionados.
```

## Critérios de Avaliação

- API implementada, completa e rodando.
- Implementação correta e funcional da API com todas as operações CRUD.
- Implementação correta das validações.
- Implementação da persistência dos dados.
- Organização e clareza do código.

## Requisitos Técnicos

- Linguagem de Programação: C#
- Desenvolvimento Backend Asp.Net .Net 7 ou superior
- Entity Framework Core
- Bancos de Dados MySql ou PostgreSQL
- Padrões de Projeto
- Princípios do SOLID
  
# Material de referência.

Tutorial: criar uma API Web com o ASP.NET Core
https://learn.microsoft.com/pt-br/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio


Bom teste e sucesso no desafio! Em caso de dúvidas, entre em contato pelo Discord.
