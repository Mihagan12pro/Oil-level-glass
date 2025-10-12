using System.ComponentModel;
using System.IO.Compression;

namespace DependenciesManager
{
    public partial class MainForm : Form
    {
        private BackgroundWorker _backgroundworker = new BackgroundWorker();

        private bool _shutdown = false;


        public MainForm()
        {
            InitializeComponent();
        }


        private void BrowsingButtons_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();

            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                if (!(sender is Button))
                    throw new InvalidDataException();

                Button button = (Button)sender;

                if (button == btSearchKompasFolder)
                {
                    tbKompasFolder.Text = browserDialog.SelectedPath;

                    return;
                }

                tbInstallFolder.Text = browserDialog.SelectedPath;
            }
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            _backgroundworker.DoWork += BackgroundWorker_DoWork;
            _backgroundworker.RunWorkerCompleted += Backgroundworker_RunWorkerCompleted;
            _backgroundworker.RunWorkerAsync();
        }


        private void Backgroundworker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            
        }


        private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            while (!_shutdown)
            {
                CheckFormData();

                Thread.Sleep(500);
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _shutdown = true; 
        }


        private void CheckFormData()
        {
            string CSharpArchive = $"{tbKompasFolder}\\SDK\\Samples\\CSharp.zip";

            //ZipFile.ExtractToDirectory(CSharpArchive, "");
            File.Copy(CSharpArchive, "CSharp.zip");
        }
    }
}
