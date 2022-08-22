using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    //Abstract classes cannot be initialized or instantiated
    public abstract class BaseCountryDto
    {
        //Validation
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
