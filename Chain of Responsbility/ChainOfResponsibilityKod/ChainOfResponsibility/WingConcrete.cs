using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class WingConcrete : Producer
    {
        public override void MakeDemand(PlaneMessage message)
        {
            if(message.Budget >= 15000)
            {
                Console.WriteLine("Model :" + message.Model + "Year:" + message.Year + "Airline :" + message.Airline + " " + "Kanat icin islem onaylandi\n");
                producer.MakeDemand(message);
            }
            else if (producer != null)
            {
                Console.WriteLine("Model :" + message.Model + "Year:" + message.Year + "Airline :" + message.Airline +  " " +"icin islem kanat maliyetinden ötürü mümkün olmadıgı icin onaylanmadı\n");
                producer.MakeDemand(message);
            }

        }
    }
}
