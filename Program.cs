// See https://aka.ms/new-console-template for more information
Up1();
 static void Up1()
{
    List<double> lista = new List<double>();
    lista.Add(5);
    lista.Add(6.5);
    lista.Add(5.2);
    lista.Add(5.4);
    lista.Add(5.6);
    lista.RemoveAt(2);
    foreach(double element in lista)
        Console.WriteLine(element);
}
double Medel(){
    foreach(double element in lista)
        Console.WriteLine(element);
}