# ImportaDados
Projeto simples feito com WindowsForm para importar dados de arquivos JSON para banco de dados MySQL.

### Sobre o projeto.
O projeto foi escrito com C# e MySQL. A aplicação foi desenhada para ler arquivos em lote, uma vez definido o local da pasta que contém arquivos JSON a aplicação vai ler e gravar todos em lote.

---
### Sobre o banco de dados utilizado.
Foi utilizado o MySQL como banco de dados, no meu caso usei o xampp para rodar um servidor local na minha maquina.
Rodar o script de criação do banco de dados para inicializar o banco.
O banco é um banco simples com apenas uma tabela, para evitar possíveis complicações, como os dados não são manipulados de nenhuma forma eles foram definidos como VARCHAR.
    
    o nome do banco é `passagemdb` com a tabela `passagem`
    A tabela passagem contém os seguintes atributos:
    
      "placa" VARCHAR(32) - esse atributo está configurado como chave primaria.
      
      "data" VARCHAR(32)
      
      "hora" VARCHAR(32)
      
      "equipamento" VARCHAR(32)
      
      "faixa" VARCHAR(32)
      
---

### Como a plicação se comporta
1. Usar o botão 'Diretório' para selecionar o caminho da pasta que contém os arquivos JSON.
2. Após definido o caminho, usar o botão 'Importar Dados' para importar os dados dos arquivos JSON e salva-los no banco de dados.
3. Usar o botão 'Listar' para exibir os dados salvos no banco de dados no GridView da aplicação.

Como o atributo `placa` está definido como chave primária no BD, a aplicação não vai aceitar salvar dados que contenham a mesma `placa`, não aceita arquivos duplicados e vai exibir mensagem de erro.
