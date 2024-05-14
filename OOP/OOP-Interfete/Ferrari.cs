using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfete
{
    public class Ferrari : ICar
    {
        private string model;
        private string driver;

        public string PushGasPedals()
        {
            return "Zadu6avam sA!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public Ferrari( string driver)
        {
            this.model = "488-Spider";
            this.driver = driver;
        }
        public override string ToString()
        {
            return $"{model}/{UseBrakes()}/{PushGasPedals()}/{driver}";
        }
    }
}
