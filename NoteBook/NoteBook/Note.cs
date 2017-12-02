using System;
using System.Text;

namespace NoteBook
{
  /// <summary>
  /// This class of note in notebook. This class has fieldes data, title of note and datetime of creating.
  /// </summary>
  public class Note
  {
    public DateTime Time { get; set; }
    public String Title { get; set; }
    public String Data { get; set; }

    /// <summary>
    /// Constructor for Note
    /// </summary>
    /// <param name="title">Titile of note</param>
    /// <param name="data">Data of note</param>
    public Note(String title, String data)
    {
      Title = title;
      Data = data;
      Time = DateTime.Now;
    }

    /// <summary>
    /// Override method ToString for this class
    /// </summary>
    /// <returns>String with all data of fields of this value</returns>
    public override String ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(Time);
      stringBuilder.Append("\n");
      stringBuilder.Append(Title);
      stringBuilder.Append("\n");
      stringBuilder.Append(Data);
      stringBuilder.Append("\n");
      return stringBuilder.ToString();
    }

    /// <summary>
    /// Override method GetHashCode for this class
    /// </summary>
    /// <returns>Identification number of this note</returns>
    public override int GetHashCode()
    {
      return this.ToString().GetHashCode();
    }

    /// <summary>
    /// Override method Equals for this class
    /// </summary>
    /// <param name="obj">object with which we want compare</param>
    /// <returns></returns>
    public override bool Equals(object obj)
    {
      return this.GetHashCode().Equals(obj.GetHashCode());
    }
  }
}
