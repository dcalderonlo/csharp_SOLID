public class EnvioDeCorreo
{
  private readonly IClienteCorreo _clienteCorreo;

  public EnvioDeCorreo(IClienteCorreo clienteCorreo)
  {
    this._clienteCorreo = clienteCorreo;
  }

  public void EnviarCorreo(string destino, string mensaje)
  {
    _clienteCorreo.Enviar(destino, mensaje);
  }
}