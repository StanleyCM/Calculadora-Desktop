# 🧮 Calculadora

Aplicación de escritorio desarrollada en **C# con Windows Forms**, diseñada para realizar operaciones matemáticas básicas y científicas mediante una interfaz moderna, sencilla e intuitiva.

## Descripción

Este proyecto consiste en una calculadora de escritorio construida con **.NET 10** y **Windows Forms**. La aplicación separa la lógica matemática de la interfaz gráfica, permitiendo un código más organizado, mantenible y fácil de ampliar.

La solución está dividida en dos proyectos principales:

- `Calculadora.Core`: contiene la lógica de cálculo.
- `Calculadora.WinForms`: contiene la interfaz gráfica y la interacción con el usuario.

## Características

- Operaciones básicas: suma, resta, multiplicación y división.
- Potenciación.
- Raíz cuadrada.
- Cuadrado de un número.
- Inverso multiplicativo `1/x`.
- Porcentaje.
- Cambio de signo positivo y negativo.
- Funciones científicas: seno, coseno y tangente.
- Funciones trigonométricas inversas: seno⁻¹, coseno⁻¹ y tangente⁻¹.
- Logaritmo base 10.
- Logaritmo natural.
- Constantes matemáticas `π` y `e`.
- Modo de ángulos en grados y radianes mediante `DEG` / `RAD`.
- Uso de paréntesis para agrupar operaciones.
- Funciones de memoria: `MC`, `MR`, `M+` y `M-`.
- Botón `AC` para limpiar la calculadora.
- Botón de borrado para eliminar el último dígito.
- Repetición de operaciones con el botón igual.
- Compatibilidad con teclado y teclado numérico.
- Ajuste automático del tamaño del resultado en pantalla.
- Manejo de errores como división entre cero, resultados fuera de rango y operaciones matemáticas inválidas.
- Botones circulares personalizados con efecto visual al pasar o presionar el mouse.

## Tecnologías utilizadas

- **C#**
- **.NET 10**
- **Windows Forms**
- **Visual Studio**
- **Programación orientada a objetos**
- Arquitectura separada en proyectos `Core` y `WinForms`.

## Estructura del proyecto

```text
Calculadora/
├── Calculadora.Core/
│   ├── CalculatorService.cs
│   └── Calculadora.Core.csproj
│
├── Calculadora.WinForms/
│   ├── CircularButton.cs
│   ├── MainForm.cs
│   ├── MainForm.Designer.cs
│   ├── MainForm.resx
│   ├── Program.cs
│   ├── Calculadora.WinForms.csproj
│   └── Properties/
│       ├── Resources.Designer.cs
│       └── Resources.resx
│
├── Calculadora.sln
└── Calculadora.slnx
```

## Requisitos

- Windows 10 o Windows 11.
- [.NET 10 SDK](https://dotnet.microsoft.com/download).
- Visual Studio con la carga de trabajo **Desarrollo de escritorio de .NET**.

## Instalación y ejecución

1. Clona el repositorio:

```bash
git clone https://github.com/StanleyCM/Calculadora-Desktop.git
```

2. Accede al directorio del proyecto:

```bash
cd Calculadora-Desktop
```

3. Restaura las dependencias:

```bash
dotnet restore
```

4. Compila la solución:

```bash
dotnet build Calculadora.sln
```

5. Ejecuta la aplicación:

```bash
dotnet run --project Calculadora/Calculadora.WinForms/Calculadora.WinForms.csproj
```

También puedes abrir el archivo `Calculadora.sln` en Visual Studio y presionar `F5`.

## Controles del teclado

| Tecla | Acción |
|---|---|
| `0`–`9` | Introducir números |
| `+` | Sumar |
| `-` | Restar |
| `*` | Multiplicar |
| `/` | Dividir |
| `.` | Introducir decimales |
| `Enter` | Calcular el resultado |
| `Backspace` | Eliminar el último dígito |
| `Escape` o `Delete` | Limpiar la calculadora |

## Arquitectura

El proyecto está organizado siguiendo una separación clara entre lógica de negocio e interfaz gráfica.

### Calculadora.Core

Contiene la clase `CalculatorService`, responsable de realizar las operaciones matemáticas de la aplicación. Incluye operaciones básicas, funciones científicas, trigonométricas, logarítmicas, porcentajes y cambio de signo.

También define el enum `CalculatorOperation`, utilizado para representar las operaciones binarias disponibles:

- `Add`
- `Subtract`
- `Multiply`
- `Divide`
- `Power`

### Calculadora.WinForms

Contiene la interfaz gráfica de la calculadora. El formulario principal `MainForm` se encarga de manejar los eventos de los botones, la entrada por teclado, la visualización del resultado, el manejo de memoria, el modo de ángulos y los errores.

También incluye el control personalizado `CircularButton`, utilizado para dibujar botones redondeados con mejor apariencia visual.

## Manejo de errores

La aplicación muestra `SINTAXERROR` cuando ocurre una operación inválida, como:

- División entre cero.
- Raíz cuadrada de un número negativo.
- Logaritmo de cero o de un número negativo.
- Arco seno o arco coseno fuera del rango permitido.
- Resultados que exceden el rango numérico permitido.

## Estado del proyecto

El proyecto compila correctamente con:

```bash
dotnet build Calculadora.sln
```

Resultado esperado:

```text
Build succeeded.
0 Warning(s)
0 Error(s)
```

## Posibles mejoras

- Agregar pruebas unitarias para `Calculadora.Core`.
- Mejorar el soporte de teclado para funciones científicas.
- Mostrar indicadores visuales para memoria activa y paréntesis abiertos.
- Agregar historial de cálculos.
- Permitir temas visuales claros y oscuros.
- Corregir textos especiales si aparecen con problemas de codificación en algunos entornos.

## Autor

**Stanley Camacho Abreu**

Desarrollado como proyecto de aprendizaje y práctica con C# y Windows Forms.
