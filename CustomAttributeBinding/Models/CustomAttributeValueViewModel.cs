namespace CustomAttributeBinding.Models
{
    public class CustomAttributeValueViewModel
    {
        public int? CustomAttributeValueId { get; set; }
        public int CustomAttributeId { get; set; }
        public int EntityId { get; set; }
        public string AttributeClassType { get; set; }
    }

    public class CustomStringViewModel : CustomAttributeValueViewModel
    {
        public string Value { get; set; }
    }

    public class CustomIntegerViewModel : CustomAttributeValueViewModel
    {
        public int Value { get; set; }
    }
}