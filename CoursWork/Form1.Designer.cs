namespace CoursWork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Intensitylbl = new Label();
            intenistyNumericUpDown = new NumericUpDown();
            cpuActProcTextBox = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            minBurstlbl = new Label();
            minBurstNumericUpDown = new NumericUpDown();
            flowLayoutPanel3 = new FlowLayoutPanel();
            maxBurstlbl = new Label();
            maxBurstNumericUpDown = new NumericUpDown();
            flowLayoutPanel4 = new FlowLayoutPanel();
            memorySizelbl = new Label();
            memSizeNumericUpDown = new NumericUpDown();
            flowLayoutPanel5 = new FlowLayoutPanel();
            minAddrlbl = new Label();
            minAddrNumericUpDown = new NumericUpDown();
            flowLayoutPanel6 = new FlowLayoutPanel();
            maxAddrlbl = new Label();
            maxAddrNumericUpDown = new NumericUpDown();
            flowLayoutPanel7 = new FlowLayoutPanel();
            cpuActProclabel = new Label();
            flowLayoutPanel8 = new FlowLayoutPanel();
            deviceActProcLabel = new Label();
            deviceActProcTextBox = new TextBox();
            flowLayoutPanel9 = new FlowLayoutPanel();
            label3 = new Label();
            cpuQueueTextBox = new RichTextBox();
            flowLayoutPanel10 = new FlowLayoutPanel();
            label4 = new Label();
            deviceQueueTextBox = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            startButt = new Button();
            saveButt = new Button();
            nextButt = new Button();
            endSessionButt = new Button();
            stepLabel = new Label();
            ramSizeLabel = new Label();
            occupiedSizeRamSizeLabel = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)intenistyNumericUpDown).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minBurstNumericUpDown).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxBurstNumericUpDown).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memSizeNumericUpDown).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minAddrNumericUpDown).BeginInit();
            flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxAddrNumericUpDown).BeginInit();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            flowLayoutPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Intensitylbl);
            flowLayoutPanel1.Controls.Add(intenistyNumericUpDown);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(138, 70);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Intensitylbl
            // 
            Intensitylbl.AutoSize = true;
            Intensitylbl.Location = new Point(3, 0);
            Intensitylbl.Name = "Intensitylbl";
            Intensitylbl.Size = new Size(64, 40);
            Intensitylbl.TabIndex = 1;
            Intensitylbl.Text = "Intensity\r\n\r\n";
            // 
            // intenistyNumericUpDown
            // 
            intenistyNumericUpDown.DecimalPlaces = 1;
            intenistyNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            intenistyNumericUpDown.Location = new Point(3, 43);
            intenistyNumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 589824 });
            intenistyNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            intenistyNumericUpDown.Name = "intenistyNumericUpDown";
            intenistyNumericUpDown.Size = new Size(135, 27);
            intenistyNumericUpDown.TabIndex = 3;
            intenistyNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // cpuActProcTextBox
            // 
            cpuActProcTextBox.Location = new Point(3, 23);
            cpuActProcTextBox.Name = "cpuActProcTextBox";
            cpuActProcTextBox.Size = new Size(345, 27);
            cpuActProcTextBox.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(minBurstlbl);
            flowLayoutPanel2.Controls.Add(minBurstNumericUpDown);
            flowLayoutPanel2.Location = new Point(156, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(138, 70);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // minBurstlbl
            // 
            minBurstlbl.AutoSize = true;
            minBurstlbl.Location = new Point(3, 0);
            minBurstlbl.Name = "minBurstlbl";
            minBurstlbl.Size = new Size(132, 40);
            minBurstlbl.TabIndex = 1;
            minBurstlbl.Text = "Min value of burst time";
            // 
            // minBurstNumericUpDown
            // 
            minBurstNumericUpDown.Location = new Point(3, 43);
            minBurstNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            minBurstNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            minBurstNumericUpDown.Name = "minBurstNumericUpDown";
            minBurstNumericUpDown.Size = new Size(135, 27);
            minBurstNumericUpDown.TabIndex = 3;
            minBurstNumericUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(maxBurstlbl);
            flowLayoutPanel3.Controls.Add(maxBurstNumericUpDown);
            flowLayoutPanel3.Location = new Point(300, 12);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(138, 70);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // maxBurstlbl
            // 
            maxBurstlbl.AutoSize = true;
            maxBurstlbl.Location = new Point(3, 0);
            maxBurstlbl.Name = "maxBurstlbl";
            maxBurstlbl.Size = new Size(131, 40);
            maxBurstlbl.TabIndex = 1;
            maxBurstlbl.Text = "Max value of burst time";
            // 
            // maxBurstNumericUpDown
            // 
            maxBurstNumericUpDown.Location = new Point(3, 43);
            maxBurstNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            maxBurstNumericUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            maxBurstNumericUpDown.Name = "maxBurstNumericUpDown";
            maxBurstNumericUpDown.Size = new Size(135, 27);
            maxBurstNumericUpDown.TabIndex = 3;
            maxBurstNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(memorySizelbl);
            flowLayoutPanel4.Controls.Add(memSizeNumericUpDown);
            flowLayoutPanel4.Location = new Point(444, 12);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(138, 70);
            flowLayoutPanel4.TabIndex = 5;
            // 
            // memorySizelbl
            // 
            memorySizelbl.AutoSize = true;
            memorySizelbl.Location = new Point(3, 0);
            memorySizelbl.Name = "memorySizelbl";
            memorySizelbl.Size = new Size(93, 40);
            memorySizelbl.TabIndex = 1;
            memorySizelbl.Text = "Memory size\r\n\r\n";
            // 
            // memSizeNumericUpDown
            // 
            memSizeNumericUpDown.Increment = new decimal(new int[] { 512, 0, 0, 0 });
            memSizeNumericUpDown.Location = new Point(3, 43);
            memSizeNumericUpDown.Maximum = new decimal(new int[] { 65536, 0, 0, 0 });
            memSizeNumericUpDown.Minimum = new decimal(new int[] { 1024, 0, 0, 0 });
            memSizeNumericUpDown.Name = "memSizeNumericUpDown";
            memSizeNumericUpDown.Size = new Size(135, 27);
            memSizeNumericUpDown.TabIndex = 3;
            memSizeNumericUpDown.Value = new decimal(new int[] { 1024, 0, 0, 0 });
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(minAddrlbl);
            flowLayoutPanel5.Controls.Add(minAddrNumericUpDown);
            flowLayoutPanel5.Location = new Point(588, 12);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(138, 70);
            flowLayoutPanel5.TabIndex = 6;
            // 
            // minAddrlbl
            // 
            minAddrlbl.AutoSize = true;
            minAddrlbl.Location = new Point(3, 0);
            minAddrlbl.Name = "minAddrlbl";
            minAddrlbl.Size = new Size(132, 40);
            minAddrlbl.TabIndex = 1;
            minAddrlbl.Text = "Min value of Addr space";
            minAddrlbl.Click += minAddrlbl_Click;
            // 
            // minAddrNumericUpDown
            // 
            minAddrNumericUpDown.Location = new Point(3, 43);
            minAddrNumericUpDown.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            minAddrNumericUpDown.Minimum = new decimal(new int[] { 128, 0, 0, 0 });
            minAddrNumericUpDown.Name = "minAddrNumericUpDown";
            minAddrNumericUpDown.Size = new Size(135, 27);
            minAddrNumericUpDown.TabIndex = 3;
            minAddrNumericUpDown.Value = new decimal(new int[] { 128, 0, 0, 0 });
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(maxAddrlbl);
            flowLayoutPanel6.Controls.Add(maxAddrNumericUpDown);
            flowLayoutPanel6.Location = new Point(732, 12);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(138, 70);
            flowLayoutPanel6.TabIndex = 4;
            // 
            // maxAddrlbl
            // 
            maxAddrlbl.AutoSize = true;
            maxAddrlbl.Location = new Point(3, 0);
            maxAddrlbl.Name = "maxAddrlbl";
            maxAddrlbl.Size = new Size(131, 40);
            maxAddrlbl.TabIndex = 1;
            maxAddrlbl.Text = "Max value of Addr Space";
            // 
            // maxAddrNumericUpDown
            // 
            maxAddrNumericUpDown.Location = new Point(3, 43);
            maxAddrNumericUpDown.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            maxAddrNumericUpDown.Minimum = new decimal(new int[] { 256, 0, 0, 0 });
            maxAddrNumericUpDown.Name = "maxAddrNumericUpDown";
            maxAddrNumericUpDown.Size = new Size(135, 27);
            maxAddrNumericUpDown.TabIndex = 3;
            maxAddrNumericUpDown.Value = new decimal(new int[] { 256, 0, 0, 0 });
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(cpuActProclabel);
            flowLayoutPanel7.Controls.Add(cpuActProcTextBox);
            flowLayoutPanel7.Location = new Point(88, 160);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(350, 50);
            flowLayoutPanel7.TabIndex = 7;
            // 
            // cpuActProclabel
            // 
            cpuActProclabel.AutoSize = true;
            cpuActProclabel.Location = new Point(3, 0);
            cpuActProclabel.Name = "cpuActProclabel";
            cpuActProclabel.Size = new Size(35, 20);
            cpuActProclabel.TabIndex = 8;
            cpuActProclabel.Text = "Cpu";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(deviceActProcLabel);
            flowLayoutPanel8.Controls.Add(deviceActProcTextBox);
            flowLayoutPanel8.Location = new Point(591, 160);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(351, 50);
            flowLayoutPanel8.TabIndex = 8;
            // 
            // deviceActProcLabel
            // 
            deviceActProcLabel.AutoSize = true;
            deviceActProcLabel.Location = new Point(3, 0);
            deviceActProcLabel.Name = "deviceActProcLabel";
            deviceActProcLabel.Size = new Size(54, 20);
            deviceActProcLabel.TabIndex = 8;
            deviceActProcLabel.Text = "Device";
            // 
            // deviceActProcTextBox
            // 
            deviceActProcTextBox.Location = new Point(3, 23);
            deviceActProcTextBox.Name = "deviceActProcTextBox";
            deviceActProcTextBox.Size = new Size(345, 27);
            deviceActProcTextBox.TabIndex = 2;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(label3);
            flowLayoutPanel9.Controls.Add(cpuQueueTextBox);
            flowLayoutPanel9.Location = new Point(88, 232);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(348, 206);
            flowLayoutPanel9.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 0;
            label3.Text = "CPU queue";
            // 
            // cpuQueueTextBox
            // 
            cpuQueueTextBox.Location = new Point(3, 23);
            cpuQueueTextBox.Name = "cpuQueueTextBox";
            cpuQueueTextBox.Size = new Size(343, 175);
            cpuQueueTextBox.TabIndex = 1;
            cpuQueueTextBox.Text = "";
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.Controls.Add(label4);
            flowLayoutPanel10.Controls.Add(deviceQueueTextBox);
            flowLayoutPanel10.Location = new Point(588, 232);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(348, 206);
            flowLayoutPanel10.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 0;
            label4.Text = "Devices queue";
            // 
            // deviceQueueTextBox
            // 
            deviceQueueTextBox.Location = new Point(3, 23);
            deviceQueueTextBox.Name = "deviceQueueTextBox";
            deviceQueueTextBox.Size = new Size(343, 175);
            deviceQueueTextBox.TabIndex = 1;
            deviceQueueTextBox.Text = "";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // startButt
            // 
            startButt.Location = new Point(447, 472);
            startButt.Name = "startButt";
            startButt.Size = new Size(94, 29);
            startButt.TabIndex = 11;
            startButt.Text = "Start";
            startButt.UseVisualStyleBackColor = true;
            startButt.Click += startButt_Click;
            // 
            // saveButt
            // 
            saveButt.Location = new Point(547, 472);
            saveButt.Name = "saveButt";
            saveButt.Size = new Size(130, 29);
            saveButt.TabIndex = 12;
            saveButt.Text = "Save settings";
            saveButt.UseVisualStyleBackColor = true;
            saveButt.Click += saveButt_Click;
            // 
            // nextButt
            // 
            nextButt.Location = new Point(683, 472);
            nextButt.Name = "nextButt";
            nextButt.Size = new Size(94, 29);
            nextButt.TabIndex = 13;
            nextButt.Text = "Next";
            nextButt.UseVisualStyleBackColor = true;
            nextButt.Click += nextButt_Click;
            // 
            // endSessionButt
            // 
            endSessionButt.Location = new Point(783, 472);
            endSessionButt.Name = "endSessionButt";
            endSessionButt.Size = new Size(94, 29);
            endSessionButt.TabIndex = 14;
            endSessionButt.Text = "End session";
            endSessionButt.UseVisualStyleBackColor = true;
            endSessionButt.Click += endSessionButt_Click;
            // 
            // stepLabel
            // 
            stepLabel.AutoSize = true;
            stepLabel.Font = new Font("Segoe UI", 14F);
            stepLabel.Location = new Point(499, 267);
            stepLabel.Name = "stepLabel";
            stepLabel.Size = new Size(27, 32);
            stepLabel.TabIndex = 15;
            stepLabel.Text = "0";
            // 
            // ramSizeLabel
            // 
            ramSizeLabel.AutoSize = true;
            ramSizeLabel.Location = new Point(118, 450);
            ramSizeLabel.Name = "ramSizeLabel";
            ramSizeLabel.Size = new Size(41, 20);
            ramSizeLabel.TabIndex = 16;
            ramSizeLabel.Text = "1024";
            // 
            // occupiedSizeRamSizeLabel
            // 
            occupiedSizeRamSizeLabel.AutoSize = true;
            occupiedSizeRamSizeLabel.Location = new Point(118, 481);
            occupiedSizeRamSizeLabel.Name = "occupiedSizeRamSizeLabel";
            occupiedSizeRamSizeLabel.Size = new Size(17, 20);
            occupiedSizeRamSizeLabel.TabIndex = 17;
            occupiedSizeRamSizeLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 525);
            Controls.Add(occupiedSizeRamSizeLabel);
            Controls.Add(ramSizeLabel);
            Controls.Add(stepLabel);
            Controls.Add(endSessionButt);
            Controls.Add(nextButt);
            Controls.Add(saveButt);
            Controls.Add(startButt);
            Controls.Add(flowLayoutPanel10);
            Controls.Add(flowLayoutPanel9);
            Controls.Add(flowLayoutPanel8);
            Controls.Add(flowLayoutPanel7);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)intenistyNumericUpDown).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minBurstNumericUpDown).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxBurstNumericUpDown).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memSizeNumericUpDown).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minAddrNumericUpDown).EndInit();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxAddrNumericUpDown).EndInit();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            flowLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label Intensitylbl;
        private NumericUpDown intenistyNumericUpDown;
        private TextBox cpuActProcTextBox;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label minBurstlbl;
        private NumericUpDown minBurstNumericUpDown;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label maxBurstlbl;
        private NumericUpDown maxBurstNumericUpDown;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label memorySizelbl;
        private NumericUpDown memSizeNumericUpDown;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label minAddrlbl;
        private NumericUpDown minAddrNumericUpDown;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label maxAddrlbl;
        private NumericUpDown maxAddrNumericUpDown;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label cpuActProclabel;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label deviceActProcLabel;
        private TextBox deviceActProcTextBox;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label label3;
        private RichTextBox cpuQueueTextBox;
        private FlowLayoutPanel flowLayoutPanel10;
        private Label label4;
        private RichTextBox deviceQueueTextBox;
        private System.Windows.Forms.Timer timer1;
        private Button startButt;
        private Button saveButt;
        private Button nextButt;
        private Button endSessionButt;
        private Label stepLabel;
        private Label ramSizeLabel;
        private Label occupiedSizeRamSizeLabel;
    }
}
