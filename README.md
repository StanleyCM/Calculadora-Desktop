# 🧮 Calculadora

Aplicación de escritorio desarrollada en **C# con Windows Forms**, diseñada para realizar operaciones matemáticas básicas mediante una interfaz moderna, sencilla e intuitiva.

## Características

- Suma, resta, multiplicación y división.
- Cálculo de porcentajes.
- Cambio de signo positivo y negativo.
- Eliminación del último dígito.
- Limpieza completa mediante el botón `AC`.
- Repetición de operaciones con el botón igual.
- Compatibilidad con teclado y teclado numérico.
- Ajuste automático del tamaño del resultado.
- Manejo de división entre cero y desbordamientos numéricos.
- Separación entre la interfaz gráfica y la lógica de negocio.

## Tecnologías utilizadas

- **C#**
- **.NET 10**
- **Windows Forms**
- **Visual Studio**
- Arquitectura separada en proyectos `Core` y `WinForms`.

## Estructura del proyecto

```text
Calculadora/
├── Calculadora.Core/
│   ├── CalculatorService.cs
│   └── Calculadora.Core.csproj
│
├── Calculadora.WinForms/
│   ├── MainForm.cs
│   ├── MainForm.Designer.cs
│   ├── CircularButton.cs
│   ├── Program.cs
│   └── Calculadora.WinForms.csproj
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
git clone <URL_DEL_REPOSITORIO>
```

2. Accede al directorio del proyecto:

```bash
cd Calculadora
```

3. Restaura las dependencias:

```bash
dotnet restore
```

4. Ejecuta la aplicación:

```bash
dotnet run --project Calculadora/Calculadora.WinForms
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

El proyecto está dividido en dos componentes principales:

- **Calculadora.Core:** contiene la lógica y las operaciones matemáticas.
- **Calculadora.WinForms:** contiene la interfaz gráfica y la interacción con el usuario.

Esta separación facilita el mantenimiento, la reutilización del código y la incorporación de pruebas automatizadas.

## Posibles mejoras

- Agregar operaciones científicas.
- Incorporar un historial de cálculos.
- Añadir pruebas unitarias.
- Implementar diferentes temas visuales.
- Permitir el uso de memoria (`M+`, `M-`, `MR` y `MC`).

## Autor

**Stanley Camacho Abreu**

Desarrollado como proyecto de aprendizaje y práctica con C# y Windows Forms.
