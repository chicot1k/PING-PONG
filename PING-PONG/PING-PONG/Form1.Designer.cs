namespace PING_PONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PLAYER2 = new System.Windows.Forms.Label();
            this.PLAYER1 = new System.Windows.Forms.Label();
            this.box = new System.Windows.Forms.PictureBox();
            this.rule = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PL1W = new System.Windows.Forms.Label();
            this.PL2W = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCORE\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 68);
            this.label2.TabIndex = 2;
            this.label2.Text = "PLAYER1 \r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "PLAYER2";
            // 
            // PLAYER2
            // 
            this.PLAYER2.AutoSize = true;
            this.PLAYER2.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAYER2.Location = new System.Drawing.Point(462, 9);
            this.PLAYER2.Name = "PLAYER2";
            this.PLAYER2.Size = new System.Drawing.Size(26, 34);
            this.PLAYER2.TabIndex = 4;
            this.PLAYER2.Text = "0";
            // 
            // PLAYER1
            // 
            this.PLAYER1.AutoSize = true;
            this.PLAYER1.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAYER1.Location = new System.Drawing.Point(250, 9);
            this.PLAYER1.Name = "PLAYER1";
            this.PLAYER1.Size = new System.Drawing.Size(26, 34);
            this.PLAYER1.TabIndex = 5;
            this.PLAYER1.Text = "0";
            // 
            // box
            // 
            this.box.Location = new System.Drawing.Point(-2, 57);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(800, 400);
            this.box.TabIndex = 6;
            this.box.TabStop = false;
            // 
            // rule
            // 
            this.rule.AutoSize = true;
            this.rule.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rule.Location = new System.Drawing.Point(-2, 110);
            this.rule.Name = "rule";
            this.rule.Size = new System.Drawing.Size(806, 200);
            this.rule.TabIndex = 7;
            this.rule.Text = resources.GetString("rule.Text");
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // PL1W
            // 
            this.PL1W.AutoSize = true;
            this.PL1W.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PL1W.Location = new System.Drawing.Point(278, 57);
            this.PL1W.Name = "PL1W";
            this.PL1W.Size = new System.Drawing.Size(210, 58);
            this.PL1W.TabIndex = 8;
            this.PL1W.Text = "PLAYER1 WIN!";
            this.PL1W.Visible = false;
            // 
            // PL2W
            // 
            this.PL2W.AutoSize = true;
            this.PL2W.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PL2W.Location = new System.Drawing.Point(278, 57);
            this.PL2W.Name = "PL2W";
            this.PL2W.Size = new System.Drawing.Size(221, 58);
            this.PL2W.TabIndex = 9;
            this.PL2W.Text = "PLAYER2 WIN!";
            this.PL2W.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.PL2W);
            this.Controls.Add(this.PL1W);
            this.Controls.Add(this.rule);
            this.Controls.Add(this.box);
            this.Controls.Add(this.PLAYER1);
            this.Controls.Add(this.PLAYER2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PING-PONG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PLAYER2;
        private System.Windows.Forms.Label PLAYER1;
        private System.Windows.Forms.Label rule;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label PL1W;
        private System.Windows.Forms.Label PL2W;
    }
}

