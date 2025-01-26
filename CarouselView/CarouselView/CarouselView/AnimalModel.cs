using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CarouselView
{
    class AnimalModel
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public Category Group { get; set; }

        public enum Category { Land, Air, Water}
    }
}
