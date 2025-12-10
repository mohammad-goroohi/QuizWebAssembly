namespace QuizWebAssembly.Models.Shared
{
    public class DataGridConfig
    {
        public string Title { get; set; } = string.Empty;
        public List<DataGridColumn> Columns { get; set; } = new List<DataGridColumn>();
        public Func<Task<List<dynamic>>>? LoadDataAsync { get; set; }
        public NewRowButtonDataGridConfig NewRowButtonDataGridConfig { get; set; } = new NewRowButtonDataGridConfig();
    }
    public class DataGridColumn
    {
        public string Title { get; set; } = string.Empty;
        public string PropertyName { get; set; } = string.Empty;

        public string Scope { get; set; } = "col";
        public string Style { get; set; } = string.Empty;
    }
    public class NewRowButtonDataGridConfig
    {
        public string ButtonTitle { get; set; }
        public bool IsShow { get; set; }
        public Action OnClick { get; set; }
    }
}
