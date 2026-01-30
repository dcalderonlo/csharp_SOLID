public class Pedido 
{
  public string Cliente { get; set; }
  public string Producto { get; set; }

  public Pedido(string cliente, string producto)
  {
    Cliente = cliente;
    Producto = producto;
  }
}