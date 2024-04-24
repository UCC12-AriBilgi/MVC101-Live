using P08_MVCSample.Models;

namespace P08_MVCSample.Data
{
    public class CarData
    {
        // Verileri bir liste yapısı şeklinde manuel tutacağım

        public static List<Car> Cars = new List<Car>()
        {
            new Car
            {
               CarID=1,
               BrandName="Volvo",
               Family="XC70",
               Year=1995
            },
            new Car
            {
               CarID=2,
               BrandName="Volvo",
               Family="XC90",
               Year=1995
            },
            new Car
            {
               CarID=3,
               BrandName="Renault",
               Family="Renault 19",
               Year=1995
            },
            new Car
            {
               CarID=4,
               BrandName="Volkswagen",
               Family="Beetle",
               Year=1974
            },
            new Car
            {
               CarID=5,
               BrandName="Bugatti",
               Family="Veyron",
               Year=2010
            },
            new Car
            {
               CarID=6,
               BrandName="Anadol",
               Family="Hitit",
               Year=1970
            },
            new Car
            {
               CarID=7,
               BrandName="Seat",
               Family="Ibiza",
               Year=2004
            }
        };

    }
}
