namespace QuizWebAssembly.Models.Shared
{
    public class ModelEditor
    {
        public string? Title { get; set; }
        public bool IsShow { get; set; }
        public List<PropertyDescriptor> Fields { get; set; } = new List<PropertyDescriptor>();
    }
    public class PropertyDescriptor
    {
        public string? Name { get; set; }
        public string? DisplayName { get; set; }
        public ModelEditorValueType ValuType { get; set; }
        public object Value { get; set; }
    }
    public enum ModelEditorValueType
    {
        Text,
        Number
    }
}
