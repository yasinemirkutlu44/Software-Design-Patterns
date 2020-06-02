using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ChainOfResponsibility
{
    public class PlaneMessage
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public string Airline { get; set; }
        public int Budget { get; set; }

        public PlaneMessage(string model, string year,string airline,int budget)
        {
            Model = model;
            Year = year;
            Airline = airline;
            Budget = budget;

            Console.WriteLine("Model : " + model + " " + "Year : " + year + " "+ " Airline :" + airline + " " + "icin gerekli koşullar kontrol ediliyor.\n");
        }
    }
}
