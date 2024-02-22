## Descrição do Projeto

As Funcionalidades devem realizar operações de CRUD (Create, Read, Update, Delete) completo para os recursos "Produto" e "Marca". 

## Funcionalidades

## Cadastro de marcas

1. A "Marca" deve conter os seguintes atributos:  Marca(Id, Descrição,Status).
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

1. Implemente um endpoint no recurso "catalogo" para obter as imagens do produto em uma api de banco de imagens consultando pelo codigo de barras.
   
``` html
   GET /api/catalogo/{ean}/imagens: obtem as imagens do produto relacionados ao codigo de barras informado.
```

2. Consuma a API de catalogo de produtos
   
``` html
    https://catalogoautomatiza.azurewebsites.net/api/produtos/{ean} : obtem os dados do produto relacionados.
```

Produtos de exemplo cadastrado na base de dados

```
Protetor Solar Nivea Sun Toque Seco FPS70 + Creme Facial Antissinais
4006000028187

Fraldas Huggies Supreme Care Jumbo Tamanho Rn - 18 Uni
7896007549627

Aparelho de Barbear Gillette Mach3 Acqua-Grip Sensitive + 1 Carga
7500435141529

Álcool em Gel 70% Farmax - 50g
7896902205260

Salgadinho Torcida - Sabor Cebola 38g
7892840820275

Elma Chips Ovinhos de Amendoim - 170g
7892840814779

Ruffles Original - 92g
7892840816728

Barra de Chocolate Ovomaltine - Hershey's
7899970402876

Barra de Chocolate Talento Recheado Torta de Limão - 85g
7891008114539

Whey Fort 3W Baunilha - 900g
7898665433720

Pilha Panasonic Alcalina xom 4 Unidades - AA
7896067200032

Energético Monster Jm Khaos Lata - 473ml
0070847022022
```
