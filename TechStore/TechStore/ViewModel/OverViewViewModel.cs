using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TechStore.Models;
using Xamarin.Forms;

namespace TechStore.ViewModel
{
    class OverViewViewModel : BaseViewModel
    {
        public static List<Item> GetItems { get; set; } = new List<Item>();

        public OverViewViewModel()
        {

            GetItems = new List<Item>()
            {
                new Item{
                Name="Apple iMac 20",
                Storage="320 GB HDD",
                Camera="WebCam",
                RAM="4GB RAM Memory",
                Processor="Intel Core 2 Duo Processor",
                Price=180,
                ImagePath="AppleMac.jpg"
                       },
                new Item{
                Name="Apple iMac 24",
                Storage="320 GB HDD",
                Camera="WebCam",
                 RAM="4GB RAM Memory",
                 Processor="Intel Core 2 Duo Processor",
                Price=220,
                ImagePath="AppleiMac.jpg"
                       },
                new Item{
                Name="Apple iPhone X",
                Storage="64 GB",
                Camera="12 Mega Pixel",
                 RAM="3GB RAM Memory",
                 Processor="A11 chip with Hexa-Core Processor",
                Price=455,
                ImagePath="iphoneX.jpg"
                       },
                new Item{
                Name="Apple iPhone 11",
                Storage="64 GB",
                Camera="12MP Dual Camera",
                 RAM="4GB RAM Memory",
                 Processor="A13 chip with Hexa-Core Processor",
                Price=655,
                ImagePath="iphone11.jpg"

                       },


                new Item{
                Name="Apple iPhone 11 Pro Max",
                Storage="64 GB",
                Camera="12MP Triple Camera",
                 RAM="4GB RAM Memory",
                 Processor="A13 chip with Hexa-Core Processor",
                Price=999,
                ImagePath="iphone11plus.jpg"

                       
                },
                new Item{
                Name="Dell Latitude E5450",
                Storage="256GB SDD ",
                Camera="WebCam",
                 RAM="8GB DDR3 SDRAM Memory",
                 Processor="5th Gen Intel Corei5 Processor",
                Price=340,
                ImagePath="DelLat.jpg"

                       },
                new Item{
                Name="Dell Optilex 990 Tower Desktop PC",
                Storage="500GB HDD",
                Camera="WebCam",
                 RAM="8GB RAM Memory",
                 Processor="2nd Gen Intel Corei5 Processor",
                 Price=200,
                ImagePath="DellOpti.jpg"

                       },
                new Item{
                Name="HP NoteBook 15S-FQ1510NA",
                Storage="256GB SDD",
                Camera="WebCam",
                 RAM="4GB RAM DDR4 Memory",
                 Processor="10th Gen intel Corei5",
                Price=600,ImagePath="Not.jpg"

                       },
                new Item{
                Name="Toshiba Satellite L855-14C",
                Storage="128GB SDD",
                Camera="WebCam",
                RAM="4GB RAM Memory",
                Processor="3rd Gen intel Corei5",
                Price=240,ImagePath="tosh.jpg"

                       },
                new Item{
                Name="Samsung Galaxy A51",
                Storage="128GB Storage",
                Camera="Quad 48MP camera",
                 RAM="4GB RAM ",
                 Processor="Octa-Core Processor",
                Price=295,ImagePath="GalA51.jpg"

                       },
                new Item{
                Name="Samsung Galaxy A20 plus 5G",
                Storage="128GB Storage",
                Camera="Quad 64MP camera",
                 RAM="12GB RAM ",
                 Processor="Octa-Core Processor",
                Price=910,ImagePath="GalA20.jpg"

                       },
                 new Item{
                Name="Samsung Galaxy A5",
                Storage="16GB Storage",
                Camera="13MP camera",
                 RAM="2GB RAM ",
                 Processor="Quad-Core Processor",
                Price=99,ImagePath="GalA5.jpg"

                       },
                 new Item{
                Name="Xiaomi Redmi 8A",
                Storage="32GB Storage",
                Camera="12MP camera",
                 RAM="2GB RAM ",
                 Processor="Octa-Core Processor",
                Price=140,
                 ImagePath="Xiaomi.jpg"
                    },












             };


        }



        public static List<Item> GetSearchResults(string QueryString)
        {
            var NormalisedQuery = QueryString?.ToLower() ?? "";
            return GetItems.Where(f => f.Name.ToLowerInvariant().Contains(NormalisedQuery)).ToList();
        }

        

           }
}