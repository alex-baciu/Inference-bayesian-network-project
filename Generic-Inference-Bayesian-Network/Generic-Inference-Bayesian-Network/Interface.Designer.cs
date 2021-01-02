namespace Generic_Inference_Bayesian_Network
{
    partial class GenericInferenceBayesianNetwork
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.radioOptionsPanel = new System.Windows.Forms.Panel();
            this.queryRadioButton = new System.Windows.Forms.RadioButton();
            this.observeRadioButton = new System.Windows.Forms.RadioButton();
            this.networkPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.radioOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.buttonsPanel);
            this.mainPanel.Controls.Add(this.radioOptionsPanel);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1160, 93);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buttonsPanel.Controls.Add(this.buttonClear);
            this.buttonsPanel.Controls.Add(this.buttonLoad);
            this.buttonsPanel.Controls.Add(this.buttonGenerate);
            this.buttonsPanel.Location = new System.Drawing.Point(352, 15);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(772, 59);
            this.buttonsPanel.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(315, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(159, 34);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(560, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(159, 34);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(67, 12);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(159, 34);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // radioOptionsPanel
            // 
            this.radioOptionsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.radioOptionsPanel.Controls.Add(this.queryRadioButton);
            this.radioOptionsPanel.Controls.Add(this.observeRadioButton);
            this.radioOptionsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOptionsPanel.Location = new System.Drawing.Point(29, 15);
            this.radioOptionsPanel.Name = "radioOptionsPanel";
            this.radioOptionsPanel.Size = new System.Drawing.Size(275, 59);
            this.radioOptionsPanel.TabIndex = 0;
            // 
            // queryRadioButton
            // 
            this.queryRadioButton.AutoSize = true;
            this.queryRadioButton.Location = new System.Drawing.Point(162, 18);
            this.queryRadioButton.Name = "queryRadioButton";
            this.queryRadioButton.Size = new System.Drawing.Size(85, 28);
            this.queryRadioButton.TabIndex = 1;
            this.queryRadioButton.TabStop = true;
            this.queryRadioButton.Text = "Query";
            this.queryRadioButton.UseVisualStyleBackColor = true;
            // 
            // observeRadioButton
            // 
            this.observeRadioButton.AutoSize = true;
            this.observeRadioButton.Location = new System.Drawing.Point(19, 18);
            this.observeRadioButton.Name = "observeRadioButton";
            this.observeRadioButton.Size = new System.Drawing.Size(107, 28);
            this.observeRadioButton.TabIndex = 0;
            this.observeRadioButton.TabStop = true;
            this.observeRadioButton.Text = "Observe";
            this.observeRadioButton.UseVisualStyleBackColor = true;
            // 
            // networkPictureBox
            // 
            this.networkPictureBox.BackColor = System.Drawing.Color.White;
            this.networkPictureBox.Location = new System.Drawing.Point(12, 132);
            this.networkPictureBox.Name = "networkPictureBox";
            this.networkPictureBox.Size = new System.Drawing.Size(1160, 504);
            this.networkPictureBox.TabIndex = 1;
            this.networkPictureBox.TabStop = false;
            this.networkPictureBox.Click += new System.EventHandler(this.networkPictureBox_Click);
            // 
            // GenericInferenceBayesianNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.networkPictureBox);
            this.Controls.Add(this.mainPanel);
            this.Name = "GenericInferenceBayesianNetwork";
            this.Text = "GenericInferenceBayesianNetwork";
            this.mainPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.radioOptionsPanel.ResumeLayout(false);
            this.radioOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel radioOptionsPanel;
        private System.Windows.Forms.RadioButton observeRadioButton;
        private System.Windows.Forms.RadioButton queryRadioButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.PictureBox networkPictureBox;
    }
}

