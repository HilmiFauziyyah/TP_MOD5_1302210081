// See https://aka.ms/new-console-template for more information
internal class Program
{
    public class HaloGeneric
    {
        public static void sapaUser<H>(H inputuser)
        {
            Console.WriteLine("Hallo user " + inputuser);
        }
    }
    public class DataGeneric<H>
    {
        private H data;
        public DataGeneric(H data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data Yang Tersimpan Adalah: " + data);
        }
    }
    private static void Main(string[] args)
    {
        HaloGeneric.sapaUser<string>("Hilmi Fauziyyah");
        DataGeneric<string> nim = new DataGeneric<string>("1302210081");
        nim.PrintData();
    }
}
