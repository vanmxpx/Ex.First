using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;

namespace ConnectionManager
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer
    {
        public Installer()
        {
            InitializeComponent();
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
            Configuration.Configurate();
        }
    }
}
