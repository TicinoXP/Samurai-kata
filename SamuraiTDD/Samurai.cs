using System;

namespace SamuraiTDD
{
  public class Samurai
  {
    public string Attack(string target)
    {
      IWeapon weapon;
      switch (WeaponToUse)
      {
        case "katana":
          weapon = new Katana();
          break;
        case "gun":
          weapon = new Gun();
          break;
        default:
          throw new NotImplementedException();
      }

      return $"I'm a Samurai... {weapon.UseAgainst(target)}";
    }

    public string WeaponToUse { get; set; }
  }
}