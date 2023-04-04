using System.Diagnostics;
using System.Xml;

namespace StarCitizen_Keybinding_Updater
{
    public partial class Form1 : Form
    {
        private string backupLocation { get; set; }
        private string liveLocation { get; set; }
        private string ptuLocation { get; set; }

        private string backupStoragePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\actionMapsLocation.txt";
        private string liveStoragePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\liveLocation.txt";
        private string ptuStoragePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\ptuLocation.txt";

        public Form1()
        {

            InitializeComponent();
            CreateIfDoesntExist();
            ReadFile(backupStoragePath);
            ReadFile(liveStoragePath);
            ReadFile(ptuStoragePath);
            updateLocationLabelText();
        }

        private void updateLocationLabelText()
        {
            backupLocationLabel.Text = backupLocation.Length > 0 ? backupLocation : "No File Path Set! Please Choose one.";

            liveLocationLabel.Text = liveLocation.Length > 0 ? liveLocation : "No File Path Set! Please Choose one.";
            
            ptuLocationLabel.Text = ptuLocation.Length > 0 ? ptuLocation : "No File Path Set! Please Choose one.";
        }

        private void CreateIfDoesntExist()
        {
            // Refactor to have files in subfolder
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (!File.Exists(backupStoragePath))
            {
                using (StreamWriter writer = File.CreateText(backupStoragePath))
                {
                    writer.WriteLine("");
                }
            }
            else
            {
                Debug.WriteLine("actionMapsLocation file already exists.");
            }

            if (!File.Exists(liveStoragePath))
            {
                using (StreamWriter writer = File.CreateText(liveStoragePath))
                {
                    writer.WriteLine("");
                }
            }
            else
            {
                Debug.WriteLine("live location file already exists.");
            }

            if (!File.Exists(ptuStoragePath))
            {
                using (StreamWriter writer = File.CreateText(ptuStoragePath))
                {
                    writer.WriteLine("");
                }
            }
            else
            {
                Debug.WriteLine("ptu location file already exists.");
            }
        }

        private void setFileLocation(string path, string line)
        {
            if (path.Contains("actionMapsLocation.txt"))
            {
                backupLocation = line.Contains("actionmaps.xml") ? line : "";
            }

            if(path.Contains("liveLocation.txt"))
            {
                liveLocation = line.Contains("actionmaps.xml") ? line : "";
            }

            if (path.Contains("ptuLocation.txt"))
            {
                ptuLocation = line.Contains("actionmaps.xml") ? line : "";
            }

        }

        private void ReadFile(string path)
        {
            // Read from the file
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    setFileLocation(path, line);
                    Debug.WriteLine($"READ LINE: {line}");
                }
            }
        }

        private void WriteToFile(string message, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(message);
            }
            ReadFile(backupStoragePath);
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                Debug.WriteLine($"ACTIONMAPSLOCATION: {selectedFileName}");
                WriteToFile(selectedFileName, backupStoragePath);
                updateLocationLabelText();
            }
        }

        private void browseLiveButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                liveLocation = selectedFileName;
                WriteToFile(selectedFileName, liveStoragePath);
            }
            updateLocationLabelText();
        }

        private void browsePtuButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                ptuLocation = selectedFileName;
                WriteToFile(selectedFileName, ptuStoragePath);
            }
            updateLocationLabelText();
        }

        private void UpdateLiveButton_Click(object sender, EventArgs e)
        {
            ClearOutcomeLabel();

            if (liveLocation.Length < 1 || backupLocation.Length < 1)
            {
                MessageBox.Show("Please ensure you have set the location for the backup and LIVE", "Error");
                return;
            }

            UpdateLiveButton.Enabled = false;
            // Load the contents of the source file into an XmlDocument object
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(backupLocation);

            // Write the contents of the XmlDocument object to the destination file
            using StreamWriter writer = new StreamWriter(liveLocation);
            xmlDoc.Save(writer);

            UpdateLiveButton.Enabled = true;
            OutcomeLabel.Text = "LIVE keybindings updated successfully!";
        }

        private void UpdatePtuButton_Click(object sender, EventArgs e)
        {
            ClearOutcomeLabel();

            if(ptuLocation.Length < 1 || backupLocation.Length < 1)
            {
                MessageBox.Show("Please ensure you have set the location for the backup and the PTU", "Error");
            }
            
            UpdatePtuButton.Enabled = false;

            // Load the contents of the source file into an XmlDocument object
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(backupLocation);

            // Write the contents of the XmlDocument object to the destination file
            using StreamWriter writer = new StreamWriter(ptuLocation);
            xmlDoc.Save(writer);

            UpdatePtuButton.Enabled = true;
            OutcomeLabel.Text = "PTU keybindings updated successfully!";
        }

        private void ClearOutcomeLabel()
        {
            OutcomeLabel.Text = string.Empty;
        }

        private void ClearLocationButton_Click(object sender, EventArgs e)
        {
            WriteToFile(string.Empty, backupStoragePath);
            backupLocation = "";
            updateLocationLabelText();
        }

        private void ClearLiveButton_Click(object sender, EventArgs e)
        {
            WriteToFile(string.Empty, liveStoragePath);
            liveLocation = "";
            updateLocationLabelText();
        }

        private void ClearPtuButton_Click(object sender, EventArgs e)
        {
            WriteToFile(string.Empty, ptuStoragePath);
            ptuLocation = "";
            updateLocationLabelText();
        }
    }
}