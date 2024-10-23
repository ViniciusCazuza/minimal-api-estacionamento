
# Sistema de Gerenciamento de Estacionamento

Esta API foi desenvolvida utilizando o padrão Minimal API com ASP.NET Core, permitindo a gestão de veículos e autenticação de administradores.

## Funcionalidades

- Registro e autenticação de administradores.
- CRUD (Create, Read, Update, Delete) para veículos.
- Geração de token JWT para autenticação.
- Documentação interativa da API via Swagger.

## URL da API

Acesse a API pelo seguinte endereço:

```
http://18.224.23.36
```

## Documentação Swagger

A documentação da API pode ser acessada em:

```
http://18.224.23.36/swagger/index.html
```

## Endpoints

### 1. Login do Administrador

Para autenticar um administrador e obter um token JWT, utilize o seguinte endpoint:

- **URL:** `/administradores/login`
- **Método:** `POST`
- **Headers:**
  - `Content-Type: application/json`
  - `accept: */*`
  
- **Corpo da Requisição:**
```json
{
  "email": "admin@test.com",
  "senha": "adm"
}
```

### 2. CRUD de Veículos

#### Criar Veículo

- **URL:** `/veiculos`
- **Método:** `POST`
- **Headers:** 
  - `Authorization: Bearer {token}`
  - `Content-Type: application/json`

- **Corpo da Requisição:**
```json
{
  "nome": "Modelo do Veículo",
  "marca": "Marca do Veículo",
  "ano": 2023
}
```

#### Listar Veículos

- **URL:** `/veiculos`
- **Método:** `GET`
- **Headers:** 
  - `Authorization: Bearer {token}`

#### Obter Veículo por ID

- **URL:** `/veiculos/{id}`
- **Método:** `GET`
- **Headers:** 
  - `Authorization: Bearer {token}`

#### Atualizar Veículo

- **URL:** `/veiculos/{id}`
- **Método:** `PUT`
- **Headers:** 
  - `Authorization: Bearer {token}`
  - `Content-Type: application/json`

- **Corpo da Requisição:**
```json
{
  "nome": "Modelo Atualizado",
  "marca": "Marca Atualizada",
  "ano": 2023
}
```

#### Deletar Veículo

- **URL:** `/veiculos/{id}`
- **Método:** `DELETE`
- **Headers:** 
  - `Authorization: Bearer {token}`

## Considerações Finais

Para garantir o funcionamento adequado da API, verifique se todas as dependências estão instaladas e que o banco de dados está corretamente configurado. A API foi projetada para ser simples e direta, proporcionando uma interface amigável para gerenciamento de veículos.

---
