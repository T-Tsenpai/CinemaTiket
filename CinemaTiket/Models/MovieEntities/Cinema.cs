using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CinemaTiket.Models.MovieEntities
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
       
        public string Name { get; set; }

        public string Description { get; set; }
    }
}