using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PostImagenes.Models
{
    public class Foto
    {
        public Foto()
        {
            Imagen = new Image();
        }

        public String name { get; set; }

        public Image Imagen { get; set; }
    }
}
