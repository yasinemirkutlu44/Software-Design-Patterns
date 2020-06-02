using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class Adapter : Adaptee , Hedef
    { 
        public List<string> StudentsFetch()
        {
            return OgrenciListeGetir();
        }

        public List<string> GPAFetch()
        {
            return OgrenciGNOGetir();
        }

        public List<string> Gender()
        {
            return OgrenciCinsiyetGetir();
        }
    }
}
