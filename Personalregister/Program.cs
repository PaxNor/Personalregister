
Employee[] staff;

while(true)
{
    Console.Write("Add employee 1. Print employees 2. ");
    string choice = Console.ReadLine();

    if(choice == "1")
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter salary: ");
        string s = Console.ReadLine();
        int salary = Int32.Parse(s);

        Employee e = new Employee(name, salary);

    }

    if(choice == "2")
    {
        // hann inte
    }
}