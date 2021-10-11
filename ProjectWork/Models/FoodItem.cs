using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectWork.Models
{
    public partial class FoodItem
    {
        public int FoodItemId { get; set; }
        public string ImgSource { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
    }
}
