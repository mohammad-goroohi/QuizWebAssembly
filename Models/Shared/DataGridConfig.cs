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
        public string Class { get; set; } = string.Empty;
    }
    public class NewItemField
    {
        public string Title { get; set; } = string.Empty;
        public string PropertyName { get; set; } = string.Empty;

        public string Scope { get; set; } = "col";
        public string Style { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;

        public ModelEditorValueType ValuType { get; set; }
        public string Value { get; set; }
    }
    public class SelectiveItemField : NewItemField
    {
        public List<SelectItem> Items { get; set; }
    }
    public enum ModelEditorValueType
    {
        Text,
        Number,
        Selective
    }
    public class NewRowButtonDataGridConfig
    {
        public string ButtonTitle { get; set; }
        public bool IsShow { get; set; }
        public Func<Dictionary<string,string>,bool> OnSubmitCreateItem { get; set; }
        public List<NewItemField> Fields { get; set; }
    }
    public class SelectItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
    }
}
