# IDED_Scripting_P3_base

Abraham Peláez Trujillo y Juan Pablo Aranfo Zuleta

El patrón State ofrece beneficios de organización pero también puede aumentar la complejidad del código.
La implementación del patrón State implica la creación de múltiples clases de estado y transiciones entre ellas. Esto puede aumentar la complejidad del código y requerir más tiempo y esfuerzo, además Implementar el State con sus multiples clases de estado puede dificultar el seguimiento de todas ellas y puede aumentar la sobrecarga de mantenimiento y por consiguiente la gestión de múltiples estados y transiciones puede tener un impacto en el rendimiento, especialmente en sistemas con recursos limitados.

No se pudo implementar por falta de tiempo pero una idea que tendríamos para implementar el State seria:

Primero se Definiríamos una interfaz “IState” que incluye métodos como Enter, Update y Exit para cada estado, luego crearíamos una clase base abstracta StateBase que implementa la interfaz IState. Crearíamos clases derivadas para cada estado del juego, como WaitingState, ShotFiredState, CalculatingScoreState, etc. Estas clases deben implementar los métodos de la interfaz IState. 
En el RefactoredGameController, mantener una referencia al estado actual y llama a los métodos Enter, Update y Exit del estado actual y por ultimo Utilizariamos eventos o métodos de cambio de estado para cambiar entre los diferentes estados en respuesta a eventos del juego.
