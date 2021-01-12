using Bieren.Data.Models;
using System;
using System.Collections.Generic;

namespace Demos_ADONET
{
    class Program
    {
       
        static void Main(string[] args)
        {
            BierenDataService bierenDataService = new BierenDataService();
            //bierenDataService.OpenEnSluitConnectie();

            //bierenDataService.UpdateBierenAlcoholPercentage();
            //IList<Brouwer> BrouwersDb = bierenDataService.GeefAlleBrouwers();
            //foreach (Brouwer brouwer in BrouwersDb)
            //{
            //    Console.WriteLine($"{brouwer.BrouwerNr} : {brouwer.BrNaam} : {brouwer.Adres} : {brouwer.PostCode} : {brouwer.Gemeente} : {brouwer.Omzet}");
            //}
            //IList<Bier> bierenUitDb = bierenDataService.GeefAlleBieren();
            //IList<Soort> soortenUitDb = bierenDataService.GeefAlleSoorten();
            //foreach (Soort soort in soortenUitDb)
            //{
            //    Console.WriteLine($"{soort.SoortNr} : {soort.SoortNaam}");
            //}
            //int? aantalBrouwers = bierenDataService.GeefAantalBrouwersVoorPostCode(9000);//vb Gent
            //Console.WriteLine($"Aantal brouwers in Gent:{aantalBrouwers}");

            bierenDataService.UpdateHalveOmzetVanSteden();
            
            IList<Brouwer> brouwerID = bierenDataService.GeefBrouwerVoorGemeente(1);

            foreach (Brouwer brouwer in brouwerID)
            {
                Console.WriteLine($"{brouwer.BrouwerNr} : {brouwer.BrNaam} : {brouwer.Adres} : {brouwer.PostCode} : {brouwer.Gemeente} : {brouwer.Omzet}");
            }




            //int? aantalBieren = bierenDataService.GeefAantalBierenVoorSoort("Geuze");
            //Console.WriteLine($"Aantal bieren van Geuze: {aantalBieren}");

            //foreach (Bier bier in bierenUitDb)
            //{
            //    Console.WriteLine($"{bier.BierNr} : {bier.Naam}, Alcohol = {bier.Alcohol}");
            //}
            //bierenDataService.GeefBierenVoorBrouwerId(99);
            //bierenDataService.GeefBierGegevensVoorBierId(85);
            //bierenDataService.VoegBierToe(Bier);
            //bierenDataService.VerwijderBier(Bier);
            Console.ReadKey();
        }
    }
}
