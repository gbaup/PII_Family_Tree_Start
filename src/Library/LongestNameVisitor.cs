namespace Library
{
  public class LongestNameVisitor : IVisitor<Person>
  {
    public string LongestName { get; private set; } = string.Empty;

    public void Visit(Node<Person> node)
    {
      if (node.Data.Name.Length > LongestName.Length)
      {
        LongestName = node.Data.Name;
      }

      foreach (var child in node.Children)
      {
        Visit(child);
      }
    }
  }
}
