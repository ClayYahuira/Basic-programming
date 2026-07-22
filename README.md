# Basic programming

Código de ejemplo de la categoría **Programación Básica** del blog
[Diving in coding](https://divingincoding.dev).

Cada tema de la ruta de aprendizaje vive en su propia carpeta y se puede
**ejecutar de forma independiente**. Los identificadores están en inglés y las
explicaciones, en comentarios en español.

## Requisitos

- [.NET SDK 9](https://dotnet.microsoft.com/download)

## Cómo ejecutar un tema

Desde la raíz del repositorio, indica la carpeta del tema:

```bash
dotnet run --project Variables
```

## Temas

| # | Tema | Carpeta | Estado |
|---|------|---------|--------|
| 1 | Qué es programar | — | Conceptual (sin código) |
| 2 | Qué es una variable | `Variables` | ✅ |
| 3 | Tipos de datos | — | ⏳ |
| 4 | Operadores | — | ⏳ |
| 5 | if / else | — | ⏳ |
| 6 | for | — | ⏳ |
| 7 | while / do while | — | ⏳ |
| 8 | Arrays | — | ⏳ |
| 9 | Strings | — | ⏳ |
| 10 | Métodos | — | ⏳ |
| 11 | Parámetros y retorno | — | ⏳ |
| 12 | Scope | — | ⏳ |
| 13 | Excepciones básicas | — | ⏳ |
| 14 | Entrada y salida por consola | — | ⏳ |
| 15 | Introducción a POO | — | ⏳ |
| 16 | Clases | — | ⏳ |
| 17 | Objetos | — | ⏳ |
| 18 | Constructores | — | ⏳ |
| 19 | Propiedades | — | ⏳ |
| 20 | Encapsulación básica | — | ⏳ |

## Convención

- **Un tema = una carpeta ejecutable** con su propio `Program.cs`.
- Carpeta en PascalCase con el nombre del tema (ej. `Variables`, `DataTypes`).
- Código en inglés; comentarios y mensajes de consola en español.
