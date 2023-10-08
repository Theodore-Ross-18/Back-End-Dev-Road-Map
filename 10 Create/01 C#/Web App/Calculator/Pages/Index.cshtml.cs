using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NCalc;

namespace Calculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Expression { get; set; }
        public string Result { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            try
            {
                Result = Calculate(Expression);
            }
            catch (Exception ex)
            {
                Result = "Error: " + ex.Message;
            }
        }

        private string Calculate(string expression)
        {
            try
            {
                var evaluator = new Expression(expression);
                var result = evaluator.Evaluate();
                return result.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid expression: " + ex.Message);
            }
        }
    }
}
