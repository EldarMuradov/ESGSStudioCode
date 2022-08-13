
namespace ESGSStudioCode
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTaxtbox = new System.Windows.Forms.TextBox();
            this.frameworkTextbox = new System.Windows.Forms.TextBox();
            this.codeBox = new System.Windows.Forms.RichTextBox();
            this.statusCode = new System.Windows.Forms.RichTextBox();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(549, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = ".NET Framework:";
            // 
            // nameTaxtbox
            // 
            this.nameTaxtbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameTaxtbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nameTaxtbox.Location = new System.Drawing.Point(105, 40);
            this.nameTaxtbox.Name = "nameTaxtbox";
            this.nameTaxtbox.Size = new System.Drawing.Size(257, 22);
            this.nameTaxtbox.TabIndex = 2;
            this.nameTaxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frameworkTextbox
            // 
            this.frameworkTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.frameworkTextbox.Location = new System.Drawing.Point(668, 37);
            this.frameworkTextbox.Name = "frameworkTextbox";
            this.frameworkTextbox.Size = new System.Drawing.Size(100, 22);
            this.frameworkTextbox.TabIndex = 3;
            this.frameworkTextbox.Text = "v4.0";
            this.frameworkTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // codeBox
            // 
            this.codeBox.AcceptsTab = true;
            this.codeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.codeBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.codeBox.Location = new System.Drawing.Point(24, 97);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(959, 439);
            this.codeBox.TabIndex = 4;
            this.codeBox.Text = "using System; ";
            this.codeBox.TextChanged += new System.EventHandler(this.codeBox_TextChanged);
            // 
            // statusCode
            // 
            this.statusCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusCode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.statusCode.Enabled = false;
            this.statusCode.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusCode.ForeColor = System.Drawing.Color.Crimson;
            this.statusCode.Location = new System.Drawing.Point(24, 591);
            this.statusCode.Name = "statusCode";
            this.statusCode.Size = new System.Drawing.Size(959, 93);
            this.statusCode.TabIndex = 5;
            this.statusCode.Text = "Debug";
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Start.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.Color.Navy;
            this.Start.Location = new System.Drawing.Point(897, 542);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(86, 37);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1015, 705);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.statusCode);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.frameworkTextbox);
            this.Controls.Add(this.nameTaxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ESGSStudioCode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTaxtbox;
        private System.Windows.Forms.TextBox frameworkTextbox;
        private System.Windows.Forms.RichTextBox codeBox;
        private System.Windows.Forms.RichTextBox statusCode;
        private System.Windows.Forms.Button Start;
    }
}

