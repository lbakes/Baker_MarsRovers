using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRovers.Models
{
    public class Grid
    {
        [Required]
        [PosNumberNoZero(ErrorMessage = "Must be a positive number.")]
        [DisplayName("Base")]
        public int X { get; set; }

        [Required]
        [PosNumberNoZero(ErrorMessage = "Must be a postive number.")]
        [DisplayName("Height")]
        public int Y { get; set; }
    }
}
