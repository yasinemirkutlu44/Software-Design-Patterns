using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class GearConcrete : Producer
    {
        public override void MakeDemand(PlaneMessage message)
        {
            if (message.Budget >= 3000)
            {
                Console.WriteLine("Model :" + message.Model + "Year:" + message.Year + "Airline :" + message.Airline + " " + "İnis takimi icin islem onaylandi\n");
            }
            else
            {
                Console.WriteLine("Model :" + message.Model + "Year:" + message.Year + "Airline :" + message.Airline + " " + "icin islem inis takimi maliyetinden ötürü mümkün olmadıgı icin onaylanmadı\n");
            }
        }
    }
}
