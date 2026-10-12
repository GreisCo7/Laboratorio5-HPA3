# Laboratorio 5

## Objetivo
Desarrollar soluciones en C# y MySQL aplicando conceptos de seguridad en bases de datos, consultas SQL parametrizadas, estructuras de datos dinámicas, métodos sobrecargados, recursividad y análisis estadístico mediante el conteo de frecuencias.

## Requisitos Previos

| Tecnología | Versión / Tipo |
| :--- | :--- |
| **Lenguaje** | C# (.NET Framework / .NET) |
| **Base de Datos** | MySQL |
| **Entorno de Desarrollo** | Microsoft Visual Studio 2026 |
| **Gestor de Base de Datos** | MySQL Workbench |
| **Control de Versiones** | Git & GitHub |

## Estructura del Proyecto

| Carpeta / Archivo | Función |
| :--- | :--- |
| **Consultas_SQL/** | Implementación de consultas SQL e identificación de vulnerabilidades de inyección SQL. |
| **Diccionario/** | Manipulación de cadenas y uso de estructuras tipo diccionario. |
| **MétodosSobrecargados/** | Implementación de métodos sobrecargados para distintos tipos de datos. |
| **Factorial/** | Cálculo del factorial utilizando recursividad. |
| **Estadísticas/** | Simulación y análisis de frecuencias mediante números aleatorios. |

## Instalación y Ejecución

### 1. Clonar el repositorio

```bash
git clone https://github.com/USUARIO/REPOSITORIO.git
```

### 2. Abrir en el entorno local

Abra la carpeta del laboratorio o la solución desde **Microsoft Visual Studio 2026**.

### 3. Ejecutar los ejercicios

Seleccione el proyecto deseado como proyecto de inicio y presione **F5** para ejecutar.

### 4. Restaurar la base de datos MySQL

Para ejecutar las consultas SQL:

1. Abrir **MySQL Workbench**.
2. Crear una nueva base de datos o importar el archivo `productosdb.sql`.
3. Ejecutar los scripts ubicados en la carpeta **Consultas_SQL**.

---

# Resultados

## 1. Consultas SQL e Inyección SQL

* **Descripción:** Implementación y análisis de distintos escenarios de inyección SQL sobre una base de datos MySQL.

* **Explicación:** Se realizaron tres consultas destinadas a demostrar vulnerabilidades comunes en aplicaciones que no validan correctamente la entrada del usuario. La primera emplea una condición lógica que siempre resulta verdadera, la segunda utiliza una inyección basada en tiempo mediante la función `SLEEP()`, y la tercera aprovecha comentarios SQL para alterar la instrucción original. Estas pruebas permiten comprender los riesgos asociados a las inyecciones SQL y la importancia de implementar consultas seguras.

### Consulta 1

<img width="594" height="275" alt="image" src="https://github.com/user-attachments/assets/558bd0cc-e416-4131-83aa-c2b794f65f92" />

### Consulta 2

<img width="599" height="280" alt="image" src="https://github.com/user-attachments/assets/c1173871-e82d-4125-81fb-11b9f87b4071" />

### Consulta 3

<img width="618" height="259" alt="image" src="https://github.com/user-attachments/assets/0eb94c11-12a2-496c-b40c-4234f7bd75f2" />


---

## 2. Diccionarios y Manipulación de Cadenas

* **Descripción:** Uso de estructuras de datos dinámicas para almacenar y mostrar información mediante pares clave-valor.

* **Explicación:** Se empleó la colección `Dictionary<TKey, TValue>` para organizar información utilizando claves únicas asociadas a sus respectivos valores. El programa recorre las claves mediante una estructura `foreach` y utiliza métodos de manipulación de cadenas para presentar los resultados de forma ordenada. Este ejercicio refuerza el uso de colecciones genéricas y el tratamiento eficiente de datos textuales.

<img width="921" height="171" alt="image" src="https://github.com/user-attachments/assets/9349e126-c9f6-486e-8171-e40f44d78b02" />


---

## 3. Métodos Sobrecargados

* **Descripción:** Implementación de métodos con un mismo nombre capaces de procesar diferentes tipos de datos.

* **Explicación:** Se desarrollaron varias versiones del método `Cuadrado()`, permitiendo trabajar tanto con números enteros como con valores decimales. Gracias a la sobrecarga de métodos, el compilador selecciona automáticamente la versión adecuada según el tipo de argumento recibido. Este ejercicio demuestra uno de los mecanismos fundamentales de la Programación Orientada a Objetos para mejorar la reutilización y flexibilidad del código.

<img width="604" height="262" alt="image" src="https://github.com/user-attachments/assets/931be41b-0ebd-4d64-b49f-79553001773d" />


---

## 4. Recursividad (Factorial)

* **Descripción:** Resolución del cálculo factorial mediante llamadas recursivas.

* **Explicación:** Se implementó un método recursivo denominado `Factorial()` que se invoca a sí mismo reduciendo progresivamente el valor recibido hasta alcanzar un caso base. Este enfoque permite resolver problemas matemáticos repetitivos de manera elegante, demostrando el funcionamiento interno de la recursividad y el manejo de la pila de ejecución.

<img width="661" height="327" alt="image" src="https://github.com/user-attachments/assets/7fd9a9d9-410e-4fe5-826f-966f7d453c95" />


---

## 5. Frecuencia de Datos

* **Descripción:** Análisis estadístico de frecuencias mediante simulación de lanzamientos de un dado.

* **Explicación:** El programa utiliza la clase `Random` para generar 6,000 lanzamientos de un dado virtual. Los resultados obtenidos son almacenados y contabilizados mediante un arreglo de frecuencias, donde cada posición representa una de las seis caras posibles. Finalmente, se muestran las frecuencias registradas, permitiendo observar la distribución de los valores generados aleatoriamente.

<img width="506" height="308" alt="image" src="https://github.com/user-attachments/assets/f04f0058-a96c-4144-9b19-3d21d2ed4c0a" />


---

## Fecha de Ejecución

12 de Octubre de 2026

| Datos del Estudiante | Detalles |
| :--- | :--- |
| **Nombre** | Greisy Coronado |
| **Correo** | greisy.coronado@utp.ac.pa |
| **Curso** | Herramientas de Programación Aplicada III |
| **Instructor** | Ing. Irina Fong |
