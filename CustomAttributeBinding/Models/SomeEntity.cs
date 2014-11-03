using System.Collections.Generic;

namespace CustomAttributeBinding.Models
{
    public sealed class SomeEntity
    {
        // different properties here

        public string ProductName { get; set; }

        public IEnumerable<CustomAttributeValueViewModel> CustomAttributes { get; set; }
    }
}