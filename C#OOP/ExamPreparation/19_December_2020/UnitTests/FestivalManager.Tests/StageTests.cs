// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    using FestivalManager.Entities;
    using NUnit.Framework;
    using System;

    [TestFixture]
	public class StageTests
    {
		private Stage stage;
		[SetUp]
		public void SetUp()
        {
			stage = new Stage();
        }

		[Test]
	    public void AddPerformer_ThrowException_WhenNull()
	    {
			Performer nullPerformer = null;

			Assert.Throws<ArgumentNullException>(() =>
			{
				stage.AddPerformer(nullPerformer);
			});
		}

		[Test]
		public void AddPerformer_ThrowException_WhenAgeIsBelow18()
		{
			Performer performer = new Performer("Ivan", "Ivanov", 16);

			Assert.Throws<ArgumentException>(() =>
			{
				stage.AddPerformer(performer);
			});
		}

		[Test]
		public void AddPerformer_ShoudlWork()
		{
			Performer performer = new Performer("Ivan", "Ivanov", 19);

			stage.AddPerformer(performer);
			Assert.That(stage.Performers.Count, Is.EqualTo(1));
		}


		[Test]
		public void AddSong_ThrowException_WhenNull()
		{
			Song nullSong = null;

			Assert.Throws<ArgumentNullException>(() =>
			{
				stage.AddSong(nullSong);
			});
		}

		[Test]
		public void AddPerformer_ThrowException_WhenSongIsShort()
		{
			Song song = new Song("Name", new TimeSpan(0,0,30));

			Assert.Throws<ArgumentException>(() =>
			{
				stage.AddSong(song);
			});
		}

		/*[Test]
		public void AddSong_ShoudlWork()
		{
			Song song = new Song("Name",new TimeSpan(0,1,30));

			stage.AddSong(song);
			Assert.That(stage., Is.EqualTo(1));
		}*/

		[Test]
		public void AddSongToPerformer_ThrowException_WhenNullSong()
		{
			string performerName = "Name";
			string songName = null;

			Assert.Throws<ArgumentNullException>(() =>
			{
				stage.AddSongToPerformer(songName, performerName);
			});
		}

		[Test]
		public void AddSongToPerformer_ThrowException_WhenNullPerformer()
		{
			string performerName = null;
			string songName = "Name";

			Assert.Throws<ArgumentNullException>(() =>
			{
				stage.AddSongToPerformer(songName, performerName);
			});
		}

		[Test]
		public void AddSongToPerformer_ThrowException_WhenGetPerformerFails()
		{
			Performer performer = new Performer("Ivan", "Ivanov", 19);
			stage.AddPerformer(performer);
			Song song = new Song("Name", new TimeSpan(0, 1, 30));
			stage.AddSong(song);
			string songName = "Name";

			Assert.Throws<ArgumentException>(() =>
			{
				stage.AddSongToPerformer(songName, "Valio");
			});
		}

		[Test]
		public void AddSongToPerformer_ThrowException_WhenGetSongFails()
		{
			Performer performer = new Performer("Ivan", "Ivanov", 19);
			stage.AddPerformer(performer);
			Song song = new Song("Name", new TimeSpan(0, 1, 30));
			stage.AddSong(song);

			Assert.Throws<ArgumentException>(() =>
			{
				stage.AddSongToPerformer("OtherName", performer.FullName);
			});
		}

		[Test]
		public void AddSongToPerformer_ShouldWork()
		{
			Performer performer = new Performer("Ivan", "Ivanov", 19);
			stage.AddPerformer(performer);
			Song song = new Song("Name", new TimeSpan(0, 1, 30));
			stage.AddSong(song);

			stage.AddSongToPerformer(song.Name, performer.FullName);

			Assert.That(performer.SongList[0], Is.EqualTo(song));
		}

		[Test]
		public void AddSongToPerformer_ShouldReturnMessage()
		{
			Performer performer = new Performer("Ivan", "Ivanov", 19);
			stage.AddPerformer(performer);
			Song song = new Song("Name", new TimeSpan(0, 1, 30));
			stage.AddSong(song);

			string result = stage.AddSongToPerformer(song.Name, performer.FullName);

			Assert.That(result, Is.EqualTo($"{song} will be performed by {performer}"));
		}

		[Test]
		public void Play_ShouldWork()
        {
			Performer performer = new Performer("Ivan", "Ivanov", 19);
			stage.AddPerformer(performer);
			Song song = new Song("Name", new TimeSpan(0, 1, 30));
			stage.AddSong(song);

			stage.AddSongToPerformer(song.Name, performer.FullName);
			string result = stage.Play();

			Assert.That(result, Is.EqualTo($"{1} performers played {1} songs"));
		}
	}
}