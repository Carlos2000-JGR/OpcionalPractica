using System;
using System.Collections.Generic;
using System.Text;

namespace OpcionalPractica.Models 
{ 
    public class MenuNames
    {
        public MenuNames(string image, string title)
        {
            Title = title;
            Image = image;

        }

        public string Image { get; }
        public string Title { get; }
        
    }
}
