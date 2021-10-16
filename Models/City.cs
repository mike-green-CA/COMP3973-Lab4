using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class City {

    [Key]
    [Display (Name = "City ID")]
    public int CityID {get; set;}

    [Display (Name = "City")]
    [MaxLength(100)]
    public string CityName {get; set;}

    [Display (Name = "Population")]
    [MaxLength(8)]
    public int Population {get; set;}

    [Display (Name = "Province")]
    [MaxLength(2)]
    public string Province {get; set;}
}
