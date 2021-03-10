using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var labelWidth = 8;
            //ShowSepRow(8);
            //var place = "Stavern";
            //ShowFieldNameAndValue("Navn", labelWidth, place);
            //var municipality = "Larvik";
            //ShowFieldNameAndValue("Kommune", labelWidth, municipality);
            //var region = "Vestfold";
            //ShowFieldNameAndValue("Fylke", labelWidth, region);
            //ShowSepRow(labelWidth);
            //var place = "Stavern";
            //var municipality = "Larvik";
            //var region = "Vestfold";
            //ShowPlace(place, municipality, region);
            Place.PlaceName = "Stavern";
            Place.Municipality = "Larvik";
            Place.Region = "Vestfold";
            Place.ShowPlace();

            Place.PlaceName = "Rjukan";
            Place.Municipality = "Tinn";
            Place.Region = "Telemark";
            Place.ShowPlace();
        }

    }
}
