using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Tehtävä 4

Toteutettavassa sovelluksessa tulisi pysyä käsittelemään erilaisia kulkuneuvoja. Kaikilla kulkuneuvoilla on löydettävissä
yhteisinä ominaisuuksina: nimi, malli, vuosimalli ja väri. Erikoistapauksina pitää pystyä käsittelemään polkupyöriä ja veneitä. 
Polkupyörän osalta pitää pystyä erottelemaan se, että onko kyseessä vaihdepyörä vai ei sekä mahdollisen vaihteiston mallinimi.
Veneiden osalta tietoina pitää ainakin olla veneen tyyppi (soutuvene, moottorivene, kajakki, ...) ja kuinka monta istuinpaikkaa veneestä löytyy.*/

namespace teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat = new Boat();
            boat.Name = "Hurricane";
            boat.Color = "Turqoise stripes";
            boat.Model = "9000";
            boat.Year = 2001;
            boat.Type = "Motorboat";
            boat.Seat = 5;
            Console.WriteLine("Boat\n" + boat.ToString());

            Bike bike = new Bike();
            bike.Name = "Helkama";
            bike.Color = "Red";
            bike.Model = "Citybike";
            bike.Year = 2014;
            bike.Gears = true;
            bike.Gearmodel = "Shimano";
            Console.WriteLine("Bike\n" + bike.ToString());
        }
    }
}
