public class CalculadoraDeDescuentos
{
  public double CalcularDescuento(double precio, IDescuento descuento)
  {
    return descuento.Calcular(precio);
  }
}