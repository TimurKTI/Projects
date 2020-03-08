namespace PasswordGenerator
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
            this.chbnumb = new System.Windows.Forms.CheckBox();
            this.chbsymb = new System.Windows.Forms.CheckBox();
            this.chblatzagl = new System.Windows.Forms.CheckBox();
            this.chblatprop = new System.Windows.Forms.CheckBox();
            this.chbruszagl = new System.Windows.Forms.CheckBox();
            this.chbrusprop = new System.Windows.Forms.CheckBox();
            this.lbnumb = new System.Windows.Forms.Label();
            this.lbsymb = new System.Windows.Forms.Label();
            this.lblatzagl = new System.Windows.Forms.Label();
            this.lblatprop = new System.Windows.Forms.Label();
            this.lbruszagl = new System.Windows.Forms.Label();
            this.lbrusprop = new System.Windows.Forms.Label();
            this.lbsymbnumb = new System.Windows.Forms.Label();
            this.lbpassnumb = new System.Windows.Forms.Label();
            this.btngenerate = new System.Windows.Forms.Button();
            this.tbsymb = new System.Windows.Forms.RichTextBox();
            this.dUDsymbnumb = new System.Windows.Forms.NumericUpDown();
            this.dUDpassnumb = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.btnopenfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dUDsymbnumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUDpassnumb)).BeginInit();
            this.SuspendLayout();
            // 
            // chbnumb
            // 
            this.chbnumb.AutoSize = true;
            this.chbnumb.Checked = true;
            this.chbnumb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbnumb.Location = new System.Drawing.Point(634, 42);
            this.chbnumb.Name = "chbnumb";
            this.chbnumb.Size = new System.Drawing.Size(18, 17);
            this.chbnumb.TabIndex = 0;
            this.chbnumb.UseVisualStyleBackColor = true;
            // 
            // chbsymb
            // 
            this.chbsymb.AutoSize = true;
            this.chbsymb.Checked = true;
            this.chbsymb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbsymb.Location = new System.Drawing.Point(634, 90);
            this.chbsymb.Name = "chbsymb";
            this.chbsymb.Size = new System.Drawing.Size(18, 17);
            this.chbsymb.TabIndex = 1;
            this.chbsymb.UseVisualStyleBackColor = true;
            // 
            // chblatzagl
            // 
            this.chblatzagl.AutoSize = true;
            this.chblatzagl.Checked = true;
            this.chblatzagl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chblatzagl.Location = new System.Drawing.Point(634, 141);
            this.chblatzagl.Name = "chblatzagl";
            this.chblatzagl.Size = new System.Drawing.Size(18, 17);
            this.chblatzagl.TabIndex = 2;
            this.chblatzagl.UseVisualStyleBackColor = true;
            // 
            // chblatprop
            // 
            this.chblatprop.AutoSize = true;
            this.chblatprop.Checked = true;
            this.chblatprop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chblatprop.Location = new System.Drawing.Point(634, 192);
            this.chblatprop.Name = "chblatprop";
            this.chblatprop.Size = new System.Drawing.Size(18, 17);
            this.chblatprop.TabIndex = 3;
            this.chblatprop.UseVisualStyleBackColor = true;
            // 
            // chbruszagl
            // 
            this.chbruszagl.AutoSize = true;
            this.chbruszagl.Checked = true;
            this.chbruszagl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbruszagl.Location = new System.Drawing.Point(634, 247);
            this.chbruszagl.Name = "chbruszagl";
            this.chbruszagl.Size = new System.Drawing.Size(18, 17);
            this.chbruszagl.TabIndex = 4;
            this.chbruszagl.UseVisualStyleBackColor = true;
            // 
            // chbrusprop
            // 
            this.chbrusprop.AutoSize = true;
            this.chbrusprop.Checked = true;
            this.chbrusprop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbrusprop.Location = new System.Drawing.Point(634, 299);
            this.chbrusprop.Name = "chbrusprop";
            this.chbrusprop.Size = new System.Drawing.Size(18, 17);
            this.chbrusprop.TabIndex = 5;
            this.chbrusprop.UseVisualStyleBackColor = true;
            // 
            // lbnumb
            // 
            this.lbnumb.AutoSize = true;
            this.lbnumb.Location = new System.Drawing.Point(397, 42);
            this.lbnumb.Name = "lbnumb";
            this.lbnumb.Size = new System.Drawing.Size(91, 17);
            this.lbnumb.TabIndex = 6;
            this.lbnumb.Text = "Цифры (0-9)";
            // 
            // lbsymb
            // 
            this.lbsymb.AutoSize = true;
            this.lbsymb.Location = new System.Drawing.Point(397, 90);
            this.lbsymb.Name = "lbsymb";
            this.lbsymb.Size = new System.Drawing.Size(67, 17);
            this.lbsymb.TabIndex = 7;
            this.lbsymb.Text = "Символы";
            // 
            // lblatzagl
            // 
            this.lblatzagl.AutoSize = true;
            this.lblatzagl.Location = new System.Drawing.Point(397, 141);
            this.lblatzagl.Name = "lblatzagl";
            this.lblatzagl.Size = new System.Drawing.Size(153, 17);
            this.lblatzagl.TabIndex = 8;
            this.lblatzagl.Text = "Лат. загл. буквы (A-Z)";
            // 
            // lblatprop
            // 
            this.lblatprop.AutoSize = true;
            this.lblatprop.Location = new System.Drawing.Point(397, 192);
            this.lblatprop.Name = "lblatprop";
            this.lblatprop.Size = new System.Drawing.Size(154, 17);
            this.lblatprop.TabIndex = 9;
            this.lblatprop.Text = "Лат. проп. буквы (a-z)";
            // 
            // lbruszagl
            // 
            this.lbruszagl.AutoSize = true;
            this.lbruszagl.Location = new System.Drawing.Point(397, 247);
            this.lbruszagl.Name = "lbruszagl";
            this.lbruszagl.Size = new System.Drawing.Size(152, 17);
            this.lbruszagl.TabIndex = 10;
            this.lbruszagl.Text = "Рус. загл. буквы (А-Я)";
            // 
            // lbrusprop
            // 
            this.lbrusprop.AutoSize = true;
            this.lbrusprop.Location = new System.Drawing.Point(397, 299);
            this.lbrusprop.Name = "lbrusprop";
            this.lbrusprop.Size = new System.Drawing.Size(153, 17);
            this.lbrusprop.TabIndex = 11;
            this.lbrusprop.Text = "Рус. проп. буквы (а-я)";
            // 
            // lbsymbnumb
            // 
            this.lbsymbnumb.AutoSize = true;
            this.lbsymbnumb.Location = new System.Drawing.Point(397, 344);
            this.lbsymbnumb.Name = "lbsymbnumb";
            this.lbsymbnumb.Size = new System.Drawing.Size(112, 17);
            this.lbsymbnumb.TabIndex = 14;
            this.lbsymbnumb.Text = "Кол-во симолов";
            // 
            // lbpassnumb
            // 
            this.lbpassnumb.AutoSize = true;
            this.lbpassnumb.Location = new System.Drawing.Point(397, 399);
            this.lbpassnumb.Name = "lbpassnumb";
            this.lbpassnumb.Size = new System.Drawing.Size(113, 17);
            this.lbpassnumb.TabIndex = 15;
            this.lbpassnumb.Text = "Кол-во паролей";
            // 
            // btngenerate
            // 
            this.btngenerate.Location = new System.Drawing.Point(13, 192);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(344, 43);
            this.btngenerate.TabIndex = 17;
            this.btngenerate.Text = "Сгенерировать";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            this.btngenerate.MouseEnter += new System.EventHandler(this.BtnGenerate_MouseEnter);
            // 
            // tbsymb
            // 
            this.tbsymb.Location = new System.Drawing.Point(470, 90);
            this.tbsymb.Name = "tbsymb";
            this.tbsymb.Size = new System.Drawing.Size(141, 27);
            this.tbsymb.TabIndex = 18;
            this.tbsymb.Text = "~!@#$%^&*()+`\'\";:<>/\\|";
            // 
            // dUDsymbnumb
            // 
            this.dUDsymbnumb.Location = new System.Drawing.Point(634, 344);
            this.dUDsymbnumb.Name = "dUDsymbnumb";
            this.dUDsymbnumb.Size = new System.Drawing.Size(120, 22);
            this.dUDsymbnumb.TabIndex = 20;
            this.dUDsymbnumb.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // dUDpassnumb
            // 
            this.dUDpassnumb.Location = new System.Drawing.Point(634, 399);
            this.dUDpassnumb.Maximum = new decimal(new int[] {
            150000000,
            0,
            0,
            0});
            this.dUDpassnumb.Name = "dUDpassnumb";
            this.dUDpassnumb.Size = new System.Drawing.Size(120, 22);
            this.dUDpassnumb.TabIndex = 21;
            this.dUDpassnumb.Value = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(344, 158);
            this.richTextBox1.TabIndex = 22;
            // 
            // btnopenfile
            // 
            this.btnopenfile.Location = new System.Drawing.Point(13, 247);
            this.btnopenfile.Name = "btnopenfile";
            this.btnopenfile.Size = new System.Drawing.Size(344, 45);
            this.btnopenfile.TabIndex = 23;
            this.btnopenfile.Text = "Открыть файл";
            this.btnopenfile.UseVisualStyleBackColor = true;
            this.btnopenfile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnopenfile);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dUDpassnumb);
            this.Controls.Add(this.dUDsymbnumb);
            this.Controls.Add(this.tbsymb);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.lbpassnumb);
            this.Controls.Add(this.lbsymbnumb);
            this.Controls.Add(this.lbrusprop);
            this.Controls.Add(this.lbruszagl);
            this.Controls.Add(this.lblatprop);
            this.Controls.Add(this.lblatzagl);
            this.Controls.Add(this.lbsymb);
            this.Controls.Add(this.lbnumb);
            this.Controls.Add(this.chbrusprop);
            this.Controls.Add(this.chbruszagl);
            this.Controls.Add(this.chblatprop);
            this.Controls.Add(this.chblatzagl);
            this.Controls.Add(this.chbsymb);
            this.Controls.Add(this.chbnumb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dUDsymbnumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUDpassnumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbnumb;
        private System.Windows.Forms.CheckBox chbsymb;
        private System.Windows.Forms.CheckBox chblatzagl;
        private System.Windows.Forms.CheckBox chblatprop;
        private System.Windows.Forms.CheckBox chbruszagl;
        private System.Windows.Forms.CheckBox chbrusprop;
        private System.Windows.Forms.Label lbnumb;
        private System.Windows.Forms.Label lbsymb;
        private System.Windows.Forms.Label lblatzagl;
        private System.Windows.Forms.Label lblatprop;
        private System.Windows.Forms.Label lbruszagl;
        private System.Windows.Forms.Label lbrusprop;
        private System.Windows.Forms.Label lbsymbnumb;
        private System.Windows.Forms.Label lbpassnumb;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.RichTextBox tbsymb;
        private System.Windows.Forms.NumericUpDown dUDsymbnumb;
        private System.Windows.Forms.NumericUpDown dUDpassnumb;
        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.Button btnopenfile;
    }
}

