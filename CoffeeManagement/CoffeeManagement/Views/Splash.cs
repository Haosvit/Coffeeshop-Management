using CoffeeManagement.DAO;
using CoffeeManagement.Views;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SetStatus("Đang tải...");
            _backgroundWorker.DoWork += DoLoading;
            _backgroundWorker.RunWorkerCompleted += OnWorkCompleted;

            _backgroundWorker.RunWorkerAsync();
        }

        private void OnWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetStatus("Xong.");
            Login loginForm = new Login();
            Hide();
            loginForm.Show();
        }

        private void DoLoading(object sender, DoWorkEventArgs e)
        {
            CoffeeDbContext dbContext = new CoffeeDbContext();

        }

        private void SetStatus(string status)
        {
            _lbStatus.Text = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.CancelAsync();
            Application.Exit();
        }
	}
}
