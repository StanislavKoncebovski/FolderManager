using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace FlowerPot
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration("Flower Pot Placer", "Places a \"flower pot\" in the header of a C# file", "1.0")]       
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid("bc1126f5-640f-4224-97f4-93214e0bd974")] // must match GUID in the .vsct file
    public sealed class FlowerPotPackage : AsyncPackage
    {
        // This method is run automatically the first time the command is being executed
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);

			FlowerPotCommand command	= new FlowerPotCommand();

            await command.InitializeAsync(this);
        }
    }
}
