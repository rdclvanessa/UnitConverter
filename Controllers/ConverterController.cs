using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using assignment6.Models;
using ConverterLibrary.Temperatures;
using ConverterLib.Lengths;
using ConverterLib.Mass;



namespace assignment6.Controllers
{
    public class ConverterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult TemperatureConvert(decimal tempIn)
        {
            var cToF = new Temperatures();
            var fToC = new Temperatures();
            var cToK = new Temperatures();
            var KtoC = new Temperatures();
            var fToK = new Temperatures();
            var kToF = new Temperatures();
            
            ViewData["CToF"] = cToF.CtoF(tempIn);
            ViewData["fToC"] = fToC.FtoC(tempIn);
            ViewData["cToK"] = cToK.CtoK(tempIn);
            ViewData["KtoC"] = KtoC.KtoC(tempIn);
            ViewData["fToK"] = fToK.FtoK(tempIn);
            ViewData["kToF"] = kToF.KtoF(tempIn);

            return View();
        }

        public IActionResult LengthsConvert(decimal lengthIn)
        {
            var mToF = new Lengths();
            var fToM = new Lengths();
            var mtoY = new Lengths();
            var ytoM = new Lengths();
            var fToY = new Lengths();
            var ytoF = new Lengths();

            ViewData["mToF"] = mToF.MetersToFeet(lengthIn);
            ViewData["fToM"] = fToM.FeetToMeters(lengthIn);
            ViewData["mtoY"] = mtoY.MetersToYards(lengthIn);
            ViewData["ytoM"] = ytoM.YardsToMeters(lengthIn);
            ViewData["fToY"] = fToY.FeetToYards(lengthIn);
            ViewData["yToF"] = ytoF.YardsToFeet(lengthIn);

            return View();

        }

        public IActionResult MassConvert(decimal massIn)
        {
            var gToK = new Mass();
            var kToG = new Mass();
            var gToO = new Mass();
            var oToG = new Mass();
            var gToP = new Mass();
            var pToG = new Mass();
            var pToO = new Mass();
            var oToP = new Mass();
            var kToO = new Mass();
            var oToK = new Mass();
            var pTok = new Mass();
            var kToP = new Mass();

           ViewData["gToK"] = gToK.GramToKilo(massIn);
           ViewData["kToG"] = kToG.KiloToGram(massIn);
           ViewData["gToO"] = gToO.GramToOunces(massIn);
           ViewData["oToG"] = oToG.OuncesToGrams(massIn);
           ViewData["gToP"] = gToP.GramToPound(massIn);
           ViewData["pToG"] = pToG.PoundToGram(massIn);
           ViewData["pToO"] = pToO.PoundToOunce(massIn);
           ViewData["oToP"] = oToP.OuncesToPounds(massIn);
           ViewData["kToO"] = kToO.KiloToOunce(massIn);
           ViewData["oToK"] = oToK.OuncesToKilo(massIn);
           ViewData["pTok"] = pTok.PoundToKilo(massIn);
           ViewData["KToP"] = kToP.KiloToPound(massIn);



            return View();
    
        }
    }
}