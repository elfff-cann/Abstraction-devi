using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev3
{
    internal class Program
    {
       
        
        }
    }

// Yakıt tüketimi hesaplama arayüzü
interface YakitTuketimi
{
    double YakitHarcama();
}
// ortak özellikleri taşıyan abstract sınıfı
abstract class Araba : YakitTuketimi
{
    public string Marka { get; set; }
    public double YakitTuketimi { get; set; }
    // 1 saatte tüketilen yakıt 
    public Araba(string marka, double YakitTuketimi)
    {
        Marka = marka;
        YakitTuketimi = yakitTuketimi;
        
    }
    public double YakitHarcama()
    {
        return YakitTuketimi;
    }
}
// BMW sınıfı
class BMW : Araba
{
    public BMW() : base("BMW", 80.0) { }
}
// Mercedes sınıfı
class Mercedes : Araba
{
    public Mercedes() : base("Mercedes", 70.0) { }
}
// Porsche sınıfı
class Porsche : Araba
{
    public Porsche() : base("Porsche", 60.0){}
        }
class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>
        {
            new BMW(),
            new Mercedes(),
            new Porsche(),
        };
        double toplamYakit = 0;
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"{araba.Marka} 1 saatte {araba.YakitHarcama()} L yakıt harcıyor.");
            toplamYakit += araba.YakitHarcama();
        }
        Console.WriteLine($"Toplam yakıt tüketimi: {toplamYakit} L");
        Console.ReadLine();
    }
}
    

// Diziler birden fazla değeri tek bir veri yapısında saklamamıza yardımcı olur. aynı türdeki verilere kolay erişim ve işlem yapmayı sağlar.
