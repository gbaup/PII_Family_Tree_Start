namespace Library
{
  public class OldestChildVisitor : IVisitor<Person>
  {
    public int OldestAge { get; private set; } = 0;

    public void Visit(Node<Person> node)
    {
      if (node.Children.Count == 0)
      {
        if (node.Data.Age > OldestAge)
        {
          OldestAge = node.Data.Age;
        }
      }

      foreach (var child in node.Children)
      {
        Visit(child);
      }
    }
  }
}
