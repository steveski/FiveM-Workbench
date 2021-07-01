namespace FiveM_Workbench.ClothingOrganiser
{
    using Gemini.Framework.Commands;
    using System;
    using System.Windows.Input;

    [CommandDefinition]
    public class NewDocumentToolbarCommandDefinition : CommandDefinition
    {
        public const string CommandName = "NewDocument";
        public override string Name => CommandName;

        public override string Text => "_New Document";

        public override string ToolTip => "New Document";
        public override Uri IconSource
        {
            get { return new Uri("pack://application:,,,/Gemini;component/Resources/Icons/Open.png"); }
        }

    }
}
