public class CalculadoraDeDescuentos
{
  public double Calcularescuento(double precio, string tipoCliente)
  {
    if (tipoCliente == "Regular")
      return precio * 0.05;
    else if (tipoCliente == "Premium")
      return precio * 0.1;
    else
    {
      return 0;
    }
  }
}