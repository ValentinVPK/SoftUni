using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry raceEntry;
        private UnitCar defaultCar;
        private UnitDriver defaultDriver;

        [SetUp]
        public void Setup()
        {
            raceEntry = new RaceEntry();
            defaultCar = new UnitCar("Fiat", 50, 100);
            defaultDriver = new UnitDriver("Bill", defaultCar);
        }

        [Test]
        public void AddDriver_ThrowException_WhenNameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                raceEntry.AddDriver(new UnitDriver(null, defaultCar));
            });

        }
        [Test]
        public void AddDriver_ThrowException_WhenDriverIsNull()
        {
            UnitDriver driver = null;

            Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.AddDriver(driver);
            });
        }

        [Test]
        public void AddDriver_ThrowException_WhenDriverExists()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.AddDriver(defaultDriver);
                raceEntry.AddDriver(defaultDriver);
            });
        }
        
        [Test]
        public void AddDriver_ReturnMessage_WhenSuccessful()
        {
            string result = raceEntry.AddDriver(defaultDriver);

            Assert.That(result, Is.EqualTo("Driver Bill added in race."));
        }

        [Test]
        public void AddDriver_DoesCountIncrease_WhenSuccessful()
        {
            int intialCount = raceEntry.Counter;
            raceEntry.AddDriver(defaultDriver);

            Assert.That(raceEntry.Counter, Is.EqualTo(intialCount + 1));
        }

        [Test]
        public void CalculateAverageHorsePower_ThrowException_WhenBelowMin()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.CalculateAverageHorsePower();
            });
        }

        [Test]
        public void CalculateAverageHorsePower_WhenSuccessful()
        {
            raceEntry.AddDriver(defaultDriver);
            raceEntry.AddDriver(new UnitDriver("Jo", new UnitCar("Chevy", 40, 100)));

            double avg = (40 + 50) / 2.0;

            Assert.That(raceEntry.CalculateAverageHorsePower(), Is.EqualTo(avg));
        }
    }
}