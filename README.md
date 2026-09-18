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
dotnet run --project 01-Variables
```

## Convención

- **Un tema = una carpeta ejecutable** con su propio `Program.cs`.
- La carpeta lleva un número de orden más el nombre del tema (ej. `01-Variables`, `02-DataTypes`), para que se ordenen según la ruta. El proyecto (`.csproj`) mantiene solo el nombre (`Variables`), porque no puede empezar con número.
- Código en inglés; comentarios y mensajes de consola en español.
