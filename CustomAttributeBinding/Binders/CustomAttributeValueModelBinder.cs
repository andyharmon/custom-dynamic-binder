using System;
using System.Web.Mvc;
using CustomAttributeBinding.Models;

namespace CustomAttributeBinding.Binders
{
    public class CustomAttributeValueModelBinder : DefaultModelBinder
    {
        protected override object CreateModel(
            ControllerContext controllerContext,
            ModelBindingContext bindingContext,
            Type modelType)
        {
            if (modelType == typeof (CustomAttributeValueViewModel))
            {
                var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName + ".AttributeClassType");

                if (valueProviderResult != null)
                {
                    var attributeClassType = valueProviderResult.ConvertTo(typeof (string)) as string;

                    var assembly = typeof (CustomAttributeValueViewModel).Assembly;
                    var instantiationType = assembly.GetType(attributeClassType, true);

                    var obj = Activator.CreateInstance(instantiationType);
                    bindingContext.ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(null,
                        instantiationType);
                    bindingContext.ModelMetadata.Model = obj;
                    return obj;
                }
            }

            return base.CreateModel(controllerContext, bindingContext, modelType);
        }
    }
}