using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabelsPacking.Contracts.Labels
{
    //create contracts
    public record CreatePrintedLabelsRequest(string CodeSectorVariety,string CodeLabel, TypeProduct TypeProduct,string CodePallet, int NumberBoxes, Guid UserId);

}

/*
 
En C#, la palabra clave record se introdujo en C# 9.0 y permite definir un tipo de referencia que se centra en la inmutabilidad y la igualdad estructural, 
a diferencia de las clases tradicionales que usan igualdad referencial por defecto. Los records son particularmente útiles para trabajar con datos inmutables 
y son una excelente opción para representar modelos de datos en aplicaciones.

Características principales de record:
Inmutabilidad por defecto: Los valores de un record suelen ser inmutables, aunque puedes personalizarlo.
Comparación estructural: Dos instancias de un record se consideran iguales si sus valores son iguales (igualdad por contenido).
Sintaxis simplificada: Los records permiten la declaración compacta de datos.
Desconstrucción: Permite descomponer el record en sus componentes (propiedades) de manera sencilla.

 puedes usar la función de "con-expressions" para crear una nueva instancia de un record con algunos cambios:
var producto3 = producto1 with { Precio = 1400.00m };
Console.WriteLine(producto3);  // Salida: Producto { Nombre = Laptop, Precio = 1400.00 }

Comparación con class:
Clases: La comparación por defecto se hace por referencia (dos objetos son iguales solo si apuntan a la misma instancia en memoria).
Records: La comparación por defecto se hace por valores (dos objetos son iguales si sus valores coinciden).

*/

/* 
 
La clase Guid en C# representa un Identificador Único Global (Global Unique Identifier), que es un valor de 128 bits (16 bytes) utilizado para 
identificar de manera única entidades en un sistema distribuido. Es muy útil cuando se necesita generar identificadores que no se repitan, 
incluso en entornos donde múltiples sistemas pueden estar generando identificadores de manera simultánea.

Características de un Guid:
Tamaño: 128 bits (16 bytes).
Formato: Se presenta generalmente como una cadena de texto en formato hexadecimal, dividida en cinco grupos separados por guiones 
(por ejemplo: 9f8c265d-92d5-4c89-8df6-8b3cba4296c1).
Unicidad: Los Guid están diseñados para ser únicos en un espacio distribuido, lo que significa que la probabilidad de que dos Guid 
idénticos se generen es extremadamente baja.

Usos comunes de Guid:
Generar identificadores únicos en bases de datos.
Identificación de objetos en aplicaciones distribuidas o sistemas de alta concurrencia.
Identificadores en protocolos como COM o en claves de registro de Windows.

*/