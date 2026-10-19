# Inventario de tienda

## Estudiante
Tu nombre completo

## Descripción
Sistema de inventario desarrollado en C# con Windows Forms.
Permite agregar, modificar, eliminar, buscar y ordenar productos
por nombre. También permite registrar entradas y salidas de
existencias y consultar el historial de movimientos.

## Estructuras de datos utilizadas

### Arreglo
En Form1.cs se utiliza resumenExistencias, un arreglo de tres
posiciones que cuenta los productos:
- Posición 0: sin existencias.
- Posición 1: entre 1 y 5 unidades.
- Posición 2: con más de 5 unidades.

El botón Resumen inicializa y recorre el arreglo.

### Lista dinámica
En Form1.cs se utiliza List<Producto> productos para almacenar
los productos. Permite agregar, modificar, eliminar, buscar,
recorrer y ordenar los registros.

### Lista enlazada simple
La clase NodoMovimiento contiene el detalle de un movimiento
y la referencia Siguiente.

Cada producto tiene una referencia PrimerMovimiento.
En FrmMovimientos.cs se agregan movimientos al inicio de la
lista, se recorren para mostrarlos y se permite buscarlos
y eliminarlos.

Eliminar un registro del historial no revierte las existencias.

## Requisitos
- Windows.
- Visual Studio con la carga de trabajo Desarrollo de escritorio de .NET.
- SDK de .NET compatible con el proyecto.

## Cómo ejecutar
1. Descargar y descomprimir el proyecto, o clonar el repositorio.
2. Abrir el archivo de solución .sln en Visual Studio.
3. Compilar la solución.
4. Presionar F5 para ejecutar.

## Datos de ejemplo
Agregar estos productos desde el formulario principal:

| Nombre | Categoría | Precio | Existencias |
|--------|-----------|--------|-------------|
| Arroz | Alimento | 1500 | 0 |
| Leche | Bebida | 2500 | 3 |
| Coca | Refresco | 1000 | 10 |

Al presionar Resumen, debe aparecer un producto en cada grupo.

Para probar los movimientos:
1. Seleccionar Coca y abrir Movimientos.
2. Escribir 4 y registrar una entrada: quedan 14 unidades.
3. Escribir 3 y registrar una salida: quedan 11 unidades.
4. Intentar retirar 12: el sistema debe impedirlo.
5. Buscar Entrada o Salida en el historial.

## Validaciones
- Nombre y categoría obligatorios.
- Precio numérico mayor que cero.
- Existencias enteras de cero o más.
- No se permiten nombres de productos duplicados.
- Los movimientos requieren cantidades enteras positivas.
- No se permiten salidas mayores que las existencias disponibles.

## Almacenamiento
Los datos se mantienen en memoria durante la ejecución.
Al cerrar la aplicación, los productos y movimientos se pierden.
