﻿namespace T1_pregunta10_ventana
{
    partial class Form1
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            lbl = new System.Windows.Forms.Label();
            txtb1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(77, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(277, 19);
            label1.TabIndex = 0;
            label1.Text = "Cuánto es su consumo de kilowatt por hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(88, 132);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "Total mensual";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(164, 178);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(67, 36);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl.Location = new System.Drawing.Point(218, 132);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(42, 25);
            lbl.TabIndex = 3;
            lbl.Text = "000";
            // 
            // txtb1
            // 
            txtb1.Location = new System.Drawing.Point(164, 66);
            txtb1.Name = "txtb1";
            txtb1.Size = new System.Drawing.Size(82, 23);
            txtb1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(437, 450);
            Controls.Add(txtb1);
            Controls.Add(lbl);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtb1;
    }
}
