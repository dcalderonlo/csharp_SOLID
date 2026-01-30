public class EnvioPedido
{
  public void EnviarPedido(Pedido pedido, string direccion)
  {
    // Lógica para enviar el pedido
    Console.WriteLine($"Pedido enviado a la dirección: {direccion}, para el cliente: {pedido.Cliente}.");
  }
}