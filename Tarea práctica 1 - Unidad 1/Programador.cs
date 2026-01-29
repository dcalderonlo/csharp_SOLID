public interface ITrabajo
{
  void Trabajar();
  void Descansar();
  void Comer();
}

public class Programador : ITrabajo
{
  public void Trabajar()
  {
    // Escribiendo código...
  }
  public void Descansar()
  {
    //Descansando...
  }
  public void Comer()
  {
    //Comiendo...
  }
}