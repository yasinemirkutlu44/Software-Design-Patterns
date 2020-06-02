using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface Hedef
    {
        public List<string> StudentsFetch();
        public List<string> GPAFetch();
        public List<string> Gender();

    }
}
