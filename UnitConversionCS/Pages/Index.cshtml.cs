using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UnitConversionApp.Services;

namespace UnitConversionApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty] public double InputValue { get; set; }
        [BindProperty] public string InputUnit { get; set; }
        [BindProperty] public string TargetUnit { get; set; }
        [BindProperty] public string StudentResponse { get; set; }
        public string Result { get; set; }

        public void OnPost()
        {
            var correctValue = ConversionService.Convert(InputValue, InputUnit, TargetUnit);
            if (correctValue == null)
            {
                Result = "Invalid";
            }
            else if (double.TryParse(StudentResponse, out var studentResponse))
            {
                Result = ConversionService.ValidateResponse((double)correctValue, studentResponse) ? "Correct" : "Incorrect";
            }
            else
            {
                Result = "Invalid";
            }
        }
    }
}
