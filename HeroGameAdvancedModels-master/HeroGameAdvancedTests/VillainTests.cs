/* using System;
using System.Collections.Generic;
using Xunit;
using HeroGameAdvancedLib;


namespace HeroGameAdvancedTests
{
    public class VillainTests
    {
        // applies amount of damage to Hitpoints.
        // if damage is greater that Hitpoints, Hitpoints should be set to 0 (zero)
        public VillainTests(){}
        
        [Theory]
        [InlineData(0,0,0)]
        [InlineData(3,-4,0)]
        [InlineData(7,3,0)]
       // [InlineData(4,0,1)]//expected to fail
        public void Damage(int expectedDamage, int expectedHealth, int expectedresult)
        
        {
            Villain testvillain = new Villain(1,"Villain",expectedHealth);
            testvillain.Damage(expectedDamage);
            int result = testvillain.Hitpoints;
            Assert.Equal(expectedresult,result);
          
        }
    }
}
*/