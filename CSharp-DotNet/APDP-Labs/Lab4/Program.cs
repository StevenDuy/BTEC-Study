namespace Lab4
{
    internal class Program
    {
        delegate int ComparisonDelegate(Person p1, Person p2);
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person("John", 25),
                new Person("Jane", 30),
                new Person("Bob", 35),
            };
            ComparisonDelegate compareByName = (p1, p2) => p1.Name.CompareTo(p2.Name);
            ComparisonDelegate compareByAge = (p1, p2) => p2.Age.CompareTo(p1.Age);
            Console.WriteLine("Sorting by Name:");
            SortAndDisplay(people, compareByName);
            Console.WriteLine("\nSorting by Age:");
            SortAndDisplay(people, compareByAge);
        }
        static void SortAndDisplay(List<Person> people, ComparisonDelegate comparison)
        {
            var sortedPeople = people.OrderBy(p => p, Comparer<Person>.Create((p1, p2) => comparison(p1, p2))).ToList();
            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
        }
    }
}