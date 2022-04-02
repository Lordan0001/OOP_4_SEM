using System.ComponentModel.DataAnnotations;

namespace LAB_2
{
    public class Enrollee : HumanFactory
    {
        [StringLength(50, MinimumLength = 1), Required]
        public string EnSecondName { get; set; }

        [StringLength(50, MinimumLength = 1), Required]
        public string EnFirstName { get; set; }

        [StringLength(50, MinimumLength = 1), Required]
        public string EnThirdName { get; set; }

        [StringLength(50, MinimumLength = 1), Required]
        public string EnAge { get; set; }


        public string EnBirthDate { get; set; }

        public string EnSex { get; set; }
        public override Status createStatus()
        {
            return new EnStatus();
        }

        public override Wanna createWanna()
        {
            return new EnWanna();
        }
    }
}
