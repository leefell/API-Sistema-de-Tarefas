# API Sistema de Tarefas

Esta é uma API CRUD básica para gerenciamento de tarefas e usuários, o objetivo desse projeto é exercitar meus conhecimentos.

## Endpoints

## Tarefa

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

## Usuário

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

## Como Usar

Para usar esta API, siga estas etapas:

1. **Instalação**: Clone o repositório e execute as dependências necessárias.

2. **Connection String**: Configure a string de conexão com o banco de dados no arquivo `appsettings.json` ou outro arquivo de configuração apropriado.

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "sua-string-de-conexao-aqui"
      }
    }
    ```

3. **Endpoints**: Acesse os endpoints conforme descrito acima para interagir com as tarefas e usuários.

4. **Contribuindo**: Se você deseja contribuir para o projeto, siga as diretrizes de contribuição descritas no README.

## Contribuindo

Sinta-se à vontade para contribuir para este projeto! Se você encontrar problemas ou tiver sugestões de melhorias, abra uma issue ou envie uma pull request. Certifique-se de seguir as diretrizes de contribuição.
