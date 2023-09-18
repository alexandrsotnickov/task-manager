namespace Businescope.TaskManager
{
    partial class InfoAboutProcessForm
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
            this.processInfoPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.updateInfoTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pauseUpdateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // processInfoPropertyGrid
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.processInfoPropertyGrid, 2);
            this.processInfoPropertyGrid.DisabledItemForeColor = System.Drawing.SystemColors.WindowText;
            this.processInfoPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processInfoPropertyGrid.Enabled = false;
            this.processInfoPropertyGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processInfoPropertyGrid.HelpVisible = false;
            this.processInfoPropertyGrid.Location = new System.Drawing.Point(3, 61);
            this.processInfoPropertyGrid.Name = "processInfoPropertyGrid";
            this.processInfoPropertyGrid.Size = new System.Drawing.Size(794, 386);
            this.processInfoPropertyGrid.TabIndex = 0;
            // 
            // updateInfoTimer
            // 
            this.updateInfoTimer.Interval = 1000;
            this.updateInfoTimer.Tick += new System.EventHandler(this.updateInfoTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.75F));
            this.tableLayoutPanel1.Controls.Add(this.pauseUpdateButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.processInfoPropertyGrid, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.222222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pauseUpdateButton
            // 
            this.pauseUpdateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pauseUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauseUpdateButton.Location = new System.Drawing.Point(3, 3);
            this.pauseUpdateButton.Name = "pauseUpdateButton";
            this.pauseUpdateButton.Size = new System.Drawing.Size(148, 43);
            this.pauseUpdateButton.TabIndex = 3;
            this.pauseUpdateButton.Text = "Приостановить обновление данных";
            this.pauseUpdateButton.UseVisualStyleBackColor = true;
            this.pauseUpdateButton.Click += new System.EventHandler(this.pauseUpdateButton_Click);
            // 
            // InfoAboutProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InfoAboutProcessForm";
            this.Text = "Расширенная информация о процессе";
            this.Load += new System.EventHandler(this.InfoAboutProcessForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid processInfoPropertyGrid;
        private System.Windows.Forms.Timer updateInfoTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button pauseUpdateButton;
    }
}