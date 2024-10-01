using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WebAppMvcClientLocation.CustomModelValidation
{
    public class CustomNoNumbers : Attribute, IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            var name = context.Model as string;
            var lst = new List<ModelValidationResult>();

            if (!string.IsNullOrEmpty(name) && name.Any(char.IsDigit))
            {
                lst.Add(new ModelValidationResult("", "Naam mag geen cijfers bevatten"));
            }
                return lst;
        }
    }
}
