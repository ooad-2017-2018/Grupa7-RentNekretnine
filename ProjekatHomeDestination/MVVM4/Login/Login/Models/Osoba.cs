﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Login
{
    public enum Pol { Musko,Zensko };
    public class Osoba
    {
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Telefon { get; set; }
        public String Mail { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public Pol Spol { get; set; }
        public DateTime Datum { get; set; }
        public StackPanel Slika { get; set; }
        public List<Smjestaj> RegistrovaniSmjestaji { get; set; }
        public List<Rezervacija> Rezervacije { get; set; }
        /*public Osoba(string ime,string prezime, string user,string pass,Pol spol,DateTime datum)
        {
            Ime = ime;
            Prezime = prezime;
            Username = user;
            Password = pass;
            Spol = spol;
            Datum = datum;
            RegistrovaniSmjestaji = new List<Smjestaj>();
            Rezervacije = new List<Rezervacija>();
        }*/

    }
}
