using AutoFixture;
using Domain.Notes;

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
            //Arange
            var id = Fixture.Create<int>();
            var text = Fixture.Create<string>();

            //Act
            var note = new Note(id,text);

            //Assert
            Assert.Equal(id, note.Id);
            Assert.Equal(text, note.Text);
        }

        [Fact]
        public void Ctor_GivenTextIsNull_Throws()
        {
            //Assert
            Assert.Throws<ArgumentNullException>("text", () => new Note(null));
        }

        [Fact]
        public void ChangeText()
        {
            //Arrange
            var note = Fixture.Create<Note>();
            var expected = Fixture.Create<string>();

            //Act
            note.ChangeText(expected);

            //Assert
            Assert.Equal(expected, note.Text);
        }

        [Fact]
        public void ChangeText_GivenTextIsNull_Throws()
        {
            //Arrange
            var note = Fixture.Create<Note>();

            //Act
            void Act() => note.ChangeText(null);

            //Assert
            Assert.Throws<ArgumentNullException>("text", Act);
        }
    }
}