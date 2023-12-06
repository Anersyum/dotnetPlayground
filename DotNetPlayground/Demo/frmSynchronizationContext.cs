namespace Demo
{
    public partial class frmSyncContext : Form
    {
        private bool hasButtonBeenHoveredOver = false;

        public frmSyncContext()
        {
            InitializeComponent();
        }

        private async void btnStartThread_Click(object sender, EventArgs e)
        {
            SynchronizationContext ctx = SynchronizationContext.Current!;

            Thread thread2 = new(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(3));
                int threadId = Thread.CurrentThread.ManagedThreadId;

                ctx.Post(_ => lblThread2.Text = string.Format("From thread {0}", threadId), null);
            });

            Thread thread = new(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(3));

                ctx.Post(_ => lblThread1.Text = $"From thread { Thread.CurrentThread.ManagedThreadId }", null);
            });



            thread.Start();
            thread2.Start();
            
            //await Task.Delay(TimeSpan.FromSeconds(3));

            //SynchronizationContext.SetSynchronizationContext(null);
            
            //string message = "";
            //await Task.Run(() => 
            //{   
            //    message = $"From thread {Thread.CurrentThread.ManagedThreadId}";
            //});

            //lblThread1.Text = message;
        }

        private async void btnStartThread_MouseEnter(object sender, EventArgs e)
        {
            if (hasButtonBeenHoveredOver)
            {
                return;
            }

            int randomNumber = Random.Shared.Next(100, 200);

            Point point = new(randomNumber + btnStartThread.Location.X, randomNumber + btnStartThread.Location.Y);
            
            btnStartThread.Location = point;
            btnStartThread.Text = "Got ya :P";

            hasButtonBeenHoveredOver = true;
        }

        private void btnBlocking_Click(object sender, EventArgs e)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        //private async void btnBlocking_Click(object sender, EventArgs e)
        //{
        //    string tmpText = btnBlocking.Text;
        //    btnBlocking.Text = "Not blocking...";

        //    await Task.Run(() => Thread.Sleep(TimeSpan.FromSeconds(5)));

        //    btnBlocking.Text = tmpText;
        //}
    }
}