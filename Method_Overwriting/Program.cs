class Class1
{
    public virtual void display()
    {
        Console.WriteLine("Super class display method");

    }
}
class Class2 : Class1
{
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