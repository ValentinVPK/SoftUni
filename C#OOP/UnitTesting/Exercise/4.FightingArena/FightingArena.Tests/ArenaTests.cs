﻿using System;
using System.Linq;
using FightingArena;
using NUnit.Framework;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
        }

        [Test]
        public void Ctor_InitializeWarriors()
        {
            Assert.That(arena.Warriors, Is.Not.Null);
        }

        [Test]
        public void Count_IsZeroWhenArenaIsEmpty()
        {
            Assert.That(this.arena.Count, Is.EqualTo(0));
        }

        [Test]
        public void Enroll_ThrowsException_WhenWarriorAlreadyExists()
        {
            string name = "Warrior";
            this.arena.Enroll(new Warrior(name, 50, 50));
            Assert.Throws<InvalidOperationException>(() =>
            this.arena.Enroll(new Warrior(name, 100, 100)));
        }
        [Test]
        public void Enroll_IncreasesArenaCount()
        {
            this.arena.Enroll(new Warrior("Warrior", 50, 50));

            Assert.That(this.arena.Count, Is.EqualTo(1));
        }

        [Test]
        public void Enroll_AddsWarriorToWarriors()
        {
            string name = "Warrior";
            this.arena.Enroll(new Warrior(name, 50, 50));

            Assert.That(this.arena.Warriors.Any(w => w.Name == name) , Is.True);
        }

        [Test]
        public void Fight_ThrowsException_WhenDeffenderDoesNotExist()
        {
            string name = "Attacker";
            this.arena.Enroll(new Warrior(name, 40, 40));

            Assert.Throws<InvalidOperationException>(() =>
                this.arena.Fight(name, "Defender"));   
        }

        [Test]
        public void Fight_ThrowsException_WhenAttackerDoesNotExist()
        {
            string name = "Deffender";
            this.arena.Enroll(new Warrior(name, 40, 40));

            Assert.Throws<InvalidOperationException>(() =>
                this.arena.Fight("Attacker", name));
        }

        [Test]
        public void Fight_ThrowsException_WhenBothDoNotExist()
        {
            Assert.Throws<InvalidOperationException>(() =>
                this.arena.Fight("Attacker", "Deffender"));
        }

        [Test]
        public void Fight_BothWarriorsLoseHealthPointsInFight()
        {
            int intialHP = 100;

            Warrior attacker = new Warrior("Attacker", 50, intialHP);
            Warrior deffender = new Warrior("Deffender", 50, intialHP);

            this.arena.Enroll(attacker);
            this.arena.Enroll(deffender);

            this.arena.Fight(attacker.Name, deffender.Name);

            Assert.That(attacker.HP, Is.EqualTo(intialHP - deffender.Damage));
            Assert.That(deffender.HP, Is.EqualTo(intialHP - attacker.Damage));
        }
    }
}
