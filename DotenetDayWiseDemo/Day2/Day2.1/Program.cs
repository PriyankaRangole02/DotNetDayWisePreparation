using System.Reflection;

namespace Day2._1
{
    //Abstract Concrete Sealed partial static ==>type of classes in c#
    class Person
    {
        #region various way to define properties
        #region java or c++ way
        // private string Name;   

        //public void setName(string name)
        //{
        //    this.Name = name;
        //}
        //public string getName(string name)
        //{
        //    return name;
        //}
        #endregion
        #region c# way
        //public string address { get; set; }
        //ctor propfull prop shortcuts

        private int pincode;

        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }
        public string Name { get; set; }
        #endregion
        #endregion
        #region Constructor
        //types=>Default,parametrised,copy,static,private
        #region Copy constructor

        public Person()
        {
            this.Name = "priyanka";
        }
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(Person obj)
        {
            this.Name = obj.Name;

        }
        #endregion
        #region Static Constructor
        //access modifier are not allowed in static,must be parameterless
        //overloading not possible in case of static
        //static Person(int x)  //error
        //{
        //}
        static Person()
        {

        }

        #endregion

        #endregion


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //Console.WriteLine( p.Name);

            // Person p1 = new Person(p);
            // Console.WriteLine(p1.Name);
            // p1.Name = "jyoti";
            // Console.WriteLine(p1.Name);

            Person person = new Person();
            person.Name = "priyanka";
            person.Pincode = 1011;
           



        }
    }
}
