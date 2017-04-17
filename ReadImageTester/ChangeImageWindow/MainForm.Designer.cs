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
            this.buttonRawAsGrayscale = new System.Windows.Forms.Button();
            this.buttonReloadRaw = new System.Windows.Forms.Button();
            this.buttonLoadRaw = new System.Windows.Forms.Button();
            this.textBoxMeanS = new System.Windows.Forms.TextBox();
            this.textBoxMean = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.buttonSaveProcessed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxCenter = new System.Windows.Forms.TextBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.panelProcessed = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonApplyWindow = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.buttonApplyWindow);
            this.panel1.Controls.Add(this.buttonRawAsGrayscale);
            this.panel1.Controls.Add(this.buttonReloadRaw);
            this.panel1.Controls.Add(this.buttonLoadRaw);
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
            // buttonRawAsGrayscale
            // 
            this.buttonRawAsGrayscale.Location = new System.Drawing.Point(3, 372);
            this.buttonRawAsGrayscale.Name = "buttonRawAsGrayscale";
            this.buttonRawAsGrayscale.Size = new System.Drawing.Size(295, 34);
            this.buttonRawAsGrayscale.TabIndex = 10;
            this.buttonRawAsGrayscale.Text = "Load Raw as Grayscale";
            this.buttonRawAsGrayscale.UseVisualStyleBackColor = true;
            this.buttonRawAsGrayscale.Click += new System.EventHandler(this.buttonRawAsGrayscale_Click);
            // 
            // buttonReloadRaw
            // 
            this.buttonReloadRaw.Location = new System.Drawing.Point(3, 332);
            this.buttonReloadRaw.Name = "buttonReloadRaw";
            this.buttonReloadRaw.Size = new System.Drawing.Size(295, 34);
            this.buttonReloadRaw.TabIndex = 9;
            this.buttonReloadRaw.Text = "Reload Raw File";
            this.buttonReloadRaw.UseVisualStyleBackColor = true;
            this.buttonReloadRaw.Click += new System.EventHandler(this.buttonReloadRaw_Click);
            // 
            // buttonLoadRaw
            // 
            this.buttonLoadRaw.Location = new System.Drawing.Point(3, 292);
            this.buttonLoadRaw.Name = "buttonLoadRaw";
            this.buttonLoadRaw.Size = new System.Drawing.Size(295, 34);
            this.buttonLoadRaw.TabIndex = 8;
            this.buttonLoadRaw.Text = "Load Raw File";
            this.buttonLoadRaw.UseVisualStyleBackColor = true;
            this.buttonLoadRaw.Click += new System.EventHandler(this.buttonLoadRaw_Click);
            // 
            // textBoxMeanS
            // 
            this.textBoxMeanS.Location = new System.Drawing.Point(98, 266);
            this.textBoxMeanS.Name = "textBoxMeanS";
            this.textBoxMeanS.Size = new System.Drawing.Size(200, 20);
            this.textBoxMeanS.TabIndex = 7;
            this.textBoxMeanS.Text = "400";
            // 
            // textBoxMean
            // 
            this.textBoxMean.Location = new System.Drawing.Point(98, 240);
            this.textBoxMean.Name = "textBoxMean";
            this.textBoxMean.Size = new System.Drawing.Size(200, 20);
            this.textBoxMean.TabIndex = 6;
            this.textBoxMean.Text = "40";
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
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mean [0-255]";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxLog);
            this.panel2.Controls.Add(this.buttonLoad);
            this.panel2.Location = new System.Drawing.Point(12, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1337, 57);
            this.panel2.TabIndex = 2;
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxLog.Location = new System.Drawing.Point(3, 1);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(816, 53);
            this.textBoxLog.TabIndex = 11;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(825, 0);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(253, 34);
            this.buttonLoad.TabIndex = 12;
            this.buttonLoad.Text = "Load Image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonApplyWindow
            // 
            this.buttonApplyWindow.Location = new System.Drawing.Point(3, 412);
            this.buttonApplyWindow.Name = "buttonApplyWindow";
            this.buttonApplyWindow.Size = new System.Drawing.Size(295, 34);
            this.buttonApplyWindow.TabIndex = 11;
            this.buttonApplyWindow.Text = "Apply Window";
            this.buttonApplyWindow.UseVisualStyleBackColor = true;
            this.buttonApplyWindow.Click += new System.EventHandler(this.buttonApplyWindow_Click);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Main Window";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button buttonLoadRaw;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonReloadRaw;
        private System.Windows.Forms.Button buttonRawAsGrayscale;
        private System.Windows.Forms.Button buttonApplyWindow;
    }
}

