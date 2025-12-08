using QuizWebAssembly.Models.Shared;

namespace QuizWebAssembly.Services
{
    public class EditorModalService
    {
        public Action<ModelEditor> OpenModal { get; set; }
    }
}
