using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class EngineConcrete : Producer
    {
        public override void MakeDemand(PlaneMessage message)
        {
            if (message.Budget >= 10000)
            {
                Console.WriteLine("Model :" + message.Model + "Year:" + message.Year + "Airline :" + message.Airline + " " + "Motor icin islem onaylandi\n");
                producer.MakeDemand(message);
            }
            else if(producer != null)
            {
                Console.WriteLine("Model :" + message.Model + "Year:" + message.Year + "Airline :" + message.Airline + " " + "icin islem motor maliyetinden ötürü mümkün olmadıgı icin onaylanmadı\n");
                producer.MakeDemand(message);
            }
          
        }
    }
}
