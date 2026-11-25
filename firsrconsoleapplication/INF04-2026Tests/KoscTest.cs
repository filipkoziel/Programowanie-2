using EgzaminINF042026;
using System;
using System.Collections.Generic;
using System.Text;

namespace INF04_2026Tests
{
    public class KoscTest()
    {
        [Fact]
        public void Kosc_ThrownDiceValueIsWithin1and6()
        {
            Kosc kosc;

            kosc = new Kosc(0);
            kosc.throwDiceIfAvailable();

            Assert.InRange(kosc.numberThrown, 1, 6);
        }

        [Fact]
        public void Kosc_DeactivatedDiceValueDoesntChangeOnThrow()
        {
            Kosc kosc;

            kosc = new Kosc(0);
            kosc.throwDiceIfAvailable();
            int numberThrownOnInitialization = kosc.numberThrown;
            kosc.disableDice();
            kosc.throwDiceIfAvailable();

            Assert.Equal(kosc.numberThrown, numberThrownOnInitialization);
        }
    }
}
