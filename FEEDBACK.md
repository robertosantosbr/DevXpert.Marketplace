# Feedback - Avaliação Geral

## Front End

### Navegação
  * Pontos positivos:
    - Projeto MVC (`DevXpert.Marketplace.WebApp`) presente, com configuração básica e estrutura inicial implementada.

  * Pontos negativos:
    - O projeto MVC não contém controllers para as entidades principais (Produto, Categoria, etc.).
    - Navegação e views para funcionalidades principais não foram implementadas.

### Design
  - Não aplicável para avaliação, pois o projeto MVC está incompleto e sem interface funcional disponível.

### Funcionalidade
  * Pontos positivos:
    - Modelagem de entidades do domínio está bem definida.

  * Pontos negativos:
    - A API (`DevXpert.Marketplace.WebAPI`) contém apenas um controller implementado no estilo minimal API, com endpoints incompletos.
    - Falta de implementação do registro do vendedor junto com o usuário do Identity (sem compartilhamento de ID).
    - Cadastro de usuário via API não está disponível.
    - Não há validação para impedir que um vendedor altere produtos de outro.
    - Ausência de seed de dados, migrations automáticas e configuração do SQLite.

## Back End

### Arquitetura
  * Pontos positivos:
    - Projeto estruturado com separação de responsabilidades entre Application, Domain, Infrastructure e WebAPI.

  * Pontos negativos:
    - A separação em quatro camadas é excessiva para o nível de complexidade do projeto, o que viola o princípio da simplicidade proposto no desafio.
    - Falta integração básica entre camadas e ausência de lógica consolidada nos fluxos principais.
    - A autenticação foi implementada incorretamente via Azure AD, o que foge do escopo proposto com ASP.NET Identity local.

### Funcionalidade

  * Pontos negativos:
    - Falta de funcionalidade central: CRUDs incompletos, ausência de segurança de domínio (validação de vendedor), e sem autenticação local conforme escopo.

### Modelagem
  * Pontos positivos:
    - Entidades estruturadas conforme especificado

## Projeto

### Organização
  * Pontos positivos:
    - Projeto organizado em múltiplos projetos separados dentro da pasta `DevXpert.Marketplace`.
    - Uso de arquivos `.sln`, pastas e estrutura modular bem definida.

  * Pontos negativos:
    - Excesso de complexidade e ausência de elementos essenciais como seed, autenticação local e CRUDs no MVC.
    - Projeto incompleto nos principais pontos exigidos.

### Documentação
  * Pontos positivos:
    - `README.md` presente com informações básicas.

  * Pontos negativos:
    - Falta detalhamento sobre execução, dependências, e arquitetura real implementada.

### Instalação
  * Pontos positivos:
    - Estrutura do projeto pronta para extensão.

  * Pontos negativos:
    - Ausência de implementação de SQLite, migrations automáticas e seed de dados inviabiliza a execução do projeto conforme esperado.

---

# 📊 Matriz de Avaliação de Projetos

| **Critério**                   | **Peso** | **Nota** | **Resultado Ponderado**                  |
|-------------------------------|----------|----------|------------------------------------------|
| **Funcionalidade**            | 30%      | 3        | 0,9                                      |
| **Qualidade do Código**       | 20%      | 7        | 1,4                                      |
| **Eficiência e Desempenho**   | 20%      | 3        | 0,6                                      |
| **Inovação e Diferenciais**   | 10%      | 5        | 0,5                                      |
| **Documentação e Organização**| 10%      | 6        | 0,6                                      |
| **Resolução de Feedbacks**    | 10%      | 0        | 0,0                                      |
| **Total**                     | 100%     | -        | **4,0**                                  |

## 🎯 **Nota Final: 4 / 10**
