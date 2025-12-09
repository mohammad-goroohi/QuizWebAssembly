using QuizWebAssembly.Models.Shared;

namespace QuizWebAssembly.Services
{
    public class EditorModalService
    {
        public bool IsShow { get; set; } = false;
        public string Title { get; set; } = string.Empty;
        public List<PropertyDescriptor> Fields { get; set; } = new List<PropertyDescriptor>();
        public Action<List<PropertyDescriptor>>? OpenModal;
        public Action? CloseModal;
        public Action? OnConfirmClick { get; set; }
    }
}
