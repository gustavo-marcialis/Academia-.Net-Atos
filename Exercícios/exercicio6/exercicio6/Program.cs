namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parafuso A
            int cd_parafusoa = 0001;
            int qt_parafusoa = 30;
            int vl_parafusoa = 50;
            int vl_ipiparafusoa = 10;

            //parafuso B
            int cd_parafusob = 0002;
            int qt_parafusob = 50;
            float vl_parafusob = 75;
            int vl_ipiparafusob = 12;

            Console.WriteLine("PARAFUSO A");
            Console.WriteLine("Código: " + cd_parafusoa);
            Console.WriteLine("Quantidade: " + qt_parafusoa);
            Console.WriteLine("Valor Unitário: " + vl_ipiparafusoa);
            Console.WriteLine("IPI: " + vl_ipiparafusoa + "% \r\n");

            Console.WriteLine("PARAFUSO B");
            Console.WriteLine("Código: " + cd_parafusob);
            Console.WriteLine("Quantidade: " + qt_parafusob);
            Console.WriteLine("Valor Unitário: " + vl_ipiparafusob);
            Console.WriteLine("IPI: " + vl_ipiparafusob + "%");


            

        }
    }
}