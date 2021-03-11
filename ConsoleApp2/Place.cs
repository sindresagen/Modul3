using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Place
    {
        public  string PlaceName;
        public  string Municipality;
        public  string Region;

        public  void ShowPlace()
        {
            var labelWidth = 8;
            ShowSepRow(8);
            ShowFieldNameAndValue("Navn", labelWidth, PlaceName);
            ShowFieldNameAndValue("Kommune", labelWidth, Municipality);
            ShowFieldNameAndValue("Fylke", labelWidth, Region);
            ShowSepRow(labelWidth);
        }


        private  void ShowFieldNameAndValue(string label, int labelWidth, string fieldValue)
        {
            labelWidth -= label.Length;
            Console.WriteLine("  " + label + ":" + string.Empty.PadLeft(labelWidth, ' ') + fieldValue);
        }

        //static void ShowSepRow()
        //{
        //    ShowSepRow(8);
        //}
        private void ShowSepRow(int labelWidth)
        {
            labelWidth += 14;
            Console.WriteLine(string.Empty.PadLeft(labelWidth, '*'));
        }
    }
}
