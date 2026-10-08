# Sobre o Projeto
É um projeto feito por membros do PET Computação da UFRGS para aprender na prática sobre Machine Learning especificamente
para estudar e aplicar o método de Q-learning de forma lúdica para fins demonstrativos.

# O jogo
## Objetivo
A ideia do jogo é simples: barris e bananas caem do céu, e o objetivo do jogador é tentar sobreviver o máximo de tempo possível, 
desviando dos barris e coletando as bananas para ganhar pontos.
## Mecânicas
O jogador só poderá se mover horizontalmente. Os objetos surgem a partir de cinco spawners localizados logo acima da frame, então
eles caem em colunas e desaparecem ao baterem no chão ou no jogador.

# O agente de IA
## Q-Learning
O agente será treinado usando o Q-learning, que é uma forma de aprendizado por reforço. Esse método tem como base recompensas e punições.
Cada ação feita pelo agente será recompensada ou punida e ela guarda o quão bom ou ruim é realizar aquela ação no chamado Q-table.
A decisão do agente é tomada com base em uma fórmula que analisa o estado atual da IA, as possíveis ações que ela pode tomar, a possível situação futura em que o agente estaria se as executasse, o quanto ele aprecia as recompensas e uma taxa de curiosidade para encorajar o agente a tomar decisões diferentes.
## Recompensas e punições
O agente será recompensado de duas formas: por coletar bananas e por tempo sobrevivido
## Outras restrições
O agente só consegue analisar o que está visível na tela, mesmo que os objetos existam antes de aparecerem na tela.
