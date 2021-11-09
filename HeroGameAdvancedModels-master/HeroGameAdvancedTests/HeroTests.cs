using System;
using Xunit;
using HeroGameAdvancedLib;
namespace HeroGameAdvancedTests
{
    public class HeroTests
    {
        // Hero is able to attack a given number of times.  Each time a hero attacks subtract 1 from Uses
        // timesToAttack is greater that the number of Uses should return -1 and not subtract from Uses.
        Dice TestDice;
        Hero TestHero;
        Villain TestVillain;
        
        public HeroTests(){
        this.TestDice = new Dice(0,6);
        this.TestHero = new Hero(1, "Hero", TestDice, 10);
        this.TestVillain = new Villain(1, "vill", 10);
        }
        //attack, uses, damage
        [Theory]
        [InlineData(1, 5, 1)]
        [InlineData(11, 10,-1)] //sets hp to -1 test
        [InlineData(10,90,10)]
        [InlineData(0,1,0)]
        public void AttackTest(int attacks, int expectedUses, int expectedDamage)
        {   
        int Damage = TestHero.Attack(attacks);
        Assert.Equal(expectedUses,TestHero.Uses);
        Assert.Equal(Damage, expectedDamage);
        }
    }
}