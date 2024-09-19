namespace ClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Car audi = new Car("A3","Audi", false);
           // audi.Drive();

           // Car bmw = new Car("i7", "BMW", true);
           // bmw.Drive();

           //Customer myCustomer = new Customer();
           // myCustomer.setDetails("Dylon", "Anggun City", "1783174");

           // Console.WriteLine($"My name is {myCustomer.Name} and I live in {myCustomer.Address} and my contact no is {myCustomer.ContactNumber}");



            //Console.WriteLine("Brand " + audi.Brand);
            //Console.WriteLine("Brand " + bmw.Brand);

            //Customer dylon = new Customer("Dylon");
            //Customer member1 = new Customer("Vivienne", "Sri Petaling", "0123456789");

            //Console.WriteLine("Name is " +dylon.Name);
            //Console.WriteLine("Name is " +member1.Name +" Street is "+member1.Address+" Contact No is "+member1.ContactNumber);

            //Car car = new Car();
            //Car car2 = new Car();
            //Car car3 = new Car("A3","Audi",false);

            //Console.WriteLine("Number of cars is " + Car.NumberOfCars);

            Customer customer1 = new Customer();
            Customer customer2 = new Customer("Dylon");

            customer1.GetDetails();

            customer2.Password = "Dylon@1995";
            customer2.GetDetails();

            Rectangle rectangle1 = new Rectangle("Red");
            Rectangle rectangle2 = new Rectangle("Blue");

            rectangle1.DisplayDetails();
            rectangle2.DisplayDetails();



            Console.ReadKey();
        }
    }
}
