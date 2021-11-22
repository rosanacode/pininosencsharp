class Problema01
{
    static void Main(string[] args)
    {
        int n1, n2, s,c,r;

        System.Console.Write("Numero 1: ");
        n1 = int.Parse(System.Console.ReadLine());
        System.Console.Write("Numero 2: ");
        n2 = int.Parse(System.Console.ReadLine());

        s = n1 + n2;
        c = n1 / n2;
        r= n1 % n2;

        System.Console.WriteLine("");
        System.Console.WriteLine("Suma: " + s);
        System.Console.WriteLine("Cociente: " + c);
        System.Console.WriteLine("Residuo: " + r);
        System.Console.ReadLine();
    }
}
