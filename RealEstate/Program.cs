// See https://aka.ms/new-console-template for more information
using RealEstate;

List<Ad> ads = Ad.LoadFromCsv("realestates.csv");

double osszeg = 0;
int db = 0;
foreach (Ad ad in ads)
{
    if (ad.Floors == 0)
    {
        osszeg += ad.Area;
        db++;
    }
}

Console.WriteLine($"1. Földszinti ingatlanok átlagos alapterülete: {Math.Round(osszeg / db, 2)}");