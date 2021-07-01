namespace FiveM_Workbench.ClothingOrganiser.ViewModels
{
    using Gemini.Framework;

    public class ClothingImportViewModel : Document
    {
        public override string DisplayName { get => "ClothingImport"; set => base.DisplayName = value; }
        public string Username { get; set; } = "Steveo";
        public string Password { get; set; } = "SomePass";

    }
}
