using System;
using System.Collections.Generic;
using f1project.entity.Concrete;

namespace f1project.webui.Models
{
    public class GetTeamViewModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Founder { get; set; }
        
        public DateTime FoundationYear { get; set; }
        
        public string TeamBoss { get; set; }
        
        public string TeamImageUrl { get; set; }

        
        public List<F1Driver> Drivers { get; set; }
    }
    // public class GetDriversModel
    // {

    //     public int Id { get; set; }

    //     public string DriverName { get; set; }
    //     public string DriverSurname { get; set; }
    //     public byte DriverNumber { get; set; }

    //     public F1Team Team { get; set; }

    //     public int TeamId { get; set; }


    //     public DateTime DateOfBirth { get; set; }

    //     public string DriverImageUrl { get; set; }

    //     public Country Country { get; set; }

    // }
}