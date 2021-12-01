# LITG-TechnicalTest

![image](https://user-images.githubusercontent.com/20799388/144147048-c5d688ef-5821-4f97-8c48-9957b13b885a.png)

# Descripción

## Escena 1

El proyecto consta de 2 escenas en donde, en la primera, se encontrará un pequeño menú que permite selecciones y visualizar las animaciones del personaje, una vez se selecciones la animación deseada se puede oprimir el botón de continuar para avanzar a la siguiente escena.

## Escena 2

En la segunda escena se puede observar como en la esquina superior derecha se reproduce la animación seleccionada en la escena anterior, y se encontrará el personaje en una sala con 3 armas disponibles:

### Arma 1 (Lanzamiento parabólico)

La primer arma representada por un cubo blanco genera un disparo en ráfaga de múltiples proyectiles con una trayectoria parabólica, en donde el rango puede ser modificado a través del scriptableObject del arma, los proyectiles se destruyen despues de algunos segundos (3 segundos por defecto), este tiempo se puede modificar a través de las propiedades del proyectil en el inspector.

<p align="center">
  <img width="250" height="250" src="https://user-images.githubusercontent.com/20799388/144147506-03bb63a1-7aa1-4acf-b34e-c4eb8f418ad8.png">
</p>

### Arma 2 (Campo magnético)

La segunda arma, representada por un cubo azul, corresponde a un campo magnetico, donde el radio de alcance está determinado por el ScriptableObject del arma y la fuerza de atracción puede ser modificada en las propiedades del arma en el inspector. Hay 3 cubos pequeños que se encuentran detrás del arma y pueden ser usados para realizar pruebas.

<p align="center">
  <img width="250" height="250" src="https://user-images.githubusercontent.com/20799388/144148169-19104fe4-0aa6-4352-97d1-d0c96a385ba9.png">
</p>

### Arma 3 (Laser)

La tercera arma, que está representada por un cubo morado, corresponde a un laser que está diseñada para rebotar en las superficies que lleven el nombre de "Mirror", la cantidad máxima de rebotes es configurada a través del scriptableObject usando la variable de rango y el color y grosor del laser puede ser configurado directamente en las propiedades del arma.

<p align="center">
  <img width="250" height="250" src="https://user-images.githubusercontent.com/20799388/144148501-6df8ab2a-5ee1-4946-ad54-2255ce65cf91.png">
</p>

## Oportunidades de mejora

Por temas de tiempo, no pude pulir ciertos aspectos del proyectos, algunas cosas que me gustaría realizar mejor si tuviera mas tiempo son:

* Mejorar el sistema de cambio de armas ya que actualmente no es el mas óptimo y es un poco raro visualmente.
* Mejorar el arma magnética para que el los objetos que se atraigan, se mantengan de manera mas consistente al rededor del arma.
* Aumentar la cantidad de variables para modificar las armas y crear armas nuevas.
