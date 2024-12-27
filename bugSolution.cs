public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = new MyClass(10);

        // Correct comparison
        if (obj1.MyProperty == obj2.MyProperty)
        {
            Console.WriteLine("Objects have equal MyProperty values");
        }
        else
        {
            Console.WriteLine("Objects have different MyProperty values");
        }

        //Another approach using Equals method (requires override)
        //Override Equals method in MyClass class
        // public override bool Equals(object obj) { ... }
        //if(obj1.Equals(obj2))
        //{
        //    Console.WriteLine("Objects are equal");
        //}
    }
}