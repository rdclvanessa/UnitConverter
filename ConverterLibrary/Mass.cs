using System;

namespace ConverterLib.Mass
{
    public class Mass
    {
         public interface IMassConversions

    {
        string GetMass(decimal massIn);    
    }
        public string GramToKilo(decimal massIn)
        {
           //Gram To Kilogram
            decimal result = Math.Round((massIn * 1000m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} g convert to {lResult} kg";

        }

        public string GramToOunces(decimal massIn)
        {
           //GramToOUnces
            decimal result = Math.Round((massIn * 0.035274m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} g convert to {lResult} oz";

        }

        public string GramToPound(decimal massIn)
        {
           //GramToPound
            decimal result = Math.Round((massIn * 0.0022046m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} g convert to {lResult} LBS";

        }

        public string PoundToKilo(decimal massIn)
        {
           //Pounds to kilogram
            decimal result = Math.Round((massIn / 2.2046m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} lbs convert to {lResult} kg";

        }

        public string OuncesToPounds(decimal massIn)
        {
           //Ounces to Pounds
            decimal result = Math.Round((massIn * 16),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} oz convert to {lResult} lbs";

        }

        public string PoundToGram(decimal massIn)
        {
           //Pound To gram
            decimal result = Math.Round((massIn / 0.0022046m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} LBS convert to {lResult} g";

        }

         public string OuncesToKilo(decimal massIn)
        {
           //Ounces to Kilogram
            decimal result = Math.Round((massIn / 35.274m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} oz convert to {lResult} kg";

        }

        public string OuncesToGrams(decimal massIn)
        {
           //Ounces to gram
            decimal result = Math.Round((massIn /0.035274m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} oz convert to {lResult} g";

        }

        public string KiloToPound(decimal massIn)
        {
            //KilogramToPound
            decimal result = Math.Round((massIn * 2.2046m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} kg convert to {lResult} lbs";

        }

         public string KiloToOunce(decimal massIn)
        {
           //Kilogram To Ounces
            decimal result = Math.Round((massIn * 35.274m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} kg convert to {lResult} oz";

        }

         public string KiloToGram(decimal massIn)
        {
           //KilogramToGram
            decimal result = Math.Round((massIn / 1000m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} kg convert to {lResult} g";

        }

        public string PoundToOunce(decimal massIn)
        {
           //Pound To ounce
            decimal result = Math.Round((massIn * 16),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} oz convert to {lResult} lbs";

        }
    }
}