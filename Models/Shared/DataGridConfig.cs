namespace QuizWebAssembly.Models.Shared
{
    public class DataGridConfig
    {
        public string Title { get; set; } = string.Empty;
        public List<DataGridColumn> Columns { get; set; } = new List<DataGridColumn>();
        public List<DataGridRowActionGroup> GroupActions { get; set; } = new List<DataGridRowActionGroup>();
        public Func<Task<List<dynamic>>>? LoadDataAsync { get; set; }
        public NewRowButtonDataGridConfig NewRowButtonDataGridConfig { get; set; } = new NewRowButtonDataGridConfig();
        public EditButtonDataGridConfig EditButtonDataGridConfig { get; set; } = new EditButtonDataGridConfig();
    }
    public class DataGridColumn
    {
        public string Title { get; set; } = string.Empty;
        public string PropertyName { get; set; } = string.Empty;

        public string Scope { get; set; } = "col";
        public string Style { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
    }
    public class DataGridRowActionGroup
    {
        public string Width { get; set; } = "200px";
        public List<DataGridRowAction> Actions { get; set; } = new List<DataGridRowAction>();
    }
    public class DataGridRowAction
    {
        public string IconClass { get; set; } = IconsClass.fa_pen_to_square;
        public string ButtonClass { get; set; } = ButtonsClass.btn_primary;
        public Action<Dictionary<string, string>> OnClick { get; set; }

    }
    public static class IconsClass
    {
        public static string fa_pen_to_square { get; set; } = "fa-pen-to-square";
    }
    public static class ButtonsClass
    {
        public static string btn_primary { get; set; } = "btn-primary";
    }
    public class ItemField
    {
        public string Title { get; set; } = string.Empty;
        public string PropertyName { get; set; } = string.Empty;

        public string Scope { get; set; } = "col";
        public string Style { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;

        public ModelEditorValueType ValuType { get; set; }
        public string Value { get; set; }
    }
    public class SelectiveItemField : ItemField
    {
        public List<SelectItem> Items { get; set; }
    }
    public enum ModelEditorValueType
    {
        Text,
        Number,
        Selective
    }
    public class InputModal
    {
        public string Title { get; set; }
        public Func<Dictionary<string, string>, bool> OnSubmitCreateItem { get; set; }
        public List<ItemField> Fields { get; set; }
    }
    public class NewRowButtonDataGridConfig : InputModal
    {
        public string ButtonTitle { get; set; }
        public bool IsShow { get; set; }
    }
    public class EditButtonDataGridConfig : InputModal
    {
        public Func<Dictionary<string,string>,InputModal> OnOpenModal { get; set; }
    }
    public class SelectItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
    }
}
