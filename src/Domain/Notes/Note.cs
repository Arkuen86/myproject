using System.Text.RegularExpressions;

namespace Domain.Notes
{
    public class Note
    {
        protected int id;
        private string text;

        public Note (string text)
        {
            this.text = text;
        }

        public int Id { get { return id; } }

        public string Text { 
            get { 
                return text; 
            }
            set
            {
                this.text = value;
            }
        }
        public string delDoubleSpaceText (string text)
        {
            string result = Regex.Replace(text, @"\s+", " ");
            return result;
        }
    }
}
