public class Vehiculo
{
  public virtual void Conducir()
  {
    // Lógica de conducción
  }
  public class Bicicleta : Vehiculo
  {
    public override void Conducir()
    {
      // Conducir bicicleta
    }
  }
  public class Coche : Vehiculo
  {
    public override void Conducir()
    {
      // Conducir coche
    }

    public void AbrirMaletero()
    {
      //l Lógica para abrir maletero 
    }
  }
}