using System.ComponentModel.DataAnnotations;
namespace BookExercise.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="PLease enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter ypu email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage =  "please enter valid email")]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please enter your choose")]
        public bool? WillAttend { get; set; }

        public int MyProperty1 { get; set; }

        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }
    }
}
