namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.scena = new System.Windows.Forms.PictureBox();
            this.T = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Ldelta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scena)).BeginInit();
            this.SuspendLayout();
            // 
            // scena
            // 
            this.scena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scena.Location = new System.Drawing.Point(25, 38);
            this.scena.Name = "scena";
            this.scena.Size = new System.Drawing.Size(980, 507);
            this.scena.TabIndex = 0;
            this.scena.TabStop = false;
            this.scena.Paint += new System.Windows.Forms.PaintEventHandler(this.scena_Paint);
            this.scena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scena_MouseDown);
            // 
            // T
            // 
            this.T.Enabled = true;
            this.T.Tick += new System.EventHandler(this.T_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ldelta
            // 
            this.Ldelta.AutoSize = true;
            this.Ldelta.Location = new System.Drawing.Point(128, 550);
            this.Ldelta.Name = "Ldelta";
            this.Ldelta.Size = new System.Drawing.Size(35, 13);
            this.Ldelta.TabIndex = 2;
            this.Ldelta.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 575);
            this.Controls.Add(this.Ldelta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox scena;
        private System.Windows.Forms.Timer T;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Ldelta;
    }
}

