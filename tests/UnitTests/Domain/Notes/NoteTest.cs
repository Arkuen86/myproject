using AutoFixture;
using Domain.Notes;
using static System.Net.Mime.MediaTypeNames;

namespace UnitTests.Domain.Notes
{
    public class NoteTest
    {
        private static readonly Fixture Fixture =  new Fixture();

        [Fact]
        public void Ctor()
        {
            //Arange
            var text = Fixture.Create<string>();

            //Act
            var note = new Note(text); 

            //Assert
            Assert.Equal(text, note.Text);
        }

        [Fact]
        public void Ctor_WithId()
        {
        }

        [Fact]
        public void Ctor_GivenTextIsNull_Throws()
        {
            //Assert
            Assert.Throws<ArgumentNullException>(text, note.Text);
        }

        [Fact]
        public void ChangeText()
        {
        }

        [Fact]
        public void ChangeText_GivenTextIsNull_Throws()
        {
        }

    }
}