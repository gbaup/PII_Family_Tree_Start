using System;
using Library;

namespace Program
{
    class Program
    {

        static void Main(string[] args)
        {

            //PARTE 2
            var rootNode = new Node<Person>(new Person("Abuelo", 78));
            var parent1Node = new Node<Person>(new Person("Padre", 50));
            var parent2Node = new Node<Person>(new Person("Madre", 48));
            var child1Node = new Node<Person>(new Person("Hijo", 30));
            var child2Node = new Node<Person>(new Person("Hija", 28));
            var grandchild1Node = new Node<Person>(new Person("Nieto", 5));
            var grandchild2Node = new Node<Person>(new Person("Nieta", 3));

            rootNode.AddChild(parent1Node);
            rootNode.AddChild(parent2Node);
            parent1Node.AddChild(child1Node);
            parent1Node.AddChild(child2Node);
            child1Node.AddChild(grandchild1Node);
            child2Node.AddChild(grandchild2Node);

            //PARTE 3
            AgeSumVisitor visitor = new AgeSumVisitor();
            rootNode.Accept(visitor);

            Console.WriteLine($"La suma total de las edades es: {visitor.TotalAge}");

            //PARTE 4
            OldestChildVisitor oldestChildVisitor = new OldestChildVisitor();
            rootNode.Accept(oldestChildVisitor);

            Console.WriteLine($"La edad del hijo más grande es: {oldestChildVisitor.OldestAge}");

            LongestNameVisitor longestNameVisitor = new LongestNameVisitor();
            rootNode.Accept(longestNameVisitor);

            Console.WriteLine($"El nombre más largo es: {longestNameVisitor.LongestName}");


        }
    }
}
