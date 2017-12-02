using System;
using System.Text;

namespace NoteBookProject
{
    /// <summary>
    /// Element of the notebook, consisting of title, creating date and content
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Notes title
        /// </summary>
        public string Title
        {
            get;private set;
        }
        /// <summary>
        /// Notes creating time
        /// </summary>
        public DateTime CreatingTime
        {
            get;private set;
        }
        /// <summary>
        /// Notes content
        /// </summary>
        public string Content
        {
            get;private set;
        }
        /// <summary>
        /// Constructor with title and content
        /// </summary>
        /// <param name="title">title of note</param>
        /// <param name="content">notes content</param>
        public Note(string title, string content)
        {
            Title = title;
            Content = content;
            CreatingTime = DateTime.Now;
        }
        /// <summary>
        /// Constructor with title, content and creating time
        /// </summary>
        /// <param name="title">title of note</param>
        /// <param name="content">notes content</param>
        /// <param name="creatingTime">notes creating time</param>
        public Note(string title, string content, DateTime creatingTime)
        {
            Title = title;
            Content = content;
            CreatingTime = creatingTime;
        }
        /// <summary>
        /// Overrides the receive hash code
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return Title.GetHashCode() + Content.GetHashCode() + CreatingTime.GetHashCode();
        }
        /// <summary>
        /// compares objects by hash code
        /// </summary>
        /// <param name="obj">comparing object</param>
        /// <returns>is objects equals</returns>
        public override bool Equals(object obj)
        {
            return ( GetHashCode() == obj.GetHashCode() );
        }
        /// <summary>
        /// Builds a string representation of the class
        /// </summary>
        /// <returns>string representation of the class</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(CreatingTime);
            builder.AppendLine();
            builder.Append(Title);
            builder.AppendLine();
            builder.Append(Content);
            builder.AppendLine();
            return builder.ToString();
        }
    }
}
