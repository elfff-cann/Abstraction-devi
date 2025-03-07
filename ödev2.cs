using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2
{
    internal class Program
    {
        
        
        }
    }

interface Calisan
{
    double MaasinizNedir();
}
// Genek Müdür sınıfı
class GenelMudur : Calisan
{
    public double MaasinizNedir()
    {
        return 80000;
    }
}
// Müdür sınıfı
class Mudur : Calisan
{
    public double MaasinizNedir()
    {
        return 60000;
    }
}
// Programcı sınıf 
class Programci : Calisan
{
    public double MaasinizNedir()
    {
        return 40000;
    }
}
// Stajyer sınıfı
class Stajyer : Calisan
{
    public double MaasinizNedir()
    {
        return 5000;
    }
}
// Ana program sınıfı
class Program
{
    static void Main()
    {
        List<Calisan> calisanlar = new List<Calisan>
        {
            new GenelMudur(),
            new Mudur(),
            new Programci(),
            new Stajyer(),
        };
        double toplamMaas = 0;
        foreach (Calisan calisan in calisanlar)
        {
            toplamMaas += calisan.MaasinizNedir();
        }
        Console.WriteLine("Toplam Maaş:" + toplamMaas);
        Console.ReadLine();
    }
}
            
            
