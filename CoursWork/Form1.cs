namespace CoursWork
{
    public partial class Form1 : Form
    {
        private Model model = new Model();
        private bool isRunning = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //saveSettingsFromNumerics();
            model.SaveSettings();
            saveSettingsFromNumerics();
        }


        private void minAddrlbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            model.WorkingCycle();

            UpdateProcessDisplay();
            updateRamSizeLabel();
            updateRamBusySizeLabel();
            //updateProgressBar();
        }

        private void startButt_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                timer1.Start();
                startButt.Text = "Стоп";
                isRunning = true;
            }
            else
            {
                timer1.Stop();
                startButt.Text = "Старт";
                isRunning = false;
            }
        }
        private void UpdateProcessDisplay()
        {
            cpuQueueTextBox.Clear();
            deviceQueueTextBox.Clear();
            foreach (var item in model.cpuscheduler.__queue.UnorderedItems)
            {
                var process = item.Element;

                cpuQueueTextBox.AppendText(process?.ToString().Trim() + "\n");
            }

            foreach (var process in model.DeviceQueue)
            {

                deviceQueueTextBox.AppendText($"Id: {process.id} | Burst time: {process.BurstTime} | Work time: {process.workTime}\n");
            }

            cpuActProcTextBox.Text = model.cpu.ActiveProcess?.ToString().Trim();
            deviceActProcTextBox.Text = model.device.ActiveProcess?.ToString().Trim();
            stepLabel.Text = model.clock.Clock.ToString();
        }
        private void saveSettingsFromNumerics()
        {
            model.initSettings(
                (double)this.intenistyNumericUpDown.Value,
                (int)this.minBurstNumericUpDown.Value,
                (int)this.maxBurstNumericUpDown.Value,
                (int)this.minAddrNumericUpDown.Value,
                (int)this.maxAddrNumericUpDown.Value,
                (int)this.memSizeNumericUpDown.Value
                );
        }

        private void nextButt_Click(object sender, EventArgs e)
        {
            model.WorkingCycle();

            UpdateProcessDisplay();
            updateRamSizeLabel();
            updateRamBusySizeLabel();
        }

        private void updateRamSizeLabel()
        {
            ramSizeLabel.Text = (memSizeNumericUpDown.Value).ToString();
        }

        private void updateRamBusySizeLabel()
        {

            occupiedSizeRamSizeLabel.Text = model.memorymanager.memory.OccupiedSize.ToString();
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            saveSettingsFromNumerics();
        }

        private void endSessionButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
