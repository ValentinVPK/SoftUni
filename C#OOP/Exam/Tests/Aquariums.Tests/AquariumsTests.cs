namespace Aquariums.Tests
{
    using System;
    using NUnit.Framework;
    using Aquariums;

    public class AquariumsTests
    {
        private Aquarium aqua;

        [SetUp]
        public void SetUp()
        {
            aqua = new Aquarium("Aqua", 2);
        }

        [Test]
        public void SetName_ThrowsException_WhenNameIsNullOrEmpty()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Aquarium nullName = new Aquarium(null, 2);
            });
        }

        [Test]
        public void SetName_ShouldWork()
        {
            Assert.That(aqua.Name, Is.EqualTo("Aqua"));
        }

        [Test]
        public void SetCapacity_ThrowsException_WhenBelow0()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Aquarium belowZero = new Aquarium("Aqua1", -5);
            });
        }

        [Test]
        public void SetCapacity_ShouldWork()
        {
            Assert.That(aqua.Capacity, Is.EqualTo(2));
        }

        [Test]
        public void Add_ThrowException_WhenAquariumIsFull()
        {
            aqua.Add(new Fish("Nemo"));
            aqua.Add(new Fish("Dori"));
            Assert.Throws<InvalidOperationException>(() =>
            {
                aqua.Add(new Fish("Invalid"));
            });
        }

        [Test]
        public void Add_ShouldWork()
        {
            aqua.Add(new Fish("Nemo"));
            Assert.That(aqua.Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveFish_ThrowException_WhenFishDoesntExist()
        {
            aqua.Add(new Fish("Nemo"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                aqua.RemoveFish("Dori");
            });
        }

        [Test]
        public void RemoveFish_ShouldWork()
        {
            aqua.Add(new Fish("Nemo"));
            aqua.RemoveFish("Nemo");
            Assert.That(aqua.Count, Is.EqualTo(0));
        }

        [Test]
        public void SellFish_ThrowException_WhenFishDoesntExist()
        {
            aqua.Add(new Fish("Nemo"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                aqua.SellFish("Dori");
            });
        }

        [Test]
        public void SellFish_ShouldWork()
        {
            aqua.Add(new Fish("Nemo"));
            Fish soldFish = aqua.SellFish("Nemo");
            Assert.That(soldFish.Available, Is.EqualTo(false));
        }

        [Test]
        public void Report_ShouldWork()
        {
            aqua.Add(new Fish("Nemo"));
            aqua.Add(new Fish("Dori"));

            string expceted = $"Fish available at {aqua.Name}: Nemo, Dori";

            Assert.That(aqua.Report(), Is.EqualTo(expceted));
        }
    }
}
