public class DescuentoRegular: IDescuento
{
  public double Calcular(double precio) => precio * 0.05;
}