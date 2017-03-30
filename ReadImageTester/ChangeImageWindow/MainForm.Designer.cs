namespace ChangeImageWindow
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
            this.panelImage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxCenter = new System.Windows.Forms.TextBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.panelProcessed = new System.Windows.Forms.Panel();
            this.buttonSaveProcessed = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMean = new System.Windows.Forms.TextBox();
            this.textBoxMeanS = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelImage.Location = new System.Drawing.Point(319, 12);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(512, 512);
            this.panelImage.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxMeanS);
            this.panel1.Controls.Add(this.textBoxMean);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonCompare);
            this.panel1.Controls.Add(this.buttonSaveProcessed);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxWidth);
            this.panel1.Controls.Add(this.textBoxCenter);
            this.panel1.Controls.Add(this.buttonProcess);
            this.panel1.Controls.Add(this.labelFile);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 512);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Center";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(98, 94);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(200, 20);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.Text = "400";
            // 
            // textBoxCenter
            // 
            this.textBoxCenter.Location = new System.Drawing.Point(98, 68);
            this.textBoxCenter.Name = "textBoxCenter";
            this.textBoxCenter.Size = new System.Drawing.Size(200, 20);
            this.textBoxCenter.TabIndex = 1;
            this.textBoxCenter.Text = "40";
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(3, 120);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(295, 34);
            this.buttonProcess.TabIndex = 3;
            this.buttonProcess.Text = "Process Window";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // labelFile
            // 
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(3, 40);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(295, 25);
            this.labelFile.TabIndex = 1;
            this.labelFile.Text = "label1";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(3, 3);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(295, 34);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open Image";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // panelProcessed
            // 
            this.panelProcessed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelProcessed.Location = new System.Drawing.Point(837, 11);
            this.panelProcessed.Name = "panelProcessed";
            this.panelProcessed.Size = new System.Drawing.Size(512, 512);
            this.panelProcessed.TabIndex = 1;
            // 
            // buttonSaveProcessed
            // 
            this.buttonSaveProcessed.Enabled = false;
            this.buttonSaveProcessed.Location = new System.Drawing.Point(3, 160);
            this.buttonSaveProcessed.Name = "buttonSaveProcessed";
            this.buttonSaveProcessed.Size = new System.Drawing.Size(295, 34);
            this.buttonSaveProcessed.TabIndex = 4;
            this.buttonSaveProcessed.Text = "Save Processed";
            this.buttonSaveProcessed.UseVisualStyleBackColor = true;
            this.buttonSaveProcessed.Click += new System.EventHandler(this.buttonSaveProcessed_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLoad);
            this.panel2.Location = new System.Drawing.Point(12, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1337, 47);
            this.panel2.TabIndex = 2;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(825, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(253, 34);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Load Image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(3, 200);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(295, 34);
            this.buttonCompare.TabIndex = 5;
            this.buttonCompare.Text = "Compare Images";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mean [0-255]";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mean (0-255)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMean
            // 
            this.textBoxMean.Location = new System.Drawing.Point(98, 240);
            this.textBoxMean.Name = "textBoxMean";
            this.textBoxMean.Size = new System.Drawing.Size(200, 20);
            this.textBoxMean.TabIndex = 6;
            this.textBoxMean.Text = "40";
            // 
            // textBoxMeanS
            // 
            this.textBoxMeanS.Location = new System.Drawing.Point(98, 266);
            this.textBoxMeanS.Name = "textBoxMeanS";
            this.textBoxMeanS.Size = new System.Drawing.Size(200, 20);
            this.textBoxMeanS.TabIndex = 7;
            this.textBoxMeanS.Text = "400";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelProcessed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelImage);
            this.Name = "MainForm";
            this.Text = "Main Window";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxCenter;
        private System.Windows.Forms.Panel panelProcessed;
        private System.Windows.Forms.Button buttonSaveProcessed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.TextBox textBoxMeanS;
        private System.Windows.Forms.TextBox textBoxMean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

