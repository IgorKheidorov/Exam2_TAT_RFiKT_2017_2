
namespace TaskAboutStack
{
  /// <summary>
  /// Representation of element of stack.
  /// </summary>
  /// <typeparam name="Type">Type of value in the element.</typeparam>
  class Element<Type>
  {
    public Type value { get; }
    public Element<Type> next { get; set; }

    /// <summary>
    /// Default constructor.
    /// </summary>
    /// <param name="value"></param>
    public Element(Type value)
    {
      this.value = value;
    }

  }
}
