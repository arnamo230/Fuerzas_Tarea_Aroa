# TAREA DE FUERZAS EN FÍSICA 3D

## Ejercicio despegue de cohetes

En este ejercicio he creado un pequeño sistema donde varios cohetes despegan aplicando una fuerza constante hacia arriba. 
### Explicación
- Hay tres cohetes con diferentes masas
- Cuando pulso la barra espaciadora se activa el motor del cohete, es decir, empieza la acción de despegue de los cohetes
- Mientras el motor está encendido cada cohete recibe una fuerza hacia arriba
- El despegue depende de la masa del rigidbody y de la fuerza aplicada



## Ejercicio small world con órbita 

En este ejercicio he creado un planeta y un jugador (una esfera) que se comporta como un satelite.  
La idea era simular una gravedad propia del planeta, es decir, que la fuerza siempre apunte hacia el centro del planeta.

### Explicación
- El planeta tiene una masa grande y no se mueve
- El jugador tiene un rigidbody normal
- En cada FixedUpdate calculo la fuerza gravitatoria usando una versión ajustada de la fórmula real: F = G * (m1 * m2) / distancia²
- Además, le doy al jugador una velocidad lateral para que empiece a orbitar en vez de que simpplemente se quede quieto en un sitio
