﻿using System;

namespace APIVCF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check roundups
            double t = 5.34;
            string uom = "degC";
            Calcs calc = new Calcs();
            Console.WriteLine("For temp of {0} {1} roundup is {2} {1}",t,uom,calc.RoundUpAPI11_1(t,uom));
            t = -5.34;
            Console.WriteLine("For temp of {0} {1} roundup is {2} {1}", t, uom, calc.RoundUpAPI11_1(t, uom));
            t = 10.05;
            uom = "degF";
            Console.WriteLine("For temp of {0} {1} roundup is {2} {1}", t, uom, calc.RoundUpAPI11_1(t, uom));

            // Check other roundups 
            t = -0.05;
			int pow10 = -1;
            Console.WriteLine("Value of {0} rounds up to {1} at precision 10e{2}", t, calc.RoundUpAPI11_1(t,Math.Pow(10, pow10)),pow10);
			t = -0.049;
			Console.WriteLine("Value of {0} rounds up to {1} at precision 10e{2}", t, calc.RoundUpAPI11_1(t, Math.Pow(10, pow10)), pow10);
            t = -0.051;
			Console.WriteLine("Value of {0} rounds up to {1} at precision 10e{2}", t, calc.RoundUpAPI11_1(t, Math.Pow(10, pow10)), pow10);
            t = 0.35555;
			Console.WriteLine("Value of {0} rounds up to {1} at precision 10e{2}", t, calc.RoundUpAPI11_1(t, Math.Pow(10, pow10)), pow10);
            t = 0.40289;
			Console.WriteLine("Value of {0} rounds up to {1} at precision 10e{2}", t, calc.RoundUpAPI11_1(t, Math.Pow(10, pow10)), pow10);
            t = 24.95;
			Console.WriteLine("Value of {0} rounds up to {1} at precision 10e{2}", t, calc.RoundUp(t, pow10), pow10);
			t = 2015.0;
            pow10 = 1;
			Console.WriteLine("Value of {0} rounds up to {1} at precision 10e{2}", t, calc.RoundUp(t, pow10),pow10);
            t = 2017.5;
            pow10 = 0;
			Console.WriteLine("Value of {0} rounds up to {1} at precision 10e{2}", t, calc.RoundUp(t, pow10),pow10);
            t = 1.374174158511;
            pow10 = -5;
			Console.WriteLine("Value of {0} rounds up to {1} at precision 10e{2}", t, calc.RoundUp(t, pow10),pow10);


			// Check temperature conversions
			t = 32;
            Console.WriteLine("Temp {0} in degF converts to {1} in degC",t,Conversions.DegFtoDegC(t));
			Console.WriteLine("Temp {0} in degF converts to {1} in degK", t, Conversions.DegFtoDegK(t));
			t = -40;
			Console.WriteLine("Temp {0} in degF converts to {1} in degC", t, Conversions.DegFtoDegC(t));
			Console.WriteLine("Temp {0} in degF converts to {1} in degK", t, Conversions.DegFtoDegK(t));
			t = 60;
			Console.WriteLine("Temp {0} in degF converts to {1} in degC", t, Conversions.DegFtoDegC(t));
			Console.WriteLine("Temp {0} in degF converts to {1} in degK", t, Conversions.DegFtoDegK(t));
			t = 212;
			Console.WriteLine("Temp {0} in degF converts to {1} in degC", t, Conversions.DegFtoDegC(t));
			Console.WriteLine("Temp {0} in degF converts to {1} in degK", t, Conversions.DegFtoDegK(t));
			t = 0;
			Console.WriteLine("Temp {0} in degC converts to {1} in degF", t, Conversions.DegCtoDegF(t));
			t = -40;
			Console.WriteLine("Temp {0} in degC converts to {1} in degF", t, Conversions.DegCtoDegF(t));
			t = 15;
			Console.WriteLine("Temp {0} in degC converts to {1} in degF", t, Conversions.DegCtoDegF(t));
			t = 100;
			Console.WriteLine("Temp {0} in degC converts to {1} in degF", t, Conversions.DegCtoDegF(t));
			t = 32;
            uom = "degF";
            Console.WriteLine("Temp {0} in {1} ITS90 converts to {2} {1} ITPS68 - rounded up", t, uom,calc.RoundUpAPI11_1(Conversions.TempITS90toITPS68(t,uom),uom));
			t = -40;
            Console.WriteLine("Temp {0} in {1} ITS90 converts to {2} {1} ITPS68 - rounded up", t, uom,calc.RoundUpAPI11_1(Conversions.TempITS90toITPS68(t, uom),uom));
			t = 60;
            Console.WriteLine("Temp {0} in {1} ITS90 converts to {2} {1} ITPS68 - rounded up", t, uom,calc.RoundUpAPI11_1(Conversions.TempITS90toITPS68(t, uom),uom));
			t = 212;
			Console.WriteLine("Temp {0} in {1} ITS90 converts to {2} {1} ITPS68", t, uom, Conversions.TempITS90toITPS68(t, uom));
			t = 0;
            uom = "degC";
			Console.WriteLine("Temp {0} in {1} ITS90 converts to {2} {1} ITPS68", t, uom, Conversions.TempITS90toITPS68(t, uom));
			t = -40;
			Console.WriteLine("Temp {0} in {1} ITS90 converts to {2} {1} ITPS68", t, uom, Conversions.TempITS90toITPS68(t, uom));
			t = 15;
			Console.WriteLine("Temp {0} in {1} ITS90 converts to {2} {1} ITPS68", t, uom, Conversions.TempITS90toITPS68(t, uom));
			t = 100;
			Console.WriteLine("Temp {0} in {1} ITS90 converts to {2} {1} ITPS68", t, uom, Conversions.TempITS90toITPS68(t, uom));

            // Check Density Conversions
            double d = 10;
            uom = "API";
            Console.WriteLine("Density {0} in {1} converts to {2} in SG",d,uom,Conversions.APItoSG(d));
            Console.WriteLine("Density {0} in {1} converts to {2} in kg/m3", d, uom, Conversions.APItoKgm3(d));
            d = 1.8400000333786;
			Console.WriteLine("Density {0} in {1} converts to {2} in SG", d, uom, Conversions.APItoSG(d));
			Console.WriteLine("Density {0} in {1} converts to {2} in kg/m3", d, uom, Conversions.APItoKgm3(d));
			d = 1;
            uom = "SG";
			Console.WriteLine("Density {0} in {1} converts to {2} in API", d, uom, Conversions.SGtoAPI(d));
            Console.WriteLine("Density {0} in {1} converts to {2} in kg/m3", d, uom, Conversions.APItoKgm3(Conversions.SGtoAPI(d)));
            d = 999.016;
            uom = "kg/m3";
            Console.WriteLine("Density {0} in {1} converts to {2} in API", d, uom, Conversions.Kgm3toAPI(d));
            Console.WriteLine("Density {0} in {1} converts to {2} in SG", d, uom, Conversions.APItoSG(Conversions.Kgm3toAPI(d)));
            Console.WriteLine("Density {0} in {1} converts to {2} in lb/gal", d, uom, Conversions.KgM3ToLbGal(d));
			d = 610.6;
			Console.WriteLine("Density {0} in {1} converts to {2} in API", d, uom, Conversions.Kgm3toAPI(d));
            Console.WriteLine("Density {0} in {1} converts to {2} in SG", d, uom, Conversions.APItoSG(Conversions.Kgm3toAPI(d)));
			d = 800;
			Console.WriteLine("Density {0} in {1} converts to {2} in API", d, uom, Conversions.Kgm3toAPI(d));
			Console.WriteLine("Density {0} in {1} converts to {2} in SG", d, uom, Conversions.APItoSG(Conversions.Kgm3toAPI(d)));
            d = 0.5250;
            uom = "SG";
			Console.WriteLine("Density {0} in {1} converts to {2} in API", d, uom, Conversions.SGtoAPI(d));
            Console.WriteLine("Density {0} in {1} converts to {2} in kg/m3", d, uom, Conversions.SGtoKgm3(d));

            // Get kCoeffs and print them
            var grp = COMMODITY_GROUP.CRUDE_OIL;
            var kc = calc.GetKCoeffs(grp);
            Console.WriteLine("Commodity Group {0} has k0={1}, k1={2}, k2={3}",kc.CommodityGroup,kc.k0,kc.k1,kc.k2);
            grp = COMMODITY_GROUP.FUEL_OILS;
            kc=calc.GetKCoeffs(grp);
			Console.WriteLine("Commodity Group {0} has k0={1}, k1={2}, k2={3}", kc.CommodityGroup, kc.k0, kc.k1, kc.k2);
            grp = COMMODITY_GROUP.GASOLINES;
			kc = calc.GetKCoeffs(grp);
			Console.WriteLine("Commodity Group {0} has k0={1}, k1={2}, k2={3}", kc.CommodityGroup, kc.k0, kc.k1, kc.k2);
			grp = COMMODITY_GROUP.JET_FUELS;
			kc = calc.GetKCoeffs(grp);
			Console.WriteLine("Commodity Group {0} has k0={1}, k1={2}, k2={3}", kc.CommodityGroup, kc.k0, kc.k1, kc.k2);
            grp = COMMODITY_GROUP.LUBRICATING_OIL;
			kc = calc.GetKCoeffs(grp);
			Console.WriteLine("Commodity Group {0} has k0={1}, k1={2}, k2={3}", kc.CommodityGroup, kc.k0, kc.k1, kc.k2);
			grp = COMMODITY_GROUP.TRANSITION_ZONE;
			kc = calc.GetKCoeffs(grp);
			Console.WriteLine("Commodity Group {0} has k0={1}, k1={2}, k2={3}", kc.CommodityGroup, kc.k0, kc.k1, kc.k2);

            // Get GasLiqProperties and print them
            var gasLiq = LIQ_GAS_FLUID.EE_68_32;
            var lgp = calc.GetLiqGasProps(gasLiq);
            Console.WriteLine("Liquid Gas {0} has relDens60={1}, tempCritK={2}, compCrit={3}, densCrit={4}, k1={5}, k2={6}, k1={7}, k2={8}", lgp.Fluid, lgp.relDens60, lgp.tempCritK, lgp.comprFactCrit, lgp.densCrit, lgp.k1, lgp.k2, lgp.k3, lgp.k4);
            gasLiq = LIQ_GAS_FLUID.ETHANE;
			lgp = calc.GetLiqGasProps(gasLiq);
			Console.WriteLine("Liquid Gas {0} has relDens60={1}, tempCritK={2}, compCrit={3}, densCrit={4}, k1={5}, k2={6}, k1={7}, k2={8}", lgp.Fluid, lgp.relDens60, lgp.tempCritK, lgp.comprFactCrit, lgp.densCrit, lgp.k1, lgp.k2, lgp.k3, lgp.k4);
            gasLiq = LIQ_GAS_FLUID.EP_65_35;
			lgp = calc.GetLiqGasProps(gasLiq);
			Console.WriteLine("Liquid Gas {0} has relDens60={1}, tempCritK={2}, compCrit={3}, densCrit={4}, k1={5}, k2={6}, k1={7}, k2={8}", lgp.Fluid, lgp.relDens60, lgp.tempCritK, lgp.comprFactCrit, lgp.densCrit, lgp.k1, lgp.k2, lgp.k3, lgp.k4);
            gasLiq = LIQ_GAS_FLUID.EP_35_65;
			lgp = calc.GetLiqGasProps(gasLiq);
			Console.WriteLine("Liquid Gas {0} has relDens60={1}, tempCritK={2}, compCrit={3}, densCrit={4}, k1={5}, k2={6}, k1={7}, k2={8}", lgp.Fluid, lgp.relDens60, lgp.tempCritK, lgp.comprFactCrit, lgp.densCrit, lgp.k1, lgp.k2, lgp.k3, lgp.k4);
            gasLiq = LIQ_GAS_FLUID.PROPANE;
			lgp = calc.GetLiqGasProps(gasLiq);
			Console.WriteLine("Liquid Gas {0} has relDens60={1}, tempCritK={2}, compCrit={3}, densCrit={4}, k1={5}, k2={6}, k1={7}, k2={8}", lgp.Fluid, lgp.relDens60, lgp.tempCritK, lgp.comprFactCrit, lgp.densCrit, lgp.k1, lgp.k2, lgp.k3, lgp.k4);
            gasLiq = LIQ_GAS_FLUID.iBUTANE;
			lgp = calc.GetLiqGasProps(gasLiq);
			Console.WriteLine("Liquid Gas {0} has relDens60={1}, tempCritK={2}, compCrit={3}, densCrit={4}, k1={5}, k2={6}, k1={7}, k2={8}", lgp.Fluid, lgp.relDens60, lgp.tempCritK, lgp.comprFactCrit, lgp.densCrit, lgp.k1, lgp.k2, lgp.k3, lgp.k4);
            gasLiq = LIQ_GAS_FLUID.nBUTANE;
			lgp = calc.GetLiqGasProps(gasLiq);
			Console.WriteLine("Liquid Gas {0} has relDens60={1}, tempCritK={2}, compCrit={3}, densCrit={4}, k1={5}, k2={6}, k1={7}, k2={8}", lgp.Fluid, lgp.relDens60, lgp.tempCritK, lgp.comprFactCrit, lgp.densCrit, lgp.k1, lgp.k2, lgp.k3, lgp.k4);
            gasLiq = LIQ_GAS_FLUID.iPENTANE;
			lgp = calc.GetLiqGasProps(gasLiq);
			Console.WriteLine("Liquid Gas {0} has relDens60={1}, tempCritK={2}, compCrit={3}, densCrit={4}, k1={5}, k2={6}, k1={7}, k2={8}", lgp.Fluid, lgp.relDens60, lgp.tempCritK, lgp.comprFactCrit, lgp.densCrit, lgp.k1, lgp.k2, lgp.k3, lgp.k4);
            gasLiq = LIQ_GAS_FLUID.nPENTANE;
			lgp = calc.GetLiqGasProps(gasLiq);
			Console.WriteLine("Liquid Gas {0} has relDens60={1}, tempCritK={2}, compCrit={3}, densCrit={4}, k1={5}, k2={6}, k1={7}, k2={8}", lgp.Fluid, lgp.relDens60, lgp.tempCritK, lgp.comprFactCrit, lgp.densCrit, lgp.k1, lgp.k2, lgp.k3, lgp.k4);
            gasLiq = LIQ_GAS_FLUID.iHEXANE;
			lgp = calc.GetLiqGasProps(gasLiq);
			Console.WriteLine("Liquid Gas {0} has relDens60={1}, tempCritK={2}, compCrit={3}, densCrit={4}, k1={5}, k2={6}, k1={7}, k2={8}", lgp.Fluid, lgp.relDens60, lgp.tempCritK, lgp.comprFactCrit, lgp.densCrit, lgp.k1, lgp.k2, lgp.k3, lgp.k4);
            gasLiq = LIQ_GAS_FLUID.nHEXANE;
			lgp = calc.GetLiqGasProps(gasLiq);
			Console.WriteLine("Liquid Gas {0} has relDens60={1}, tempCritK={2}, compCrit={3}, densCrit={4}, k1={5}, k2={6}, k1={7}, k2={8}", lgp.Fluid, lgp.relDens60, lgp.tempCritK, lgp.comprFactCrit, lgp.densCrit, lgp.k1, lgp.k2, lgp.k3, lgp.k4);
			gasLiq = LIQ_GAS_FLUID.nHEPTANE;
			lgp = calc.GetLiqGasProps(gasLiq);
			Console.WriteLine("Liquid Gas {0} has relDens60={1}, tempCritK={2}, compCrit={3}, densCrit={4}, k1={5}, k2={6}, k1={7}, k2={8}", lgp.Fluid, lgp.relDens60, lgp.tempCritK, lgp.comprFactCrit, lgp.densCrit, lgp.k1, lgp.k2, lgp.k3, lgp.k4);

            // Get Vapor Pressure Correlation Parameters
            var vpCorrParms = RulesLoader.GetVapPressCorrParams();
            foreach (var vpCorrParm in vpCorrParms)
            {
                Console.WriteLine("{0}{1}Relative Density{2}{3} - A0={4},A1={5},A2={6},B0={7},B1={8},B2={9}",
                                  vpCorrParm.RelDensityRange.Min,vpCorrParm.RelDensityRange.MinCompare==COMPARE.INCLUDE?"<=":"<",
								  vpCorrParm.RelDensityRange.MaxCompare == COMPARE.INCLUDE ? "<=" : "<", vpCorrParm.RelDensityRange.Max,
                                  vpCorrParm.A0,vpCorrParm.A1,vpCorrParm.A2,vpCorrParm.B0,vpCorrParm.B1,vpCorrParm.B2);
            }

			// Validate range checks
			double pres = 0;
            double temp = 0;
            double dens = 800;
            double api = Conversions.Kgm3toAPI(dens);
            grp = COMMODITY_GROUP.CRUDE_OIL;
			Console.WriteLine("Testing for commodity group {0}", grp);
            double vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);  // All good
            Console.WriteLine("Values in range test completed");
            // Temp to low
            temp = -58.1;
            try
            {
                vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
                Console.WriteLine("Test for low temp for {0} failed", grp);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Temp {0} is too low", temp);
            }
            // Temp to high
			temp = 302.1;
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for high temp for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("Temp {0} is too high",temp); 
            }
			temp = 0;
            // Press to low
			pres = -0.1;
            try
            {
                vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
                Console.WriteLine("Test for low press for {0} failed", grp);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Press {0} is too low", pres);
            }
            // Press to high
			pres = 1500.1;
            try
            {
                vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
                Console.WriteLine("Test for high press for {0} failed", grp);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Press {0} is too high", pres);

            }
			// Density too low
			dens = 610.5;
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for low density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too low", dens);
			}
			// Density too high
			dens = 1163.5;
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for high density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too high", dens);
			}
			pres = 0;
			temp = 0;
            dens = 900;
			api = Conversions.Kgm3toAPI(dens);
			grp = COMMODITY_GROUP.FUEL_OILS;
			Console.WriteLine("Testing for commodity group {0}", grp);
			vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);  // All good
			Console.WriteLine("Values in range test completed");
			// Density too low
			dens = 818.3126;
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for low density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too low", dens);
			}
			// Density too high
			dens = 1163.6;
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for high density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too high", dens);
			}
            dens = 800;
			api = Conversions.Kgm3toAPI(dens);
            grp = COMMODITY_GROUP.JET_FUELS;
			Console.WriteLine("Testing for commodity group {0}", grp);
			vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);  // All good
			Console.WriteLine("Values in range test completed");
			// Density too low
			dens = 787.5194;
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for low density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too low", dens);
			}
			// Density too high
			dens = 838.3127;
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for high density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too high", dens);
			}
			dens = 780;
            api = Conversions.Kgm3toAPI(dens);
			grp = COMMODITY_GROUP.TRANSITION_ZONE;
			Console.WriteLine("Testing for commodity group {0}", grp);
			vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);  // All good
			Console.WriteLine("Values in range test completed");
			// Density too low
			dens = 770.351;
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for low density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too low", dens);
			}
			// Density too high
			dens = 787.5195;
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for high density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too high", dens);
			}
			dens = 650;
            api = Conversions.Kgm3toAPI(dens);
            grp = COMMODITY_GROUP.GASOLINES;
			Console.WriteLine("Testing for commodity group {0}", grp);
			vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);  // All good
			Console.WriteLine("Values in range test completed");
			// Density too low
			dens = 610.5;
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for low density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too low", dens);
			}
			// Density too high
			dens = 770.352;
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for high density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too high", dens);
			}
			dens = 900;
            api = Conversions.Kgm3toAPI(dens);
            grp = COMMODITY_GROUP.LUBRICATING_OIL;
			Console.WriteLine("Testing for commodity group {0}", grp);
			vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);  // All good
			Console.WriteLine("Values in range test completed");
			// Density too low
			dens = 800.8;
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for low density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too low", dens);
			}
			// Density too high
			dens = 1163.5;
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp, api, temp, pres);
				Console.WriteLine("Test for high density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too high", dens);
			}
			// LPG and NGLs
			pres = 150;
            double vapPres = 40; 
			temp = -40;
			dens = 500;
			api = Conversions.Kgm3toAPI(dens);
            grp = COMMODITY_GROUP.LPG_NGL;
			Console.WriteLine("Testing for commodity group {0}", grp);
            vcf = calc.GetCTPLFromApiDegFPsig(grp,api,temp,pres,vapPres);  // All good
			Console.WriteLine("Values in range test completed");
			// Temp to low
			temp = -50.9;
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp,api, temp, pres, vapPres);  // All good
				Console.WriteLine("Test for low temp for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Temp {0} is too low", temp);
			}
			// Temp to high
			temp = 199.5;
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp,api, temp, pres, vapPres);  // All good
				Console.WriteLine("Test for high temp for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Temp {0} is too high", temp);
			}
            // Density to low
            dens = Conversions.SGtoKgm3(0.349);
            api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp,api, temp, pres, vapPres);  // All good
				Console.WriteLine("Test for low density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too low", dens);
			}
			// Density to high
			dens = Conversions.SGtoKgm3(0.689);
			api = Conversions.Kgm3toAPI(dens);
			try
			{
				vcf = calc.GetCTPLFromApiDegFPsig(grp,api, temp, pres, vapPres);  // All good
				Console.WriteLine("Test for high density for {0} failed", grp);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Density {0} is too high", dens);
			}

			Console.WriteLine("Press ENTER to terminate");
            Console.ReadLine();
        }
    }
}
