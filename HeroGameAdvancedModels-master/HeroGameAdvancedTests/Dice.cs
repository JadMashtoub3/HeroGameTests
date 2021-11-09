/*using System;
using Xunit;
using HeroGameAdvancedLib;
namespace HeroGameAdvancedTests
{               
     // Roll returns an integer between Min and Max inclusive

    public class DiceTests
    {   Dice testdice;
        Dice testDice1;
        public DiceTests(){
            this.testDice1 = new Dice(1,3);
        }
        [Theory]
        [InlineData(1,1)]
        [InlineData(10,10)]
        [InlineData(1,2)]
        [InlineData(100,1000)]
        public void Dicetest1(int mindamage, int maxdamage)
        {   this.testdice = new Dice(mindamage,maxdamage);
            Assert.True(testdice.Roll() >= mindamage);
            Assert.True(testDice1.Roll() <= maxdamage);
        }   
        [Theory]
        [InlineData(2)]//may take a few tries
        public void DiceTest2(int expected){
        Assert.Equal(expected,testDice1.Roll());
        }
    }

}
*/