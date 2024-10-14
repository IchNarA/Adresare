using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AndresarZadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int filescount = 0;
        int directoriescount = 0;
        string currentLocation = "";
        long directorySize = 0;
        
        Random Random = new Random();
        
        public void Struktury(string adresar)
        {
            directory_panel.Controls.Clear();
            string[] subory = Directory.GetFiles(adresar);
            string[] adresare = Directory.GetDirectories(adresar);


            Label nadpisLabel = new Label();
            nadpisLabel.Text = "Súbory v tomto adresári:";
            nadpisLabel.AutoSize = true;
            Font f = new Font("Arial",15,FontStyle.Bold);
            nadpisLabel.Font = f;
            directory_panel.Controls.Add(nadpisLabel);
            directory_panel.SetFlowBreak(nadpisLabel, true);
            

            if (subory.Length > 0)
            {
                
                foreach (string s in subory)
                {
                    FileInfo fileInfo = new FileInfo(s);
                    Label newLabel = new Label();
                    newLabel.Text = fileInfo.Name + " (" + Prevod((long)fileInfo.Length) + ")";
                    newLabel.Name = s;
                    newLabel.AutoSize = true;
                    Font a = new Font("Arial", 10);
                    newLabel.Font = a;
                    directory_panel.Controls.Add(newLabel);
                    filescount++;
                    SaveToFile(s);
                    directory_panel.SetFlowBreak(newLabel, true);
                }
                
            }
            else
            {
                Label newLabel = new Label();
                newLabel.Text = "V tomto adresári neexistuje súbor!";
                Font a = new Font("Arial", 10);
                newLabel.AutoSize = true;
                newLabel.Font = a;
                directory_panel.Controls.Add(newLabel);
                directory_panel.SetFlowBreak(newLabel, true);
            }

            
            Label filescounttext = new Label();
            filescounttext.Text = "Počet súborov v adresári: " + filescount;
            filescounttext.AutoSize = true;
            filescounttext.Font = f;
            directory_panel.Controls.Add(filescounttext);
            directory_panel.SetFlowBreak(filescounttext, true);

            Panel linePanel = new Panel();
            linePanel.BackColor = Color.Orange;
            linePanel.Size = new Size(800, 10);
            directory_panel.Controls.Add(linePanel);
            directory_panel.SetFlowBreak(linePanel, true);

            Label nadpisLabel2 = new Label();
            nadpisLabel2.Text = "Podadresáre:";
            nadpisLabel2.AutoSize = true;
            nadpisLabel2.Font = f;
            directory_panel.Controls.Add(nadpisLabel2);
            directory_panel.SetFlowBreak(nadpisLabel2, true);

            

            if (adresare.Length > 0)
            {
                
                foreach (string s in adresare)
                {
                    var startOfName = s.LastIndexOf("\\");
                    var fileName = s.Substring(startOfName + 1, s.Length - (startOfName + 1));
                    Button newButton = new Button();
                    newButton.Image = System.Drawing.Image.FromFile("folder.png");
                    newButton.BackColor = Color.LightBlue;
                    newButton.ImageAlign = ContentAlignment.MiddleLeft;
                    
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.Text = fileName;
                    newButton.Name = s;
                    newButton.Size = new Size(200, 50);
                    newButton.TextAlign = ContentAlignment.MiddleRight;
                    Font b = new Font("Elephant", 16, FontStyle.Bold);
                    newButton.Font = f;
                    
                    directoriescount++;
                    SaveToFile(s);
                    
                    directory_panel.Controls.Add(newButton);
                    newButton.Click += button_click_open;
                    
                }
                
            }
            else
            {
                Label newLabel = new Label();
                newLabel.Text = "V tomto adresári niesu žiadne podadresáre";
                Font a = new Font("Arial", 10);
                newLabel.AutoSize = true;
                newLabel.Font = a;
                directory_panel.Controls.Add(newLabel);
                directory_panel.SetFlowBreak(newLabel, true);
            }

            Label emptylabel = new Label();
            emptylabel.Width = 0;
            emptylabel.Height = 0;
            emptylabel.Margin = new Padding(0, 0, 0, 0);

            directory_panel.Controls.Add(emptylabel);
            directory_panel.SetFlowBreak(emptylabel, true);

            Label directoriescounttext = new Label();
            directoriescounttext.Text = "Počet podadresátov v adresári: " + directoriescount + " a adresár zaberá: " + Prevod(directorySize);
            directoriescounttext.AutoSize = true;
            directoriescounttext.Font = f;
            directory_panel.Controls.Add(directoriescounttext);
            directory_panel.SetFlowBreak(directoriescounttext, true);
            label2.Text = currentLocation;
            filescount = 0;
            directoriescount = 0;
        }

        public string Prevod(long cislo)
        {
            if (cislo >= 1000 && cislo < 1000000)
                return (cislo / 1000.0).ToString("0.00") + "kB";
            if (cislo >= 1000000 && cislo < 1000000000)
                return (cislo / 1000000.0).ToString("0.00") + "MB";
            if (cislo > 1000000000)
                return (cislo / 1000000000.0).ToString("0.00") + "GB";
            else
                return cislo.ToString() + "B";
        }

        public void SaveToFile(string text)
        {
            bool filefound = false;
            if (!File.Exists("vystup.txt"))
                File.AppendAllText("vystup.txt", text + "\n");
            string[] riadky = File.ReadAllLines("vystup.txt");
            foreach (string riadok in riadky)
            {
                if (riadok == text)
                {
                    filefound = true;
                    break;
                }
            }

            if (filefound == false)
                File.AppendAllText("vystup.txt", text + "\n");
        }


        public void button_click_open(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            string filepath = button.Name;
            currentLocation = filepath;
            DirectoryInfo directory = new DirectoryInfo(currentLocation);
            directorySize = directory.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length);
            Struktury(filepath);
        }

        

        private void button_Show_Click(object sender, EventArgs e)
        {
            
            string menoadr = inputBox.Text;  
            try
            {
                if (String.IsNullOrEmpty(menoadr))
                    throw new Exception("Musíš zadať adresár!");
                DirectoryInfo directory = new DirectoryInfo(menoadr);
                directorySize = directory.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length);
                currentLocation = menoadr;
                Struktury(menoadr);
            }
            catch(DirectoryNotFoundException)
            {
                MessageBox.Show("Takýto adresár neexistuje!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
           try
            {
                string previousLocation = currentLocation.Substring(0, currentLocation.LastIndexOf("\\"));
                currentLocation = previousLocation;
                DirectoryInfo directory = new DirectoryInfo(currentLocation);
                directorySize = directory.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length);
                Struktury(currentLocation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
