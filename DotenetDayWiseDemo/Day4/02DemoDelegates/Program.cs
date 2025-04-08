namespace _02DemoDelegates
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            // Create a candidate instance
            JobCandidate candidate = new JobCandidate();
            candidate.Name = "Aarav";

            // Define event handlers using the delegate
            JobResultHandler onAccepted = new JobResultHandler(OnJobOfferAccepted);
            JobResultHandler onRejected = new JobResultHandler(OnJobOfferRejected);

            // Subscribe the handlers to the candidate's events
            candidate.JobOfferAccepted += onAccepted;
            candidate.JobOfferRejected += onRejected;

            Console.WriteLine("Enter your qualification (e.g., 'BTech' or '12th'):");

            // Simulate the job application process
            candidate.ApplyForJob(Console.ReadLine());

            Console.ReadLine(); // Keep console open
        }

        // Event handler for job acceptance
        public static void OnJobOfferAccepted()
        {
            Console.WriteLine("Congratulations! You've been hired! Time to celebrate!");
        }

        // Event handler for job rejection
        public static void OnJobOfferRejected()
        {
            Console.WriteLine("Sorry, you didn’t qualify this time. Keep trying!");
        }
    }

    // Delegate definition for job result handlers
    public delegate void JobResultHandler();

    // JobCandidate class with events
    public class JobCandidate
    {
        // Events based on the delegate
        public event JobResultHandler JobOfferAccepted;
        public event JobResultHandler JobOfferRejected;

        private string _name;

        // Property for candidate's name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Method to simulate applying for a job
        public void ApplyForJob(string qualification)
        {
            Console.WriteLine($"{Name} is applying for the job with qualification: {qualification}");

            // Simple logic to determine job outcome
            if (qualification.ToLower() == "btech") // Case-insensitive check
            {
                // Raise the JobOfferAccepted event if qualification matches
                if (JobOfferAccepted != null)
                {
                    JobOfferAccepted();
                }
            }
            else
            {
                // Raise the JobOfferRejected event otherwise
                if (JobOfferRejected != null)
                {
                    JobOfferRejected();
                }
            }
        }
    }
}

