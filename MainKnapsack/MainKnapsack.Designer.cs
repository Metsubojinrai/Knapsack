namespace MainKnapsack
{
    partial class MainKnapsack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.numMutation = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numCrossOver = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numPopSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numGenLimit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numCities = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCities)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandomize
            // 
            this.btnRandomize.ForeColor = System.Drawing.Color.Crimson;
            this.btnRandomize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandomize.Location = new System.Drawing.Point(-154, 291);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(10, 37);
            this.btnRandomize.TabIndex = 16;
            this.btnRandomize.Text = "Randomize Data";
            this.btnRandomize.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(-159, 406);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(10, 58);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Solve !!\r\n";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(-154, 345);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(10, 37);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // numMutation
            // 
            this.numMutation.DecimalPlaces = 2;
            this.numMutation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numMutation.Location = new System.Drawing.Point(9, 275);
            this.numMutation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMutation.Name = "numMutation";
            this.numMutation.Size = new System.Drawing.Size(163, 20);
            this.numMutation.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mutation prob. (0.40 - 1.00)";
            // 
            // numCrossOver
            // 
            this.numCrossOver.DecimalPlaces = 2;
            this.numCrossOver.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numCrossOver.Location = new System.Drawing.Point(9, 217);
            this.numCrossOver.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCrossOver.Name = "numCrossOver";
            this.numCrossOver.Size = new System.Drawing.Size(163, 20);
            this.numCrossOver.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Crossover prob. (0.00 - 1.00)";
            // 
            // numPopSize
            // 
            this.numPopSize.Location = new System.Drawing.Point(9, 157);
            this.numPopSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopSize.Name = "numPopSize";
            this.numPopSize.Size = new System.Drawing.Size(163, 20);
            this.numPopSize.TabIndex = 2;
            this.numPopSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Population size (>1)";
            // 
            // numGenLimit
            // 
            this.numGenLimit.Location = new System.Drawing.Point(9, 100);
            this.numGenLimit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numGenLimit.Name = "numGenLimit";
            this.numGenLimit.Size = new System.Drawing.Size(163, 20);
            this.numGenLimit.TabIndex = 1;
            this.numGenLimit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Generations limit (>1)";
            // 
            // numCities
            // 
            this.numCities.Location = new System.Drawing.Point(9, 44);
            this.numCities.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCities.Name = "numCities";
            this.numCities.Size = new System.Drawing.Size(163, 20);
            this.numCities.TabIndex = 0;
            this.numCities.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of cities (4-99)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalCost);
            this.groupBox2.Location = new System.Drawing.Point(-189, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(10, 46);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total cost";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCost.Location = new System.Drawing.Point(7, 19);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalCost.Size = new System.Drawing.Size(17, 18);
            this.lblTotalCost.TabIndex = 0;
            this.lblTotalCost.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numMutation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numCrossOver);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numPopSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numGenLimit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numCities);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-189, -82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(10, 307);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.numericUpDown3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.numericUpDown4);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(3, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 255);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parameters";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.Location = new System.Drawing.Point(3, 220);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(163, 20);
            this.numericUpDown2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Crossover prob. (0.40 - 1.00)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(3, 153);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(163, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mutation prob. (0.01 - 0.1)";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(3, 91);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(163, 20);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Popultion Size (>1)";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(3, 36);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(163, 20);
            this.numericUpDown4.TabIndex = 1;
            this.numericUpDown4.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Generations limit (>1)";
            // 
            // btnData
            // 
            this.btnData.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnData.Location = new System.Drawing.Point(25, 408);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(107, 35);
            this.btnData.TabIndex = 24;
            this.btnData.Text = "Start";
            this.btnData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(190, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.Size = new System.Drawing.Size(554, 102);
            this.dataGridView1.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(3, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 115);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Knapsack";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Max weight";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Item Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Item set";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(215, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Initial population";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(580, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Current generation:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(683, 362);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "0";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.MediumBlue;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(290, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 32;
            this.button2.Text = "Next step";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.MediumBlue;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(511, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 35);
            this.button3.TabIndex = 33;
            this.button3.Text = "Final solution";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(287, 388);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Best fitness function:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(287, 413);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Best solution:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(398, 388);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "label 18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(383, 413);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "label 19";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(442, 442);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 16);
            this.label20.TabIndex = 39;
            this.label20.Text = "label 20";
            this.label20.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnData);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 541);
            this.panel1.TabIndex = 40;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(190, 155);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 120;
            this.dataGridView2.Size = new System.Drawing.Size(554, 204);
            this.dataGridView2.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(25, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 41;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainKnapsack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainKnapsack";
            this.Text = "Knapsack";
            ((System.ComponentModel.ISupportInitialize)(this.numMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCities)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown numMutation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCrossOver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPopSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numGenLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
    }
}

