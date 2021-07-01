namespace FiveM_Workbench.ClothingOrganiser
{
    using FiveM_Workbench.ClothingOrganiser.ViewModels;
    using Gemini.Framework.Commands;
    using Gemini.Framework.Services;
    using System.ComponentModel.Composition;
    using System.Threading.Tasks;

    [CommandHandler]
    public class NewDocumentToolbarCommandHandler : CommandHandlerBase<NewDocumentToolbarCommandDefinition>
    {
        [Import]
        public IShell Shell { get; set; }

        public override void Update(Command command)
        {
            // You can enable / disable the command here with:
            // command.Enabled = true;

            // You can also modify the command text / icon, which will affect
            // any menu items or toolbar items bound to this command.
        }

        public override async Task Run(Command command)
        {
            await Shell.OpenDocumentAsync(new ClothingImportViewModel());

        }

    }
}
