namespace OopsBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportFactory reportFactory = new ReportFactory(); Console.WriteLine("1.Docs 2.XML 3.Json 4.Pdf"); int choice = Convert.ToInt32(Console.ReadLine()); Logger.CurrentLogger.Log("choice is given" + choice); Report report = reportFactory.GetReport(choice); Logger.CurrentLogger.Log("Calling generating report"); report.GenerateReport();

        }
    }

    //Inhertance: report the abstract class which define common struct of all report type
    //Abstraction: user will work on Report without needing to know the details of how each type of report 
    //genrated,created,parsed,saved
    public abstract class Report
    {
        protected abstract void CreateReport();
        protected abstract void ParseReport();
        protected abstract void ValidateReport();
        protected abstract void SaveReport();

        public virtual void GenerateReport()
        {
            CreateReport();
            ParseReport();
            ValidateReport();
            SaveReport();
        }



    }
    public abstract class SpecialReport : Report
    {
        protected abstract void ReValidateReport();
        public override void GenerateReport()
        {
            CreateReport();
            ParseReport();
            ValidateReport();
            ReValidateReport();
            SaveReport();
        }
    }


    public class PDF : Report
    {
        protected override void CreateReport()
        {
            Console.WriteLine("pdf created");
        }

        protected override void ParseReport()
        {
            Console.WriteLine(" pdf parse report created");
        }

        protected override void SaveReport()
        {
            Console.WriteLine("PDF saved");
        }


        protected override void ValidateReport()
        {
            Console.WriteLine(" PDF validate report  created");
        }
    }

    public class XML : Report
    {
        protected override void CreateReport()
        {
            Console.WriteLine("XML created");
        }

        protected override void ParseReport()
        {
            Console.WriteLine(" XML parse created");
        }

        protected override void SaveReport()
        {
            Console.WriteLine(" XML saved");
        }


        protected override void ValidateReport()
        {
            Console.WriteLine(" XML validate report created");
        }
    }
   // polymorphism  overrides generateReport when instance called on docx class
    public class Docx : Report
    {
        protected override void CreateReport()
        {
            Console.WriteLine("DOCX created");
        }

        protected override void ParseReport()
        {
            Console.WriteLine("Docx parse report created");
        }

        protected override void SaveReport()
        {
            Console.WriteLine(" Docx saved");
        }


        protected override void ValidateReport()
        {
            Console.WriteLine(" Docx validate report created");
        }
    }


    //json inherited specialReport but specialReport has GenerateReport which override from Report..it also
    //override by json when json object is called
    public class Json : SpecialReport
    {
        protected override void CreateReport()
        {
            Console.WriteLine("json  Create completed");
        }

        protected override void ParseReport()
        {
            Console.WriteLine(" Parse json completed");
        }

        protected override void ReValidateReport()
        {
            Console.WriteLine("  revalidate json completed");
        }

        protected override void SaveReport()
        {
            Console.WriteLine(" save json completed");
        }

        protected override void ValidateReport()
        {
            Console.WriteLine("json  validate completed");
        }
    }

    //Encapsulation
    //one logger object used 
    //singlton pattern
    //The Logger class encapsulates the logging functionality
    public class Logger
    {

        private static Logger logger = new Logger();

        private Logger()
        {
            Console.WriteLine("logs object created");
        }
        public static Logger CurrentLogger
        {
            get { return logger; }
        }

        public void Log(string message)
        {
            Console.WriteLine("created" + DateTime.Now.ToString() + "messsage" + message);
        }
    }

    public class ErrorReport
    {
        private string message;
        public ErrorReport(string message)
        {
            this.message = message;
        }
    }

    public class ReportFactory
    {
        public Report GetReport(int choice)
        {
            if (choice == 1)
            {
                return new Docx();
            }

            else if (choice == 2)
            {
                return new XML();
            }


            else if (choice == 3)
            {
                return new Json();
            }
            else
            {
                return new PDF();
            }





        }
    }





}