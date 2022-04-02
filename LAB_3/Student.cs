using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public class Student
    {
       // [Required]

        [StringLength(50, MinimumLength = 3),Required]
    
        public string SecondName { get; set; }
        [StringLength(50, MinimumLength = 3), Required]
        public string FirstName { get; set; }
        [StringLength(50, MinimumLength = 3), Required]
        public string ThirdName { get; set; }
        [StringLength(50, MinimumLength = 3), Required]
        public string Age { get; set; }
        [StringLength(50, MinimumLength = 3), Required]
        public string Specialinost{ get; set; }
        [StringLength(50, MinimumLength = 3), Required]
        public string BirthDate { get; set; }
        [StringLength(50, MinimumLength = 3), Required]
        public string Curs { get; set; }
        [Range(1,4), Required]
        public int Group { get; set; }
        [StringLength(50, MinimumLength = 3), Required]
        public string Ocenka { get; set; }
        [StringLength(50, MinimumLength = 3), Required]
        public string Sex { get; set; }



    }
}
