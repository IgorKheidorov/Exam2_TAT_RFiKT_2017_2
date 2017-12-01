namespace Test_3.Task_5
{
  class Node<Type>
  {
    private Type value;
    private Node<Type> next;

    public Node(Type value)
    {
      this.value = value;
      next = this;
    }

    public Node()
    {
      next = this;
    }

    public Type Value { get { return value; } set { this.value = value; } }
    public Node<Type> Next { get { return next; } set { next = value; } }
  }
}
