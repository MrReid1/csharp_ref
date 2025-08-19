using System;


class Program
{
    static void Main(String[] args)
    {

        //what i remember
        string fName = "Anastasios";
        string lName = "Rigatos";
        int? age;
        DateOnly bday = new DateOnly(1993, 7, 14);

        //check current date
        DateOnly today = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        //age calculation
        age = today.Year - bday.Year;


        Console.WriteLine($"Today date is : {today.ToString()}");
        Console.WriteLine("");
        Console.WriteLine($"Your birthday is : {bday.ToString()}");
        if (today == bday)
        {
            Console.WriteLine($"Happy Birthday {fName} {lName}!");
        }
        else
        {
            Console.WriteLine($"Hello {fName} {lName}, you are {age} years old.");
        }

        //Method overriding example
        Console.WriteLine("Method overriding");
        Dog dog = new Dog();
        dog.Speak();
        Cat cat = new Cat();
        cat.Speak();

        // Polymorphism example
        Console.WriteLine("Polymorphism");
        Animal doggie = new Dog();
        Animal kitty = new Cat();
        doggie.Speak();
        kitty.Speak();


        //for loop
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"This is iteration number {i}");
        }
        //while loop
        int j = 0;
        while (j < 10)
        {
            Console.WriteLine($"This is iteration number {j}");
            j++;
        }
        //do while loop
        int k = 0;
        do
        {
            Console.WriteLine($"This is iteration number {k}");
            k++;
        } while (k < 10);
        //for each loop
        string[] names = { "Anastasios", "John", "Mary" };
        foreach (string name in names)
        {
            Console.WriteLine($"Hello {name}");
        }


        //switch case example
        Console.WriteLine("Switch case example");
        int number = 2;
        switch (number)
        {
            case 1:
                Console.WriteLine("You selected option 1");
                break;
            case 2:
                Console.WriteLine("You selected option 2");
                break;
            case 3:
                Console.WriteLine("You selected option 3");
                break;
            default:
                Console.WriteLine("Invalid option selected");
                break;
        }

        //

        //linked list example
        Console.WriteLine("Linked List Example");
        LinkedList<string> linkedList = new LinkedList<string>();
        linkedList.AddLast("Anastasios");
        linkedList.AddLast("John");
        linkedList.AddLast("Mary");
        foreach (string name in linkedList)
        {
            Console.WriteLine($"Linked List Name: {name}");
        }
        //dictionary example
        Console.WriteLine("Dictionary Example");
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("Anastasios", 30);
        dictionary.Add("John", 25);
        dictionary.Add("Mary", 28);
        foreach (KeyValuePair<string, int> kvp in dictionary)
        {
            Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
        }

        //array example
        Console.WriteLine("Array Example");
        int[] numbersArray = { 1, 2, 3, 4, 5 };
        foreach (int numberInArray in numbersArray)
        {
            Console.WriteLine($"Number in array: {numberInArray}");
        }
    }


    public int AddSum(int a, int b)
    {
        return a + b;
    }
    public int AddSum(int a, int b, int c)
    {
        return a + b + c;
    }


}

//01. Method overriding
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

//02. Method overriding
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog speaks");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat speaks");
    }
}