namespace Scratchpad
{
  public partial class Note
  {
    /// <summary>
    /// The fields comparison of two objects of Note type
    /// </summary>
    /// <param name="obj">Object wich we want to compare</param>
    /// <returns> True if the objects are equals. False - if the obj from parameters is null or not equils </returns>
    public override bool Equals(object obj)
    {
      if (obj == null)
      {
        return false;
      }
      Note note = (Note)obj;
      return (Record == note.Record && Date == note.Date);
    }

    /// <summary>
    /// For representing Note in string format
    /// </summary>
    /// <returns>String representation of Note</returns>
    public override string ToString()
    {
      if (string.IsNullOrEmpty(Record))
      {
        return Date.ToString();
      }
      else
      {
        return Record.ToString() + Date.ToString();
      }
    }

    /// <summary>
    /// For getting hashCode
    /// </summary>
    /// <returns>Get hash of Note</returns>
    public override int GetHashCode()
    {
      unchecked
      {
        int hash = 17;
        hash = hash * HASHNUMBER + Record.GetHashCode();
        hash = hash * HASHNUMBER + Date.GetHashCode();
        return hash;
      }
    }
  }
}
