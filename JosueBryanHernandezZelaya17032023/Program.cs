
using JosueBryanHernandezZelaya17032023.Models;

using AlmacenBdContext BaseDeDatos = new AlmacenBdContext();

Producto product = new Producto();

Console.Write("Porfavor ingrese el nombre del producto: ");
product.Nombre = Console.ReadLine();

Console.Write("Porfavor escriba una breve descripcion del producto: ");
product.Descripcion = Console.ReadLine();

Console.Write("Porfavor ingrese el precio del producto: ");
product.Precio = Convert.ToDecimal(Console.ReadLine());

Console.Write("Porfavor ingrese la cantidad de productos existentes: ");
product.Stock = Convert.ToInt32(Console.ReadLine());

BaseDeDatos.Productos.Add(product);
BaseDeDatos.SaveChanges();

var ListProductos =  BaseDeDatos.Productos.ToList();

foreach (var items in ListProductos)
{
    Console.WriteLine($"\nNombre asignado:  {items.Nombre}");
    Console.WriteLine($"Descripcion asignado:  {items.Descripcion}");
    Console.WriteLine($"Precio asignado:  {items.Precio}");
    Console.WriteLine($"Stock asignado:  {items.Stock}");

}





