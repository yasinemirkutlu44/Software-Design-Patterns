using System;
using System.Numerics;

namespace ChainOfResponsibility
{
    class Program
    {
        public static void Main(string[] args)
        {
            Producer engineProducer = new EngineConcrete();
            Producer gearProducer = new GearConcrete();
            Producer wingProducer = new WingConcrete();
 
            engineProducer.BuildChain(wingProducer);
            wingProducer.BuildChain(gearProducer);

            PlaneMessage planeMessage = new PlaneMessage("Boeing 737", "2015", "Türk Hava Yollar",8000);
            engineProducer.MakeDemand(planeMessage);

            planeMessage = new PlaneMessage("Boeing 737", "2017", "Türk Hava Yollar", 1000);
            engineProducer.MakeDemand(planeMessage);

            planeMessage = new PlaneMessage("Boeing 737", "2018", "Türk Hava Yollar", 50000);
            engineProducer.MakeDemand(planeMessage);

            planeMessage = new PlaneMessage("Boeing 737", "2019", "Türk Hava Yollar", 20000);
            engineProducer.MakeDemand(planeMessage);


        }
    }
}
