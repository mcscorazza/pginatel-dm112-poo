## Exercício de Avaliação - Sistema Pedidos de um E-commerce
### Cenário
Você foi contratado para desenvolver um sistema de gerenciamento de pedidos para um e-commerce. O sistema deve permitir a criação de pedidos, o cálculo do total da compra e a geração de faturas.
Para isso, siga as diretrizes abaixo:
- Crie uma estrutura de classes bem organizada usando os princípios de Orientação a Objetos (OO).
- Aplique os princípios SOLID na implementação das classes.
 
### Requisitos
- O sistema deve permitir adicionar um ou mais produtos a um pedido.
- Cada produto tem um nome, preço e uma categoria.
- O pedido deve calcular o valor total da compra.
- O sistema deve suportar diferentes formas de pagamento (Cartão de Crédito, Pix).
- Ao finalizar um pedido, uma fatura deve ser gerada.

### Dicas de implementação
- Separe bem as responsabilidades de cada parte do sistema. Crie quantas classes achar necessário. (SRP)
- Crie o módulo de pagamento de forma a adicionar novos métodos sem alterar o já implementado (OCP)
- Utilize uma abstração nas formas de pagamento e que qualquer forma seja capaz de substituir esta abstração. (LSP)
- Cuidado para não criar Abstrações com múltiplas responsabilidades. (ISP)
- Faça com que pedidos dependa de uma forma abstrata de pagamento (DIP)

### Critérios de Avaliação
- Aplicação correta dos conceitos de Encapsulamento, Herança e Polimorfismo.
- Aplicação dos princípios SOLID, garantindo código modular e extensível.
- Clareza e organização do código.
- Uso adequado de interfaces e abstrações.
 
### Informações Adicionais
- Trabalho pode ser feito em duplas
- Deverá ser entregue em um repositório no Github/Gitlab (FAVOR DEIXAR O ACESSO PÚBLICO)
- O PROJETO DEVE PELO MENOS COMPILAR! Caso contrário não há como avaliar.

#### Data de entrega: 16/03.
 