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
            this.mainPanel.Location = new System.Drawing.Point(16, 15);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1545, 114);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buttonsPanel.Controls.Add(this.buttonClear);
            this.buttonsPanel.Controls.Add(this.buttonLoad);
            this.buttonsPanel.Controls.Add(this.buttonGenerate);
            this.buttonsPanel.Location = new System.Drawing.Point(469, 18);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(1028, 72);
            this.buttonsPanel.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(420, 15);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(212, 42);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(747, 15);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(212, 42);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(89, 15);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(212, 42);
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
            this.radioOptionsPanel.Location = new System.Drawing.Point(39, 18);
            this.radioOptionsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioOptionsPanel.Name = "radioOptionsPanel";
            this.radioOptionsPanel.Size = new System.Drawing.Size(365, 72);
            this.radioOptionsPanel.TabIndex = 0;
            // 
            // queryRadioButton
            // 
            this.queryRadioButton.AutoSize = true;
            this.queryRadioButton.Location = new System.Drawing.Point(216, 22);
            this.queryRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.queryRadioButton.Name = "queryRadioButton";
            this.queryRadioButton.Size = new System.Drawing.Size(104, 33);
            this.queryRadioButton.TabIndex = 1;
            this.queryRadioButton.TabStop = true;
            this.queryRadioButton.Text = "Query";
            this.queryRadioButton.UseVisualStyleBackColor = true;
            // 
            // observeRadioButton
            // 
            this.observeRadioButton.AutoSize = true;
            this.observeRadioButton.Location = new System.Drawing.Point(25, 22);
            this.observeRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.observeRadioButton.Name = "observeRadioButton";
            this.observeRadioButton.Size = new System.Drawing.Size(133, 33);
            this.observeRadioButton.TabIndex = 0;
            this.observeRadioButton.TabStop = true;
            this.observeRadioButton.Text = "Observe";
            this.observeRadioButton.UseVisualStyleBackColor = true;
            // 
            // networkPictureBox
            // 
            this.networkPictureBox.BackColor = System.Drawing.Color.White;
            this.networkPictureBox.Location = new System.Drawing.Point(16, 162);
            this.networkPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.networkPictureBox.Name = "networkPictureBox";
            this.networkPictureBox.Size = new System.Drawing.Size(1547, 700);
            this.networkPictureBox.TabIndex = 1;
            this.networkPictureBox.TabStop = false;
            this.networkPictureBox.Click += new System.EventHandler(this.networkPictureBox_Click);
            // 
            // GenericInferenceBayesianNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.networkPictureBox);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

