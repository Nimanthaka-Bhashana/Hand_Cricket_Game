namespace Project1_Game
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.player_text = new System.Windows.Forms.TextBox();
            this.cpu_text = new System.Windows.Forms.TextBox();
            this.play_button = new System.Windows.Forms.Button();
            this.result_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cpu_score_txt = new System.Windows.Forms.TextBox();
            this.player_score_txt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Our Choose";
            // 
            // player_text
            // 
            this.player_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_text.Location = new System.Drawing.Point(329, 61);
            this.player_text.Name = "player_text";
            this.player_text.Size = new System.Drawing.Size(239, 35);
            this.player_text.TabIndex = 2;
            this.player_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cpu_text
            // 
            this.cpu_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_text.Location = new System.Drawing.Point(329, 111);
            this.cpu_text.Name = "cpu_text";
            this.cpu_text.Size = new System.Drawing.Size(239, 35);
            this.cpu_text.TabIndex = 3;
            this.cpu_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.Blue;
            this.play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.play_button.Location = new System.Drawing.Point(477, 174);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(120, 42);
            this.play_button.TabIndex = 4;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // result_text
            // 
            this.result_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_text.Location = new System.Drawing.Point(60, 192);
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(336, 35);
            this.result_text.TabIndex = 5;
            this.result_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Opposite Team Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Opposite Team Choose";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Our Team Score";
            // 
            // cpu_score_txt
            // 
            this.cpu_score_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_score_txt.Location = new System.Drawing.Point(98, 320);
            this.cpu_score_txt.Name = "cpu_score_txt";
            this.cpu_score_txt.Size = new System.Drawing.Size(161, 35);
            this.cpu_score_txt.TabIndex = 3;
            this.cpu_score_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player_score_txt
            // 
            this.player_score_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_score_txt.Location = new System.Drawing.Point(338, 320);
            this.player_score_txt.Name = "player_score_txt";
            this.player_score_txt.Size = new System.Drawing.Size(180, 35);
            this.player_score_txt.TabIndex = 3;
            this.player_score_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(129, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(439, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cricket Hand  Toss Game";
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.Red;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(477, 233);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(120, 45);
            this.clear_btn.TabIndex = 7;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(627, 367);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.cpu_score_txt);
            this.Controls.Add(this.player_score_txt);
            this.Controls.Add(this.cpu_text);
            this.Controls.Add(this.player_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Mainform";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox player_text;
        private System.Windows.Forms.TextBox cpu_text;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.TextBox result_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cpu_score_txt;
        private System.Windows.Forms.TextBox player_score_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clear_btn;
    }
}

