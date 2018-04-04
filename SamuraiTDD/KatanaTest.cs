using FluentAssertions;
using Xunit;

namespace SamuraiTDD
{
  public class KatanaTest
  {
    [Fact]
    public void should_use_katana_against_someone()
    {
      // GIVEN
      var katana = new Katana();
      
      // WHEN
      var result = katana.UseAgainst("Arialdo");

      // THEN
      result.Should().Be("I chop you in 2, Arialdo!");
    }

    [Fact]
    public void should_a_samurai_attack_with_a_katana()
    {
      var samurai = new Samurai();
      samurai.WeaponToUse = "katana";

      var result = samurai.Attack("Arialdo");

      result.Should().Be("I'm a Samurai... I chop you in 2, Arialdo!");
    }

    [Fact]
    public void should_a_samurai_attack_with_a_gun()
    {
      var samurai = new Samurai();
      samurai.WeaponToUse = "gun";
      
      var result = samurai.Attack("Arialdo");

      result.Should().Be("I'm a Samurai... Raise your hands, Arialdo, you coward!");
    }

    [Fact]
    public void should_use_gun_against_someone()
    {
      var gun = new Gun();
      
      var result = gun.UseAgainst("Arialdo");

      result.Should().Be("Raise your hands, Arialdo, you coward!");
    }

  }
}