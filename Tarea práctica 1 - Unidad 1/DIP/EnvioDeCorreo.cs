public class EnvioDeCorreo
{
  private SmtpCliente smtpCliente;
  public EnvioDeCorreo()
  {
    smtpCliente = new SmtpCliente(); // Dependencia concreta
  }
  public void EnviarCorreo(string destino, string mensaje)
  {
    smtpCliente.Enviar(destino, mensaje);
  }
}

public class SmtpCliente
{
  public void Enviar(string destino, string mensaje)
  {
    // Lógica para enviar correo
  }
}