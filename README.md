# PatternStrategy
## implementando o padrão de projeto "pattern strategy"

## Quando devemos aplicar Strategy?

O padrão Strategy é muito útil quando temos um conjunto de algoritmos similares, e precisamos alternar entre eles em diferentes pedaços da aplicação. No exemplo do vídeo, temos diferentes maneira de calcular o imposto, e precisamos alternar entre elas.

O Strategy nos oferece uma maneira flexível para escrever diversos algoritmos diferentes, e de passar esses algoritmos para classes clientes que precisam deles. Esses clientes desconhecem qual é o algoritmo "real" que está sendo executado, e apenas manda o algoritmo rodar. Isso faz com que o código da classe cliente fique bastante desacoplado das implementações concretas de algoritmos, possibilitando assim com que esse cliente consiga trabalhar com N diferentes algoritmos sem precisar alterar o seu código.

###

Nesse reposito dividi as atividades em 2 breanchs:

Master > implementando exemplopassado no curso e 1 exercicio criando  um novo tipo de imposto
Exe2 > implementei segundo exercio passado no curso aonde tinha que criar uma estratégias para investimentos.
