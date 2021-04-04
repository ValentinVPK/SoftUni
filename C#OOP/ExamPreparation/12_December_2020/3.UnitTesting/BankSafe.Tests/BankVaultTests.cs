using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault vault;
        private Item item;

        [SetUp]
        public void Setup()
        {
            vault = new BankVault();
            item = new Item("Me", "1");
        }

        [Test]
        public void When_CellDoesNotExist_ShouldThrowException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("nqma go", item);
            });

            Assert.That(ex.Message, Is.EqualTo("Cell doesn't exists!"));
        }

        [Test]
        public void When_CellIsAlreadyTaken_ShouldThrowException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("A2", item);
                vault.AddItem("A2", new Item("Pesho" , "3"));
            });

            Assert.That(ex.Message, Is.EqualTo("Cell is already taken!"));
        }

        [Test]
        public void When_ItemAlreadyExists_ShouldThrowException()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                vault.AddItem("A2", item);
                vault.AddItem("B2", item);
            });

            Assert.That(ex.Message, Is.EqualTo("Item is already in cell!"));
        }

        [Test]
        public void When_ItemAndCellAreCorrect_ShouldReturnMessage()
        {
            string result = vault.AddItem("A2", item);
  
            Assert.That(result, Is.EqualTo($"Item:{item.ItemId} saved successfully!"));
        }

        [Test]
        public void WhenItemIsAdded_ItemAndCellAreCorrect_ShouldSet()
        {
            string result = vault.AddItem("A2", item);

            Assert.That(item, Is.EqualTo(vault.VaultCells["A2"]));
        }

        [Test]
        public void WhenRemoveCalled_CellDoesNotExist_ShouldThrowException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("nqma go", item);
            });

            Assert.That(ex.Message, Is.EqualTo("Cell doesn't exists!"));
        }

        [Test]
        public void WhenRemoveCalled_ItemInCellDoesNotExist_ShouldThrowException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("A2", item);
            });

            Assert.That(ex.Message, Is.EqualTo($"Item in that cell doesn't exists!"));
        }

        [Test]
        public void WhenItemIsRemoved_ShouldReturnMessage()
        {
            vault.AddItem("A2", item);

            string result = vault.RemoveItem("A2", item);
            Assert.That(result, Is.EqualTo($"Remove item:{item.ItemId} successfully!"));
        }

        [Test]
        public void WhenItemIsRemoved_ShouldMakeTheCellNull()
        {
            vault.AddItem("A2", item);

            vault.RemoveItem("A2", item);

            Assert.That(null, Is.EqualTo(vault.VaultCells["A2"]));
        }
    }
}