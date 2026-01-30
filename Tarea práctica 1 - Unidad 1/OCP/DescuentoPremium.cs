public class DescuentoPremium: IDescuento
{
  public double Calcular(double precio) => precio * 0.1;
}