using Domain.Notes;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using static System.Net.Mime.MediaTypeNames;

namespace UnitTests.Domain.Notes
{
    public class NoteTest
    {
        [Fact]
        public void Ctor()
        {
            Note mynote = new Note("txt");
        }

        [Fact]
        public void ChangeText()
        {
            string txt = "abc";
            Note mynote = new Note("txt");
            mynote.Text = txt;
            string rez = mynote.Text;
            AssertionRequirement.Equals(txt, rez);
        }

        [Fact]
        public void del_doublSpace()
        {
            string txt = "a    c";
            Note mynote = new Note(txt);
            string rez = mynote.delDoubleSpaceText(txt);
            AssertionRequirement.Equals("a c", rez);
        }


    }
}