namespace SamuraiTDD
{
  public class Gun : IWeapon
  {
    public string UseAgainst(string target)
    {
      return $"Raise your hands, {target}, you coward!";
    }
  }
}