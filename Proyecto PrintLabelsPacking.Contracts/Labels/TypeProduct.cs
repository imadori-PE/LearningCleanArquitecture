using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrintLabelsPacking.Contracts.Labels
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeProduct
    {
        Pallet = 1,
        Pucho = 2
    }

  //Un enum es útil cuando se tiene un conjunto definido y limitado de valores posibles para una variable.
}

/*
 * La línea de código [JsonConverter(typeof(JsonStringEnumConverter))] es un atributo en C# que se utiliza para personalizar la serialización y 
 * deserialización de un enum cuando se trabaja con JSON, a través del System.Text.Json.

Explicación completa:
[JsonConverter(typeof(JsonStringEnumConverter))]:

Este atributo le indica al serializer de JSON que debe convertir los valores del enum a sus nombres de cadena en lugar de sus valores enteros.
JsonStringEnumConverter es un convertidor provisto por System.Text.Json para serializar y deserializar enumeraciones en formato de texto (cadena).
public enum TypeProduct:
Defines una enumeración llamada TypeProduct con dos valores: Pallet (asociado al valor 1) y Pucho (asociado al valor 2).

Sin el JsonStringEnumConverter:Cuando se serializa esta enumeración sin el convertidor, por defecto se usa su valor entero. Ejemplo:
{
  "TypeProduct": 1
}
Con el JsonStringEnumConverter: Con el atributo aplicado, el enumerador se serializa como su nombre de cadena, lo cual es más legible. Ejemplo:
{
  "TypeProduct": "Pallet"
}
Ejemplo de uso:

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TypeProduct
{
    Pallet = 1,
    Pucho = 2
}

public class Product
{
    public TypeProduct ProductType { get; set; }
}

var product = new Product { ProductType = TypeProduct.Pallet };
string json = JsonSerializer.Serialize(product);
Console.WriteLine(json);
Salida del JSON:
{
  "ProductType": "Pallet"
}
Ventajas de usar JsonStringEnumConverter:
Mejora la legibilidad del JSON.
Facilita la compatibilidad con sistemas que esperan nombres de enum en lugar de sus valores numéricos.
Ayuda a evitar errores en la deserialización cuando los valores numéricos cambian pero los nombres se mantienen.

*/