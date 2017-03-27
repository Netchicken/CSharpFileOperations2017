using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFileOperations2017
{
    public partial class Form1 : Form
    {
        //Make a counter
        private int count = 1;
        //  UserDetails myUserDetails = new UserDetails();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //loop through counter with switch
            switch (count)
            {
                case 1:
                    lblText.Text = Resource1.lblText;
                    break;
                case 2:
                    lblText.Text = Resource1.lbltext2;
                    break;
                case 3:
                    lblText.Text = Resource1.lbltext3;
                    count = 0;
                    break;
            }
            count++;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            //If the file exists then load it
            if (File.Exists("words1.txt"))
            {
                // Read in lines from file.
                foreach (string line in File.ReadLines("words1.txt"))
                {
                    if (line.StartsWith("C") || line.StartsWith("B"))
                    {
                        listBox1.Items.Add(line);
                    }

                    //  listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("There is no file");
            }
        }

        private void btnLoadAllLines_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();

            lines.AddRange(File.ReadAllLines("words1.txt"));
            //do something with the array
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            string[] pets = { "cat", "dog", "Walrus" };
            if (!File.Exists("pets.txt"))
            {
                File.WriteAllLines("pets.txt", pets);
            }
            else
            {
                pets[0] = "camel";
                pets[1] = "Horse";
                pets[2] = "Rhino";
                File.AppendAllLines("pets.txt", pets);
            }

        }

        private void btnSR_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("words1.txt"))
            {
                string line;
                // Read and display lines from the file until the end of the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    //do stuff with the text such as read it to a text box or split it by comma to an array
                    //   string[] parts = line.Split(',');
                    listBox1.Items.Add(line);
                }
            }
        }

        private async void btnSRasync_Click(object sender, EventArgs e)
        {
            byte[] buffer;

            using (FileStream SourceStream = File.Open("Roger Zelazny.txt", FileMode.Open))
            {
                buffer = new byte[SourceStream.Length];

                await SourceStream.ReadAsync(buffer, 0, (int)SourceStream.Length);
            }

            lblOutput.Text = System.Text.Encoding.ASCII.GetString(buffer);
        }

        private async void btnReadAsync_Click(object sender, EventArgs e)
        {
            using (var reader = File.OpenText("Roger Zelazny.txt"))
            {
                lblOutput.Text = await reader.ReadToEndAsync();
            }
        }

        private void btnSaveUserPW_Click(object sender, EventArgs e)
        {
            //pass the user data to an array
            string[] Userdata = { txtUserName.Text + "," + txtPassword.Text };

            //if there is no file then make it
            if (!File.Exists("PW.txt"))
            {
                File.WriteAllLines("PW.txt", Userdata);
            }
            else
            { //add to it
                File.AppendAllLines("PW.txt", Userdata);
            }

            AddEncryption("PW.txt");
        }

        private void btnCheckUserPW_Click(object sender, EventArgs e)
        { //create a list of string arrays
            RemoveEncryption("PW.txt");
            List<string[]> User = new List<string[]>();

            foreach (string line in File.ReadLines("PW.txt"))
            {
                //add the details to the array and then to the list
                User.Add(line.Split(','));
            }

            for (int i = 0; i < User.Count; i++)
            {
                string[] data = User[i];
                if (txtUserName.Text == data[0] && txtPassword.Text == data[1])
                {
                    MessageBox.Show("Welcome " + data[0]);
                    return;
                }

            }

            MessageBox.Show(Resource1.ErrorTextForLogin);
        }

        public static void AddEncryption(string FileName)
        {

            File.Encrypt(FileName);

        }
        // Decrypt a file.
        public static void RemoveEncryption(string FileName)
        {
            File.Decrypt(FileName);
        }

    }
}
