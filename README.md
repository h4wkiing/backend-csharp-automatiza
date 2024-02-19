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

- O candidato tem liberdade para escolher a estrutura do projeto, frameworks e bibliotecas adicionais que julgar adequados para a realização da prova.
- É importante seguir as boas práticas de desenvolvimento e manter um código limpo e legível.
- Inclua no arquivo explicativo em Markdown informações sobre como executar o projeto, incluindo a configuração dos bancos de dados.

## Descrição do Projeto

Implementar uma API em C#. A API deve oferecer um CRUD completo persistindo no Bancos de Dados, conter regras de validação e campos calculados.

## Requisitos Técnicos

- Linguagem de Programação: C#
- Desenvolvimento Backend Asp.Net .Net 7 ou superior
- Bancos de Dados MySql ou PostgreSQL
- Padrões de Projeto
- Princípios do SOLID

## Tarefas

1. Implemente uma API em C# que realize operações de CRUD (Create, Read, Update, Delete) completo para um recurso chamado "Produto".
2. O "Produto" deve conter os seguintes atributos: Id (Chave), Descrição, Preço de Venda, Estoque, e Data de Criação. Os endpoints esperados são:

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

5. Adicione um campo calculado ao produto chamado "Valor Total" que represente o valor total do produto em estoque (Preço x Quantidade em Estoque). Esse campo deve ser retornado na consulta de detalhes do produto.


## Critérios de Avaliação

- API implementada, completa e rodando.
- Implementação correta e funcional da API com todas as operações CRUD.
- Correta aplicação da regra de validação para o atributo "Descrição".
- Correta aplicação da regra de validação para o atributo "Preço de venda".
- Correta aplicação da regra de validação para o atributo "Estoque".
- Cálculo correto do campo "Valor Total".
- Implementação da persistência dos dados.
- Organização e clareza do código.



Bom teste e sucesso no desafio! Em caso de dúvidas, entre em contato pelo e-mail fabricio@automatizasitemas.com.br.
