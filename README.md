# 📦 InventarioProyectoFinal

**InventarioProyectoFinal** es una aplicación de escritorio desarrollada en **C# con Windows Forms**, enfocada en la gestión de productos e inventario para pequeños negocios o uso académico. Permite registrar, visualizar, filtrar, editar y exportar productos, todo desde una interfaz amigable y estructurada.

---

## 🛠️ Tecnologías utilizadas

- C# (.NET Framework)
- Windows Forms (WinForms)
- LINQ
- Programación Orientada a Objetos (POO)
- Archivos de texto (`.txt`) como base de datos
- Gráficos con `System.Windows.Forms.DataVisualization.Charting`

---

## 🚀 Funcionalidades principales

- ✅ Agregar productos con imagen, precio, código, stock, estado y fechas.
- 🔍 Vista de inventario con filtros por nombre, stock, estado o color (verde, amarillo, rojo).
- 🖼️ Vista tipo galería (tarjetas) editable con panel lateral.
- 📊 Módulo de estadísticas con gráficos y reportes.
- 📝 Exportación de inventario completo a `.csv` o `.txt`.
- ♻️ Activación/Desactivación de productos en lugar de borrarlos.
- 🔐 Control de usuario básico en pantalla principal.

---

## 📂 Estructura del proyecto

InventarioProyectoFinal/

├── BaseDeDatos/         # Archivos de datos como Producto.txt, Usuario.txt, Logs.txt

├── Formularios/         # Formularios principales de la aplicación (Windows Forms)

├── ImagenesProductos/   # Carpeta donde se guardan imágenes de los productos

├── ImagenesUsuarios/    # Carpeta para imágenes de perfil de usuario (si aplica)

├── Interfaces/          # Interfaces que definen comportamientos del sistema

├── Logica/              # Lógica de negocio y acceso a datos

├── Modelos/             # Clases que representan entidades como Producto, Usuario

├── Resources/           # Recursos visuales del sistema (íconos, imágenes embebidas)

├── Program.cs           # Punto de entrada principal del sistema

├── Properties/          # Configuraciones del proyecto (AssemblyInfo, recursos)

├── README.md            # Archivo de documentación del proyecto

---

### 📸 Capturas del sistema

#### 🖼️ Log In
![Log In](https://drive.google.com/uc?export=view&id=1x2P0FcPKF28qG5oGVAsRtFepuLFJ3s_N)

#### 🧭 Menú principal
![Menú principal](https://drive.google.com/uc?export=view&id=1oQbqP4e7sHwUAYCbY8j4ARdpnLQp3uKx)

#### 📦 Vista del inventario
![Vista inventario](https://drive.google.com/uc?export=view&id=1UTsk918isVBWpJpSDT9l1wpYOVbFcaLg)

#### 📊 Estadisticas y reportes
![Estadisticas](https://drive.google.com/uc?export=view&id=1dCyH7JhMl8RIr6wdpeh53BHWJyCg_mkV)


## 📤 Exportación de datos

Desde el módulo de estadísticas puedes exportar el inventario completo en formato `.csv` o `.txt`, incluyendo los siguientes campos:

- Código
- Nombre
- Precio de compra
- Precio de venta
- Stock
- Estado (Activo/Inactivo)
- Fecha de creación
- Fecha de última modificación

---

## ⚙️ Cómo ejecutar el sistema

1. Abre la solución `InventarioProyectoFinal.sln` en Visual Studio 2022.
2. Compila el proyecto con `Ctrl + Shift + B`.
3. Ejecuta el sistema presionando `F5`.
4. Usa el menú principal para navegar por las diferentes funcionalidades del sistema.

---

## 👨‍💻 Autor

**Braulin Pérez**  
Estudiante de Ingeniería en Sistemas  
📍 República Dominicana  
🗓️ Proyecto final – Julio 2025

---

## 📌 Notas adicionales

- El sistema **no requiere base de datos externa**. Todos los datos se almacenan en archivos `.txt` para facilitar la ejecución sin configuraciones avanzadas.
- Es posible **personalizar las rutas**, cambiar nombres de campos, o **migrar a SQL Server** si se desea mejorar o escalar el proyecto.
- El código está organizado utilizando buenas prácticas de programación:
  - Separación por capas (formularios, lógica, interfaces).
  - Uso de interfaces y clases abstractas.
  - Expresiones lambda y LINQ para filtros y consultas.

---
