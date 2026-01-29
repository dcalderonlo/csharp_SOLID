public class Pedido
{
  public void CrearPedido(string cliente, string producto)
  {
    // Lógica para crear un pedido
    Console. WriteLine($"Pedido creado para el cliente {cliente} con el producto {producto}.");
  }
  public void EnviarPedido(string cliente, string direccion)
  {
    // Lógica para enviar el pedido
    Console.WriteLine($"Pedido enviado a la dirección {direccion} para el cliente {cliente}.");
  }
  public void ImprimirFactura(string cliente, string producto)
  {
    // Lógica para imprimir la factura
    Console.WriteLine($"Factura impresa para el cliente {cliente} con el producto {producto}.");
  }
}