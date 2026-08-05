class Class1
{
    //we can remove virtual keyword and add new keyword in the display method of Class2 to hide the base class method
    public virtual void display()
    {
        Console.WriteLine("Super class display method");

    }
}
class Class2 : Class1
{
    //we can use new keyword to hide the base class method
    public override void display()
    {
        Console.WriteLine("Sub class display method");
    }
}
class Program
{
    static void Main(String[] args)
    {
        Class1 obj = new Class2();
        obj.display();
        Console.ReadKey();
    }
}

