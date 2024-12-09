namespace CoursWork
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        bool isRunning;

        public Form1() => InitializeComponent();

        void Form1_Load(object sender, EventArgs e)
        {
            // saveSettingsFromNumerics();
            model.SaveSettings();
            saveSettingsFromNumerics();
        }

        void minAddrlbl_Click(object sender, EventArgs e)
        {
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            model.WorkingCycle();

            UpdateProcessDisplay();
            updateRamSizeLabel();
            updateRamBusySizeLabel();
            // updateProgressBar();
        }

        void startButt_Click(object sender, EventArgs e)
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

        void UpdateProcessDisplay()
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
                deviceQueueTextBox.AppendText(process?.ToString() + "\n");
            }

            cpuActProcTextBox.Text = model.cpu.ActiveProcess?.ToString().Trim();
            string forReplace = $"Priority [{model.device.ActiveProcess?.estimatedTime}] ";
            deviceActProcTextBox.Text = model.device.ActiveProcess?.ToString().Replace(forReplace, ""); ;
            stepLabel.Text = model.clock.Clock.ToString();
        }

        void saveSettingsFromNumerics()
        {
            model.initSettings(
                (double)intenistyNumericUpDown.Value,
                (int)minBurstNumericUpDown.Value,
                (int)maxBurstNumericUpDown.Value,
                (int)minAddrNumericUpDown.Value,
                (int)maxAddrNumericUpDown.Value,
                (int)memSizeNumericUpDown.Value
                );
        }

        void nextButt_Click(object sender, EventArgs e)
        {
            model.WorkingCycle();

            UpdateProcessDisplay();
            updateRamSizeLabel();
            updateRamBusySizeLabel();
        }

        void updateRamSizeLabel() => ramSizeLabel.Text = (memSizeNumericUpDown.Value).ToString();

        void updateRamBusySizeLabel()
        {
            occupiedSizeRamSizeLabel.Text = model.memorymanager.memory.OccupiedSize.ToString();
        }

        void saveButt_Click(object sender, EventArgs e) => saveSettingsFromNumerics();

        void endSessionButt_Click(object sender, EventArgs e) => Close();
    }
}