﻿namespace ASP.Net_Project_2.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!; //make it null and give it a value in the future
        
        public double Price{ get; set; }

        public int SerialNumberId { get; set; }
        public SerialNumber? SerialNumber { get; set; }
    }
}
