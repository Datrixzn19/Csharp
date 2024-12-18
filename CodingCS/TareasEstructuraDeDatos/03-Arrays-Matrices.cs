using System;

// Definición de la cl
    // Propiedades de la clase Producto
public class Producto
{
    public int Id { get; set; } // Identificador único del producto
    public string Nombre { get; set; } // Nombre del producto
    public string Unidad { get; set; } // Unidad de medida del producto
    public decimal[] Precios { get; set; } // Array de tres precios del producto

    // Constructor de la clase Producto
    public Producto(int id, string nombre, string unidad, decimal[] precios)
    {
        Id = id;
        Nombre = nombre;
        Unidad = unidad;
        Precios = precios;
    }
}

public class Result
{
    
    public static void Main()
    {
        // Creación de un array con tres precios diferentes
        decimal[] preciosProducto = { 10.99m, 12.49m, 15.99m };
        
        // Creación de una instancia de Producto y asignación de valores
        Producto producto = new Producto(1, "Manzana", "Kilogramo", preciosProducto);

        // Impresión de los detalles del producto
        
        Console.WriteLine($"ID: {producto.Id}");
        Console.WriteLine($"Nombre: {producto.Nombre}");
        Console.WriteLine($"Unidad: {producto.Unidad}");
        Console.WriteLine("Precios: ");
        
        // Impresión de cada precio en el array de precios
        foreach (decimal precio in producto.Precios)
        {
            Console.WriteLine($"- {precio}");
        }
    }
} 