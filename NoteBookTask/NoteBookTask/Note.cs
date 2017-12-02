using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    public class Note
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime TimeOfCreating { get; set; }

        public Note()
        {
            Name = "";
            Text = "";
            TimeOfCreating = DateTime.UtcNow;
        }

        public Note(string name)
        {
            Name = name;
            Text = "";
            TimeOfCreating = DateTime.UtcNow;
        }

        public override bool Equals(object obj)
        {
            bool areEquals;
            if (obj == null)
            {
                areEquals = false;
            }

            Note note = obj as Note;
            if (note as Note == null)
            {
                areEquals = false;
            }
            areEquals = (note.TimeOfCreating == this.TimeOfCreating) 
                        && (note.Name == this.Name)
                        && (note.Text == this.Text);

            return areEquals;
        }

        public override int GetHashCode()
        {
            return (int)(this.TimeOfCreating - new DateTime(1900, 1, 1)).TotalDays + 2;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Name + '\n');
            builder.Append(Text + '\n');
            builder.Append(TimeOfCreating);

            string information = builder.ToString();
            return information;
        }
    }
}