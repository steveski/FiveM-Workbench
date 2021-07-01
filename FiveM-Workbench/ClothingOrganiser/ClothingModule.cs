namespace FiveM_Workbench.ClothingOrganiser
{
    using Gemini.Framework;
    using Gemini.Framework.ToolBars;
    using Gemini.Modules.ToolBars;
    using System.ComponentModel.Composition;

    [Export(typeof(IModule))]
    public class ClothingModule : Module
    {

        [Export]
        public static ToolBarDefinition NewDocumentToolbar = new ToolBarDefinition(1, "NewDocumentToolbar");

        [Export]
        public static ToolBarItemGroupDefinition NewDocumentToolBarGroup = new ToolBarItemGroupDefinition(NewDocumentToolbar, 8);

        [Export]
        public static ToolBarItemDefinition NewClothingImportDocumentToolBarItem = new CommandToolBarItemDefinition<NewDocumentToolbarCommandDefinition>(NewDocumentToolBarGroup, 0);

        //[Export]
        //public static ToolBarItemDefinition NewClothingRenumberDocumentToolBarItem = new CommandToolBarItemDefinition<NewDocumentToolbarCommandDefinition>(NewDocumentToolBarGroup, 0);

        public override void Initialize()
        {

        }



    }
}
