namespace SealedClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            A a1= new A();
            Console.WriteLine(a1.a);
           
        }
    }

    //abstract cannnot be sealed or static
    /*public  sealed class A
    {
       public int a = 10;
         virtual public  void Hello()  //useless to have virtual method // CS0549  
        {
            Console.WriteLine("hello");
        }
    }*/
    /*public class B : A  //sealed class cant inherted
    {

    }*/
    //A sealed class completed opposite from abstract class;
    //no abstract methods
    //can be wriiten bottom-most hierarchy
    //used specially to avoid further inheritance

    public class C
    {
        public  void Show() {   //by default very method acts
                               //like sealed if you not use virtual and abstract 
            Console.WriteLine("show");
        }
        public virtual void show1()
        {
            Console.WriteLine("C:show1");
        }
    }
    public class D : C
    {
        public sealed override void show1()
        {
            Console.WriteLine("D:show1");
        }
    }

    public class E : D
    {
        public  void show2()
        {
            E d = new E();
            d.show1();
        }
    }




}
