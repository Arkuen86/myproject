namespace Domain.Notes
{
    public class Note
    {
        public int Id { get; protected set; }

        public string Text { get; private set; }

        public Note(string text)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public Note(int id, string text)
        {
            Id = id;
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }        

        public void ChangeText(string text)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }
    }
}
