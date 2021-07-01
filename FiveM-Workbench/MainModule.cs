using FiveM_Workbench.ClothingOrganiser.ViewModels;
using Gemini.Framework;
using Gemini.Framework.Services;
using Gemini.Framework.ToolBars;
using Gemini.Modules.Output;
using Gemini.Modules.StatusBar;
using Gemini.Modules.Toolbox;
using System.ComponentModel.Composition;

namespace FiveM_Workbench.StatusBar
{
    [Export(typeof(IModule))]
    public class MainModule : ModuleBase
    {        
        [Import]
        public IStatusBar Statusbar { get; set; }

        [Import]
        public IOutput Ouptut { get; set; }


        public override void Initialize()
        {
            MainWindow.Title = "FiveM-Workbench";
            
            Shell.ToolBars.Visible = true;

            Statusbar.AddItem("Ready", new System.Windows.GridLength(1, System.Windows.GridUnitType.Star));

        }

    }


}
