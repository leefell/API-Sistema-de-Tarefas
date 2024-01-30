# API Sistema de Tarefas

Esta é uma API CRUD básica para gerenciamento de tarefas, usuários e consulta de CEP, desenvolvida para praticar habilidades de desenvolvimento de APIs.

## Endpoints

### Tarefa

#### `GET /api/Tarefa`

Retorna uma lista de todas as tarefas.

#### `POST /api/Tarefa`

Cria uma nova tarefa.

#### `GET /api/Tarefa/{id}`

Retorna os detalhes de uma tarefa específica com o ID fornecido.

#### `PUT /api/Tarefa/{id}`

Atualiza os detalhes de uma tarefa específica com o ID fornecido.

#### `DELETE /api/Tarefa/{id}`

Exclui uma tarefa específica com o ID fornecido.

### Usuário

#### `GET /api/Usuario`

Retorna uma lista de todos os usuários.

#### `POST /api/Usuario`

Cria um novo usuário.

#### `GET /api/Usuario/{id}`

Retorna os detalhes de um usuário específico com o ID fornecido.

#### `PUT /api/Usuario/{id}`

Atualiza os detalhes de um usuário específico com o ID fornecido.

#### `DELETE /api/Usuario/{id}`

Exclui um usuário específico com o ID fornecido.

### Consulta de CEP

#### `GET /api/Cep/{cep}`

Retorna os detalhes de um endereço correspondente ao CEP fornecido.

## Como Usar

Este projeto foi desenvolvido com o objetivo de praticar habilidades de desenvolvimento de APIs e não está hospedado em nenhum lugar. Portanto, para utilizá-lo, será necessário clonar o repositório e executá-lo localmente.
Ao executar o projeto, ele abrirá no Swagger UI, uma interface interativa que permite testar os endpoints da API diretamente do navegador.

1. **Executando a API**: Após clonar o repositório, execute o projeto e navegue até o Swagger UI para testar os endpoints.

2. **Testando os Endpoints**: No Swagger UI, você encontrará todos os endpoints listados acima, incluindo o novo endpoint para consulta de CEP. Você pode clicar em cada endpoint para expandir e ver os detalhes, e em seguida, clicar em "Try it out" para testar o endpoint com diferentes parâmetros.

3. **Contribuindo**: Se você deseja contribuir para o projeto, sinta-se à vontade para abrir uma issue ou enviar uma pull request. Este projeto é destinado a práticas de desenvolvimento e aprendizado, e contribuições são bem-vindas!

