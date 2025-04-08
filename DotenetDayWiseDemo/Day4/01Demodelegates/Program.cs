using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace _01Demodelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Candidate c = new Candidate();
            c.Name = "priya";
            
            //define event handler using the delegates
            jobResulthandler onAccepted = new jobResulthandler(OnJobOfferAccepted);
            jobResulthandler onRejected = new jobResulthandler(OnJobOfferRejected);

            //now subscibe the event to the candidates event
            c.JobOfferAccepted += onAccepted;
            c.JobOfferRejected += onRejected;

            Console.WriteLine("Enter the job Qualification (e.g, 'Btech");
            c.ApplyForJob(Console.ReadLine());
            Console.ReadLine();

           
        }
        //event handler
        public static void OnJobOfferAccepted()
        {
            Console.WriteLine("Congratulations! you hv been hired");
        }
        public static void OnJobOfferRejected()
        {
            Console.WriteLine("Sorry! you didnt qualify this time");
        }
    }
    //public delegate void EventHandler(object sender, EventArgs e);
    public delegate void jobResulthandler();


    public class Candidate
    {
        public event jobResulthandler JobOfferAccepted;
        public event jobResulthandler JobOfferRejected;

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void ApplyForJob(string qualification)
        {
            Console.WriteLine($"{Name} applying for job with qualification {qualification}");
            if(qualification=="btech")
            {
                if(JobOfferAccepted!=null)
                JobOfferAccepted();
            }
            else
            {
                if(JobOfferRejected!=null)
                {
                    JobOfferRejected();
                }
            }
        }
    }
}
