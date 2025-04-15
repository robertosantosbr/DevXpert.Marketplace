# Feedback - Avaliação Geral

## Front End
### Navegação
  * Pontos positivos:
    - Views e rotas definidas para funcionalidades básicas (ex: HomeController com ações como Index, Privacy, Error).

  * Pontos negativos:
    - Ausência de rotas e views específicas para entidades críticas como "Vendedor" ou integrações completas com o Identity.

### Design
    - Será avaliado na entrega final

### Funcionalidade
  * Pontos positivos:
    - Implementação básica de autenticação via Identity (login/registro).

  * Pontos negativos:
    - Falta de funcionalidades essenciais como CRUD para entidades (ex: "Vendedor") e integração completa com o back-end.

## Back End
### Arquitetura
  * Pontos positivos:
    - Separação em projetos (API, Application, Domain, Infrastructure) com responsabilidades claras.
    - Uso do Entity Framework Core com SQLite.

  * Pontos negativos:
    - Arquitetura excessivamente dividida (5 camadas), indo além do necessário para um CRUD básico.
    - Uso de padrões como MediatR e CQRS (Handlers/Queries), considerado complexo para o escopo proposto.
    - Deixar o arsenal técnico para desafios que exigem complexidade, errar na complexidade de uma solução é erro grave!

### Funcionalidade
  * Pontos positivos:
    - Migrações do EF Core implementadas.

  * Pontos negativos:
    - Ausência de endpoints para operações CRUD na entidade "Vendedor".
    - Integração incompleta entre Identity e entidades de domínio (ex: Seller não vinculado ao usuário).

### Modelagem
  * Pontos positivos:
    - Modelagem das entidades de negócio


## Projeto
### Organização
  *Pontos negativos:
    - Presença de arquivos binários (ex: `.vs/`) no repositório.
    - Estrutura não organizada na pasta `src` com `.sln` na raiz.

### Documentação
  * Pontos positivos:
    - README.md com instruções básicas de execução.
    - Swagger implementado na API.
    - FEEDBACK.md presente.

  * Pontos negativos:
    - Documentação incompleta (ex: falta de detalhes sobre funcionalidades, diagramas ou requisitos atendidos).

### Instalação

  * Pontos negativos:
    - Seed não popula dados essenciais para teste (ex: usuários ou sellers).
    - SQLite não configurado com migrações automáticas.