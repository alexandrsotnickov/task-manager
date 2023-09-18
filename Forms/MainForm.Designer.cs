namespace Businescope.TaskManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.processesDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshGridViewTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.countProcessesLabel = new System.Windows.Forms.Label();
            this.pauseUpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.processesDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // processesDataGridView
            // 
            this.processesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.processesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.processesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.processesDataGridView, 4);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.processesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.processesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processesDataGridView.Location = new System.Drawing.Point(3, 68);
            this.processesDataGridView.Name = "processesDataGridView";
            this.processesDataGridView.ReadOnly = true;
            this.processesDataGridView.Size = new System.Drawing.Size(1090, 519);
            this.processesDataGridView.TabIndex = 0;
            this.processesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.processesDataGridView_CellDoubleClick);
            this.processesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.processesDataGridView_CellMouseClick);
            // 
            // refreshGridViewTimer
            // 
            this.refreshGridViewTimer.Interval = 1000;
            this.refreshGridViewTimer.Tick += new System.EventHandler(this.refreshGridViewTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9124088F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.60584F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.36131F));
            this.tableLayoutPanel1.Controls.Add(this.processesDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.countProcessesLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pauseUpdateButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.01695F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.98305F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1096, 590);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // countProcessesLabel
            // 
            this.countProcessesLabel.AutoSize = true;
            this.countProcessesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countProcessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countProcessesLabel.Location = new System.Drawing.Point(3, 0);
            this.countProcessesLabel.Name = "countProcessesLabel";
            this.countProcessesLabel.Size = new System.Drawing.Size(358, 65);
            this.countProcessesLabel.TabIndex = 1;
            this.countProcessesLabel.Text = "Запущено процессов:";
            this.countProcessesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pauseUpdateButton
            // 
            this.pauseUpdateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pauseUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauseUpdateButton.Location = new System.Drawing.Point(376, 3);
            this.pauseUpdateButton.Name = "pauseUpdateButton";
            this.pauseUpdateButton.Size = new System.Drawing.Size(175, 59);
            this.pauseUpdateButton.TabIndex = 2;
            this.pauseUpdateButton.Text = "Приостановить обновление данных";
            this.pauseUpdateButton.UseVisualStyleBackColor = true;
            this.pauseUpdateButton.Click += new System.EventHandler(this.pauseUpdateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 590);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Диспетчер задач";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processesDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView processesDataGridView;
        private System.Windows.Forms.Timer refreshGridViewTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label countProcessesLabel;
        private System.Windows.Forms.Button pauseUpdateButton;
    }
}