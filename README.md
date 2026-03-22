# Gerador de Chave NFe (Estudo de Integração) 📄⛓️

> **Nota de Contexto:** Este projeto é um registro histórico da minha jornada. Ele foi desenvolvido como um exercício prático **antes de eu ingressar na faculdade**, com o objetivo de entender, pela primeira vez, como consumir a API da SEFAZ e lidar com regras de negócio reais.

---

## 📸 Demonstração do Sistema

![1678667911164](https://user-images.githubusercontent.com/46034451/224584570-e680dc5e-2467-4928-8f71-d84232635638.jpg)

---

## ✨ O Desafio

O objetivo principal aqui foi desbravar a lógica por trás da geração de chaves para Notas Fiscais Eletrônicas (NFe). Na época, meu foco era entender como "conversar" com serviços externos (APIs) e como estruturar o fluxo de dados entre diferentes telas e componentes.

Hoje, olhando com a experiência que tenho, vejo este código como um **laboratório inicial**. Ele não segue os padrões de segurança que utilizo atualmente em projetos profissionais, mas foi o pilar que me ensinou a ler documentações técnicas complexas e a persistir dados de forma organizada.

---

## 🚀 O que o programa faz?

O fluxo foi dividido em etapas para facilitar o entendimento:

1.  **Captura de Dados:** Coleta as informações necessárias para a nota.
2.  **Persistência Dupla:** Salva os registros em um arquivo de texto (Notepad) para log rápido e, simultaneamente, no banco de dados **MySQL**.
3.  **Geração de Chave:** Na 4ª tela do sistema, o programa processa as informações e gera a chave numérica da NFe seguindo os padrões exigidos.

---

## 🛠️ Tecnologias Utilizadas

* **C# (#csharp):** Linguagem principal para construção da interface e lógica.
* **MySQL (#mysql):** Gerenciamento de banco de dados.
* **API SEFAZ:** Consumo de serviços governamentais para validação e lógica de impostos.
* **Manipulação de Arquivos:** Persistência simples em .txt para fins de estudo.

---

## 📈 Evolução Pessoal

Este repositório serve para mostrar de onde vim. Ele representa o momento em que saí da teoria e fui tentar resolver problemas do mundo real. 

Atualmente, meus projetos seguem padrões de **Clean Code, Arquitetura em Camadas e Segurança Avançada**, mas guardo este aqui com orgulho, pois foi onde aprendi a "abrir a caixa preta" das integrações sistêmicas.
