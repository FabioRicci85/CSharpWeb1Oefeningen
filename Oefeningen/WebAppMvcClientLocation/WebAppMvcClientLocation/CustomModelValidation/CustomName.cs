using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WebAppMvcClientLocation.CustomModelValidation
{
    public class CustomName : Attribute, IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            var name = context.Model;
            var lst = new List<ModelValidationResult>();

            //if ((context.Model != null))
                return lst;
        }
    }
}
