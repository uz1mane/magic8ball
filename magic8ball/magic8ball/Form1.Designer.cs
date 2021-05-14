namespace magic8ball
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
            this.btDecide = new System.Windows.Forms.Button();
            this.btAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ah, homework, here we go again... But what to start with?";
            // 
            // btDecide
            // 
            this.btDecide.BackColor = System.Drawing.Color.SaddleBrown;
            this.btDecide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDecide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDecide.Location = new System.Drawing.Point(329, 111);
            this.btDecide.Name = "btDecide";
            this.btDecide.Size = new System.Drawing.Size(135, 42);
            this.btDecide.TabIndex = 1;
            this.btDecide.Text = "decide";
            this.btDecide.UseVisualStyleBackColor = false;
            this.btDecide.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAnswer
            // 
            this.btAnswer.BackColor = System.Drawing.Color.SeaGreen;
            this.btAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAnswer.Location = new System.Drawing.Point(282, 216);
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Size = new System.Drawing.Size(228, 69);
            this.btAnswer.TabIndex = 2;
            this.btAnswer.Text = "...";
            this.btAnswer.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.btAnswer);
            this.Controls.Add(this.btDecide);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDecide;
        private System.Windows.Forms.Button btAnswer;
    }
}

