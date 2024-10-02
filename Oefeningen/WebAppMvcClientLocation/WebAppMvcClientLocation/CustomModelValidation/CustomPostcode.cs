using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WebAppMvcClientLocation.CustomModelValidation
{
    public class CustomPostcode : Attribute, IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            
            var lst = new List<ModelValidationResult>();

            if (int.TryParse(context?.Model?.ToString(), out int postCode))
            {
                if (postCode != 3500 || postCode != 3600 || postCode != 3990)
                {
                    lst.Add(new ModelValidationResult("", "Deze postcode komt niet overeen met 3500, 3600 of 3990"));
                }
            }
                return lst;
        }
    }
}
