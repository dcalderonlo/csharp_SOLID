public class ImprimeFactura
{
  public void ImprimirFactura(Pedido pedido)
  {
    // Lógica para imprimir la factura
    Console.WriteLine($"Factura impresa para el cliente: {pedido.Cliente}, con el producto: {pedido.Producto}.");
  }
}