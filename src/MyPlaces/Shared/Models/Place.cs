﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlaces.Shared.Models
{
    public class Place
    {
        public string ImageUrl { get; set; }
    }
}

IList<Item> items = new List<Item>
    {
        new Item {
            Source = "./img/perito-moreno.jpg",
            Alt ="Perito Moreno",
            Header = "Parque Nacional Los Glaciares",
            Caption = "El Perito Moreno es la perla más brillante de la Patagonia argentina"
        },
        new Item {
            Source = "./img/iguazu1.jpg",
            Alt ="Cataratas del Iguazú",
            Header = "Cataratas del Iguazú",
            Caption = "Adéntrate en esta exhuberante selva compuesta de 275 saltos de agua cuya espectacularidad la incluye entre una de las 7 maravillas naturales del mundo"
        },
        new Item {
            Source = "./img/fitz-roy.jpg",
            Alt ="Fitz Roy",
            Header = "Fitz Roy",
            Caption = "Sorpréndete con una de las vistas más impresionantes de Argentina en El Chaltén"
        },
        new Item {
            Source = "./img/ushuaia.jpg",
            Alt ="Parque Nacional Tierra de Fuego",
            Header = "Tierra de Fuego",
            Caption = "Descubre la Tierra de Fuego, el punto continental más austral del planeta"
        },
        new Item {
            Source = "./img/puerto-madryn.jpg",
            Alt ="Puerto Madryn",
            Header = "Puerto Madryn",
            Caption = "Ballenas, elefantes y lobos marinos, orcas y pingüinos habitan en este rincón de la Patagonia"
        },
        new Item {
            Source = "./img/cerro-torre.jpg",
            Alt ="Cerro Torre",
            Header = "Cerro Torre",
            Caption = "El Cerro Torre es una de las más famosas rutas que se pueden hacer desde El Chaltén"
        }
    };

class Item
{
    public string Source { get; set; }
    public string Alt { get; set; }
    public string Caption { get; set; }
    public string Header { get; set; }
}