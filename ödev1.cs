using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
   
}
interface Hareket
{
    void HızlıGit();
    void DenizdeYüz();
    void HavadaUç();
}
class BMW : Hareket
{
    public void HızlıGit()
    {
        Console.WriteLine("BMW çok hızlı gider . ");
    }
    public void DenizdeYüz()
    {
        Console.WriteLine("BMW denizde yüzer. ");
    }
    public void HavadaUç()
    {
        Console.WriteLine("BMW havada uçar.");
    }
}
class Mercedes : Hareket
{
    public void HızlıGit()
    {
        // Mercedes hızlı gitme özelliğine sahip değil.
    }
    public void DenizdeYüz()
    {
        Console.WriteLine("Mercedes denizde yüzer.");
    }
    public void HavadaUç()
    {
        Console.WriteLine("Mercedes havada uçar.");
    }
}
class Porsche : Hareket
{
    public void HızlıGit()
    {
        // Porsche hızlı gitme özelliğine sahip değil.
    }
    public void DenizdeYüz()
    {
        // Porsche denizde yüzme özelliğine sahip değil.
    }
    public void HavadaUç()
    {
        Console.WriteLine("porsche havada uçar. ");
    }
}
class Program
{
    static void Main()
    {
        Hareket bmw = new BMW();
        Hareket mercedes = new Mercedes();
        Hareket porsche = new Porsche();
        Console.WriteLine("BMW'nin hareket özellikleri:");
        bmw.HızlıGit();
        bmw.DenizdeYüz();
        bmw.HavadaUç();

        Console.WriteLine("Mercedes'in hareket özellikleri:");
        mercedes.DenizdeYüz();
        mercedes.HavadaUç();

        Console.WriteLine("Porsche'nin hareket özellikleri:");
        porsche.HavadaUç();
        Console.ReadLine();
    }
}
