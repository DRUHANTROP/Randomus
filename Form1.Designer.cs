namespace RandomicGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resultLB = new System.Windows.Forms.ListBox();
            this.genCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.generateB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countUD)).BeginInit();
            this.SuspendLayout();
            // 
            // resultLB
            // 
            this.resultLB.FormattingEnabled = true;
            this.resultLB.Location = new System.Drawing.Point(13, 13);
            this.resultLB.Name = "resultLB";
            this.resultLB.Size = new System.Drawing.Size(277, 420);
            this.resultLB.TabIndex = 0;
            // 
            // genCB
            // 
            this.genCB.FormattingEnabled = true;
            this.genCB.Location = new System.Drawing.Point(332, 81);
            this.genCB.Name = "genCB";
            this.genCB.Size = new System.Drawing.Size(121, 21);
            this.genCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "type";
            // 
            // countUD
            // 
            this.countUD.Location = new System.Drawing.Point(332, 157);
            this.countUD.Name = "countUD";
            this.countUD.Size = new System.Drawing.Size(120, 20);
            this.countUD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "count";
            // 
            // generateB
            // 
            this.generateB.Location = new System.Drawing.Point(332, 213);
            this.generateB.Name = "generateB";
            this.generateB.Size = new System.Drawing.Size(121, 23);
            this.generateB.TabIndex = 5;
            this.generateB.Text = "generate";
            this.generateB.UseVisualStyleBackColor = true;
            this.generateB.Click += new System.EventHandler(this.generateB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.generateB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genCB);
            this.Controls.Add(this.resultLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Randomus Degenerator";
            ((System.ComponentModel.ISupportInitialize)(this.countUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultLB;
        private System.Windows.Forms.ComboBox genCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown countUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateB;
    }
}

