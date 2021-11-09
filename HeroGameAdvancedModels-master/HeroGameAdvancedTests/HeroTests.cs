using System;
using Xunit;
using HeroGameAdvancedLib;
namespace HeroGameAdvancedTests
{
    public class HeroTests
    {
        // Hero is able to attack a given number of times.  Each time a hero attacks subtract 1 from Uses
        // timesToAttack is greater that the number of Uses should return -1 and not subtract from Uses.
        Dice testhero1;
        Hero testhero;

        public HeroTests(){
        this.testhero1 = new Dice(1,1);
        this.testhero = new Hero(1, "testhero", testhero1, 100);
        }
        [Theory]
        [InlineData(1, 99,1)]
        [InlineData(101, 100,-1)]
        [InlineData(10,90,10)]
        [InlineData(1000,100,-1)]
        public void AttackTest(int expectedAttacks, int expectedUses, int expectedDamage)
        {   
            int Damage = testhero.Attack(expectedAttacks);
            Assert.Equal(expectedUses,testhero.Uses);
            
            Assert.Equal(Damage, expectedDamage);
        }
    }
}
