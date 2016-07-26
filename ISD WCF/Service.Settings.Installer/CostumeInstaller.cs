using System.ComponentModel;

namespace Service.Settings.Installer
{
    [RunInstaller(true)]
    public partial class CostumeInstaller : System.Configuration.Install.Installer
    {
        public CostumeInstaller()
        {
            InitializeComponent();
        }
    }
}
