using System.Collections.Generic;

namespace singleResponsibility
{
    public class CargoIssues
    {
        public static List<Cargo> cargos = new List<Cargo>();
        private static readonly object locked = new object();
        public void Registration (Cargo cargo)
        {
            lock(locked) cargos.Add(cargo);
        }

        public void Deletion (Cargo cargo)
        {
            lock (locked) cargos.Remove(cargo);
        } 

    }
}
