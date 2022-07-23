namespace HelloWorld
{
    internal class Person
    {
        public string FirstName
        { get; set; }
        public string LastName
        { get; set; }

        public void Introduce()
        {
            System.Console.WriteLine("Hello, my name is {0} {1}", FirstName, LastName);
        }
    }
}
