using System;


namespace DemoFileIO_ObjectWrite
{
    [Serializable]
    public class Emp
    {
        private int _No;
        private string _Name;
        private string _Address;

        [NonSerialized]
      private string _Password = "abc@123";

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int No
        {
            get { return _No; }
            set { _No = value; }
        }
    }
}
