public class Coche : Vehiculo
{
  public override void Conducir()
  {
    // Lógica para conducir el coche
    Console.WriteLine("Conduciendo el coche.");
  }

  public void AbrirMaletero()
  {
    // Lógica para abrir el maletero
    Console.WriteLine("Maletero abierto.");
  }
}