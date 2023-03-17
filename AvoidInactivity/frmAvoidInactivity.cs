namespace AvoidInactivity
{
    public partial class frmAvoidInactivity : Form
    {
        const string LAST_ACTIVITY = "Last activity:";
        const string KEY = "^q";
        const string ACTIVATE = "Process activate: The inactivity is now being avoided.";
        const string INACTIVATE = "Process inactivate";

        const int INTERVAL = 3000;

        public frmAvoidInactivity()
        {
            InitializeComponent();
            lblLastActivity.Text = LAST_ACTIVITY;
        }


        private void ProcessActivity()
        {
            SendKeys.Send(KEY);
            lblLastActivity.Text =$"{LAST_ACTIVITY} {DateTime.Now}";
        }

        private void StartTimer()
        {  
            Timer1.Interval = INTERVAL;
            Timer1.Tick += new EventHandler(Timer1_Tick);

            // Enable timer.  
            Timer1.Enabled = true;

            lblStatus.Text = ACTIVATE;
            lblStatus.ForeColor = SystemColors.ControlText;
        }
        private void StopTimer()
        {
            Timer1.Tick -= new EventHandler(Timer1_Tick);

            Timer1.Enabled = false;

            lblStatus.Text = INACTIVATE;
            lblStatus.ForeColor = Color.Red;
        }
        private void Timer1_Tick(object Sender, EventArgs e)
        {
            ProcessActivity();
        }

        private void frmAvoidInactivity_Activated(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void frmAvoidInactivity_Deactivate(object sender, EventArgs e)
        {
            StopTimer();
        }
    }
}