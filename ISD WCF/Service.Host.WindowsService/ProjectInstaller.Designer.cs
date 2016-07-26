namespace Service.Host.WindowsService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessMainInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceMainInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessMainInstaller
            // 
            this.serviceProcessMainInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessMainInstaller.Password = null;
            this.serviceProcessMainInstaller.Username = null;
            // 
            // serviceMainInstaller
            // 
            this.serviceMainInstaller.Description = "Test host for ISD WCF project";
            this.serviceMainInstaller.ServiceName = "MainHostService";
            this.serviceMainInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessMainInstaller,
            this.serviceMainInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessMainInstaller;
        private System.ServiceProcess.ServiceInstaller serviceMainInstaller;
    }
}