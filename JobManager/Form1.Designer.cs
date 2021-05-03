
namespace JobManager
{
    partial class JobManager
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
            this.departmentList = new System.Windows.Forms.ComboBox();
            this.inDepartment = new System.Windows.Forms.ListBox();
            this.inDepartmentLabel = new System.Windows.Forms.Label();
            this.curTask = new System.Windows.Forms.TextBox();
            this.startTaskButton = new System.Windows.Forms.Button();
            this.stopTaskButton = new System.Windows.Forms.Button();
            this.moveDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departmentList
            // 
            this.departmentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentList.FormattingEnabled = true;
            this.departmentList.Location = new System.Drawing.Point(13, 13);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(556, 23);
            this.departmentList.TabIndex = 0;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentList_SelectedIndexChanged);
            // 
            // inDepartment
            // 
            this.inDepartment.FormattingEnabled = true;
            this.inDepartment.ItemHeight = 15;
            this.inDepartment.Items.AddRange(new object[] {
            "test",
            "test2"});
            this.inDepartment.Location = new System.Drawing.Point(13, 76);
            this.inDepartment.Name = "inDepartment";
            this.inDepartment.Size = new System.Drawing.Size(556, 229);
            this.inDepartment.TabIndex = 2;
            this.inDepartment.SelectedIndexChanged += new System.EventHandler(this.inDepartment_SelectedIndexChanged);
            // 
            // inDepartmentLabel
            // 
            this.inDepartmentLabel.AutoSize = true;
            this.inDepartmentLabel.Location = new System.Drawing.Point(13, 55);
            this.inDepartmentLabel.Name = "inDepartmentLabel";
            this.inDepartmentLabel.Size = new System.Drawing.Size(109, 15);
            this.inDepartmentLabel.TabIndex = 3;
            this.inDepartmentLabel.Text = "Jobs In Department";
            this.inDepartmentLabel.Click += new System.EventHandler(this.inDepartmentLabel_Click);
            // 
            // curTask
            // 
            this.curTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curTask.Location = new System.Drawing.Point(13, 326);
            this.curTask.Name = "curTask";
            this.curTask.ReadOnly = true;
            this.curTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.curTask.Size = new System.Drawing.Size(556, 29);
            this.curTask.TabIndex = 4;
            this.curTask.Text = "00 - Current Task";
            // 
            // startTaskButton
            // 
            this.startTaskButton.Location = new System.Drawing.Point(13, 362);
            this.startTaskButton.Name = "startTaskButton";
            this.startTaskButton.Size = new System.Drawing.Size(269, 142);
            this.startTaskButton.TabIndex = 5;
            this.startTaskButton.Text = "Start Task";
            this.startTaskButton.UseVisualStyleBackColor = true;
            this.startTaskButton.Click += new System.EventHandler(this.startTaskButton_Click);
            // 
            // stopTaskButton
            // 
            this.stopTaskButton.Enabled = false;
            this.stopTaskButton.Location = new System.Drawing.Point(300, 362);
            this.stopTaskButton.Name = "stopTaskButton";
            this.stopTaskButton.Size = new System.Drawing.Size(269, 142);
            this.stopTaskButton.TabIndex = 6;
            this.stopTaskButton.Text = "Stop Task";
            this.stopTaskButton.UseVisualStyleBackColor = true;
            this.stopTaskButton.Click += new System.EventHandler(this.stopTaskButton_Click);
            // 
            // moveDepartment
            // 
            this.moveDepartment.Location = new System.Drawing.Point(13, 511);
            this.moveDepartment.Name = "moveDepartment";
            this.moveDepartment.Size = new System.Drawing.Size(269, 59);
            this.moveDepartment.TabIndex = 7;
            this.moveDepartment.Text = "Move Department";
            this.moveDepartment.UseVisualStyleBackColor = true;
            this.moveDepartment.Click += new System.EventHandler(this.moveDepartment_Click);
            // 
            // JobManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 637);
            this.Controls.Add(this.moveDepartment);
            this.Controls.Add(this.stopTaskButton);
            this.Controls.Add(this.startTaskButton);
            this.Controls.Add(this.curTask);
            this.Controls.Add(this.inDepartmentLabel);
            this.Controls.Add(this.inDepartment);
            this.Controls.Add(this.departmentList);
            this.Name = "JobManager";
            this.Text = "Job Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentList;
        private System.Windows.Forms.ListBox inDepartment;
        private System.Windows.Forms.Label inDepartmentLabel;
        private System.Windows.Forms.TextBox curTask;
        private System.Windows.Forms.Button startTaskButton;
        private System.Windows.Forms.Button stopTaskButton;
        private System.Windows.Forms.Button moveDepartment;
    }
}

