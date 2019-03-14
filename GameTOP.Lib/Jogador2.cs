using GameTOP.Interface;

namespace GameTOP.Lib
{
  public class Jogador2 : IJogador
  {
    public string Chuta()
    {
      return "Maradona estas chutando";
    }

    public string Corre()
    {
      return "Maradona estas correndo";
    }

    public string Passe()
    {
      return "Maradona estas passando";
    }
  }
}