/*
 * Created by SharpDevelop.
 * User: hp
 * Date: 10.01.2021
 * Time: 15:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HYDRA
{
	partial class Form2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("HACKED", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 52);
			this.label1.TabIndex = 5;
			this.label1.Text = "FUCK THE SYSTEM\r\n\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(117, 79);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 30);
			this.button1.TabIndex = 4;
			this.button1.Text = "Kill";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(324, 121);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.ShowIcon = false;
			this.Text = "HYDRA";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F2close);
			this.Load += new System.EventHandler(this.Form2Load);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}
