using System.Text.RegularExpressions;

namespace Domain.Notes
{
    public class Note
    {
        public int Id { get; protected set; }

        public string Text { get; private set; }

        public Note(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public Note(string text)
        {
            Text = text;
        }

        public void ChangeText(string text)
        {
            Text = text;
        }
    }
}
