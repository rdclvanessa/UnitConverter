using System;

namespace ConverterLib.Lengths
{
    public class Lengths
    {
        public interface ILengthConversions
    {
        decimal Lengths(decimal LengthIn);
    }
        public string FeetToMeters(decimal LengthIn)
        {
            //feet to meters 
            decimal result = Math.Round((LengthIn * 3.2808m), 2);
            string lResult = Convert.ToString(result);
            return $"{LengthIn} F converts to {lResult} M";

        }

        public string YardsToFeet(decimal LengthIn)
        {
            //Yard to Feet
            decimal result = Math.Round((LengthIn * 3),2);
            string lResult = Convert.ToString(result);
            return $"{LengthIn} Y convert to {lResult} F";

        }

        public string YardsToMeters(decimal LengthIn)
        {
             //yard to meters 
            decimal result = Math.Round((LengthIn * 0.9144m),2);
            string lResult = Convert.ToString(result);
            return $"{LengthIn} Y converts to {lResult} M";

        }

        public string FeetToYards(decimal LengthIn)
        {
           //Feet to yard
            decimal result = Math.Round((LengthIn * 0.3333333333m),2);
            string lResult = Convert.ToString(result);
            return $"{LengthIn} F convert to {lResult} Y";

        }

        public string MetersToYards(decimal LengthIn)
        {
             //Meters to yard 
            decimal result = Math.Round((LengthIn * 1.0936132983m),2);
            string lResult = Convert.ToString(result);
            return $"{LengthIn}M converts to {lResult} Y";

        }

        public string MetersToFeet(decimal LengthIn)
        {
            //Meters to Feet
            decimal result = Math.Round((LengthIn/0.3048m),2);
            string lResult = Convert.ToString(result);
            return $"{LengthIn} M converts to {lResult} F";

        }


    }
}