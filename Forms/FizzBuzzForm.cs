using System.ComponentModel.DataAnnotations;
namespace FizzBuzzWeb.Forms
{
    public class FizzBuzzForm
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required]
        // [Range(10, 100, ErrorMessage = "Oczekiwana wartość {0} z zakredu {1} i {2}.")]

        public int? Number {get; set;}




    }
}