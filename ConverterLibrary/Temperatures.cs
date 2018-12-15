using System;

namespace ConverterLibrary.Temperatures
{
    public class Temperatures 
    {
        // public interface ITempConversions
        // {
        // string Temp(decimal tempIn);
        // }       
        public string CtoF(decimal tempIn)
        {
            //CtoF
            decimal result = Math.Round((tempIn * (9m/5m) + 32),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} C converts to {strResult} F ";
        }

         public string CtoK(decimal tempIn)
        {
            //CtoK
            decimal result = Math.Round((tempIn + 273.15m),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} C converts to {strResult} K ";
        }     

        public string FtoC(decimal tempIn)
         {
            //FtoC
            decimal result = Math.Round(((tempIn - 32m) / 9m * 5m), 2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} F Converts to {strResult} C ";
            
        }

        public string FtoK(decimal tempIn)
        {
            //FtoK
            decimal result = Math.Round((tempIn + 459.67m ) * (5m/9m),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} F converts to {strResult} K";
        }

        public string KtoC(decimal tempIn)
        {
             //KtoC
            decimal result = Math.Round((tempIn - 273.15m),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} Kelvins converts to {strResult} C"; 
        }

        public string KtoF(decimal tempIn)
        {
            //KtoF
            decimal result = Math.Round((tempIn * (9m/5m) - 459.67m ),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} K convert to {strResult} F";
        }
    }
}