namespace Library
{
  public class AgeSumVisitor : IVisitor<Person>
  {
    public int TotalAge { get; private set; }

    public void Visit(Node<Person> node)
    {
      TotalAge += node.Data.Age;
      foreach (var child in node.Children)
      {
        Visit(child);
      }
    }
  }
}
