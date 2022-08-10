﻿namespace HotelListing.API.Data
{
    //Entity called Country
    public class Country
    {
        //Basically used 1-many relationship, Thus a country can have many hotels
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        //public virtual IList<Hotel> Hotel { get; set; }
    }
}