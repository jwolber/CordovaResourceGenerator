using System;

namespace CordovaResourceGenerator
{
	partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generateBtn = new System.Windows.Forms.Button();
            this.logoPath = new System.Windows.Forms.TextBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.colorBtn = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.TextBox();
            this.destinationBtn = new System.Windows.Forms.Button();
            this.logoBtn = new System.Windows.Forms.Button();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.transparentBG = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(11, 249);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(338, 51);
            this.generateBtn.TabIndex = 0;
            this.generateBtn.Text = "Generate Resources";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // logoPath
            // 
            this.logoPath.Location = new System.Drawing.Point(12, 35);
            this.logoPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoPath.Name = "logoPath";
            this.logoPath.ReadOnly = true;
            this.logoPath.Size = new System.Drawing.Size(256, 25);
            this.logoPath.TabIndex = 1;
            this.logoPath.Text = "cordova.png";
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Myriad Pro Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(9, 13);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(57, 18);
            this.logoLabel.TabIndex = 2;
            this.logoLabel.Text = "Logo Path:";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(9, 79);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(87, 18);
            this.destinationLabel.TabIndex = 3;
            this.destinationLabel.Text = "Destination Path:";
            // 
            // destinationPath
            // 
            this.destinationPath.Location = new System.Drawing.Point(12, 101);
            this.destinationPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.ReadOnly = true;
            this.destinationPath.Size = new System.Drawing.Size(256, 25);
            this.destinationPath.TabIndex = 4;
            this.destinationPath.Text = "C:\\Users\\justinw\\Desktop";
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(274, 159);
            this.colorBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(75, 32);
            this.colorBtn.TabIndex = 5;
            this.colorBtn.Text = "Select";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.Black;
            this.color.Location = new System.Drawing.Point(11, 163);
            this.color.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Size = new System.Drawing.Size(257, 25);
            this.color.TabIndex = 6;
            // 
            // destinationBtn
            // 
            this.destinationBtn.Location = new System.Drawing.Point(274, 97);
            this.destinationBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.destinationBtn.Name = "destinationBtn";
            this.destinationBtn.Size = new System.Drawing.Size(75, 32);
            this.destinationBtn.TabIndex = 7;
            this.destinationBtn.Text = "Browse";
            this.destinationBtn.UseVisualStyleBackColor = true;
            this.destinationBtn.Click += new System.EventHandler(this.destinationBtn_Click);
            // 
            // logoBtn
            // 
            this.logoBtn.Location = new System.Drawing.Point(274, 31);
            this.logoBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoBtn.Name = "logoBtn";
            this.logoBtn.Size = new System.Drawing.Size(75, 32);
            this.logoBtn.TabIndex = 8;
            this.logoBtn.Text = "Browse";
            this.logoBtn.UseVisualStyleBackColor = true;
            this.logoBtn.Click += new System.EventHandler(this.logoBtn_Click);
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Location = new System.Drawing.Point(8, 141);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(93, 18);
            this.backgroundLabel.TabIndex = 9;
            this.backgroundLabel.Text = "Background Color:";
            // 
            // transparentBG
            // 
            this.transparentBG.AutoSize = true;
            this.transparentBG.Location = new System.Drawing.Point(13, 210);
            this.transparentBG.Name = "transparentBG";
            this.transparentBG.Size = new System.Drawing.Size(137, 22);
            this.transparentBG.TabIndex = 10;
            this.transparentBG.Text = "Transparent Background";
            this.transparentBG.UseVisualStyleBackColor = true;
            this.transparentBG.CheckedChanged += new System.EventHandler(this.transparentBG_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 313);
            this.Controls.Add(this.transparentBG);
            this.Controls.Add(this.backgroundLabel);
            this.Controls.Add(this.logoBtn);
            this.Controls.Add(this.destinationBtn);
            this.Controls.Add(this.color);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.destinationPath);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.logoPath);
            this.Controls.Add(this.generateBtn);
            this.Font = new System.Drawing.Font("Myriad Pro Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Cordova Resource Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button generateBtn;
		private System.Windows.Forms.TextBox logoPath;
		private System.Windows.Forms.Label logoLabel;
		private System.Windows.Forms.Label destinationLabel;
		private System.Windows.Forms.TextBox destinationPath;
		private System.Windows.Forms.Button colorBtn;
		private System.Windows.Forms.TextBox color;
		private System.Windows.Forms.Button destinationBtn;
		private System.Windows.Forms.Button logoBtn;
		private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.CheckBox transparentBG;
    }
}

