namespace Ermehamistas
{
    public class HamisErme : Erme
    {
        public HamisErme()
        {
            System.Console.WriteLine("HamisErme konstruktor");
        }

        public override int feldobas()
        {
            System.Console.Write("HamisErme.feldobas()");
            return 0;
        }
    }
}