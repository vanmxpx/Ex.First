using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security;
using System.Windows.Forms;
using System.ServiceModel;

namespace WinFormApp
{
    public partial class    Form1 : Form
    {         
        // reference on service      
        ServiceReference1.ContractClient client;        

        public Form1()
        {
            InitializeComponent();
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl_Action.Enabled = false;
        }               
        
        // buttons for action metods
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            lblResponseResult.Text = client.CalcFactorial(int.Parse(textBox1.Text)).ToString();                            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultStr.Text = client.ReversString(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Player player = client.GetPlayer(int.Parse(textBoxIDPlayer.Text));
                viewPlayer(player);
            }
            catch
            {
                MessageBox.Show("No exist");
            }
            
        }


        private string GetUserName()
        {
            return textBoxUserName.Text;
        }

        private string GetPassword()
        {
            return textBoxPassword.Text;
        }

        private void viewPlayer(Player player)
        {
            textBoxIDPlayer.Text = Convert.ToString(player.ID);
            textBoxfName.Text = Convert.ToString(player.FirstName);
            textBoxLName.Text = Convert.ToString(player.LastName);
            textBoxLevel.Text = Convert.ToString(player.Level);
        }

        // connecting to server using differnt scenarios
        private void conectToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            if (rb_Message.Checked)            
                client = new ServiceReference1.ContractClient("SecuredByMessageEndpoint");
            if (rb_Both.Checked)
            {
                client = new ServiceReference1.ContractClient("SecuredByTransporWithMessageEnpoint");
                listBox_Info.Items.Add(Convert.ToString(client.Endpoint.Address));
                listBox_Info.Items.Add(Convert.ToString(client.Endpoint.Binding.Name));                
            }
            if (rb_transport.Checked)
            {
                client = new ServiceReference1.ContractClient("SecuredByTransportEndpoint");
                listBox_Info.Items.Add(Convert.ToString(client.Endpoint.Address));
                listBox_Info.Items.Add(Convert.ToString(client.Endpoint.Binding.Name));                                
            }

            // client authentification                     
            client.ClientCredentials.UserName.UserName = GetUserName();
            client.ClientCredentials.UserName.Password = GetPassword();

            // for avoid exception "Could not establish trust relationship
            // for the SSL/TLS secure channel with authority 'localhost' "
            //where WCF complains that the certificate was not issued by a certificate authority            
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate
                (object s, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                System.Security.Cryptography.X509Certificates.X509Chain chain,
                System.Net.Security.SslPolicyErrors sslPolicyErrors)
            { return true; };            

            try
            {
                client.Open();
                conectToolStripMenuItem.Enabled = false;
                disconnectToolStripMenuItem.Enabled = true;
                btnCalculate.Enabled = true;
                tabControl_Action.Enabled = true;
            }
            catch (System.ServiceModel.Security.MessageSecurityException ex)
            {
                MessageBox.Show("Incorrect login/password " + ex);
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client.Close();
            conectToolStripMenuItem.Enabled = true;
            btnCalculate.Enabled = false;
            tabControl_Action.Enabled = false;
        }

       
    }
}
