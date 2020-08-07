namespace windows_form_example
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button1_random = new System.Windows.Forms.Button();
            this.label_random = new System.Windows.Forms.Label();
            this.textBox__rock_siser_paper = new System.Windows.Forms.TextBox();
            this.label_rock_siser_paper = new System.Windows.Forms.Label();
            this.button__rock_siser_paper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_output
            // 
            this.textBox_output.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_output.Location = new System.Drawing.Point(72, 52);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(100, 21);
            this.textBox_output.TabIndex = 0;
            // 
            // button1_random
            // 
            this.button1_random.Location = new System.Drawing.Point(72, 91);
            this.button1_random.Name = "button1_random";
            this.button1_random.Size = new System.Drawing.Size(75, 23);
            this.button1_random.TabIndex = 1;
            this.button1_random.Text = "button1";
            this.button1_random.UseVisualStyleBackColor = true;
            this.button1_random.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_random
            // 
            this.label_random.AutoSize = true;
            this.label_random.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_random.Location = new System.Drawing.Point(70, 19);
            this.label_random.Name = "label_random";
            this.label_random.Size = new System.Drawing.Size(38, 12);
            this.label_random.TabIndex = 2;
            this.label_random.Text = "label1";
            // 
            // textBox__rock_siser_paper
            // 
            this.textBox__rock_siser_paper.Location = new System.Drawing.Point(72, 206);
            this.textBox__rock_siser_paper.Name = "textBox__rock_siser_paper";
            this.textBox__rock_siser_paper.Size = new System.Drawing.Size(100, 21);
            this.textBox__rock_siser_paper.TabIndex = 3;
            // 
            // label_rock_siser_paper
            // 
            this.label_rock_siser_paper.AutoSize = true;
            this.label_rock_siser_paper.Location = new System.Drawing.Point(70, 171);
            this.label_rock_siser_paper.Name = "label_rock_siser_paper";
            this.label_rock_siser_paper.Size = new System.Drawing.Size(38, 12);
            this.label_rock_siser_paper.TabIndex = 4;
            this.label_rock_siser_paper.Text = "label1";
            // 
            // button__rock_siser_paper
            // 
            this.button__rock_siser_paper.Location = new System.Drawing.Point(72, 252);
            this.button__rock_siser_paper.Name = "button__rock_siser_paper";
            this.button__rock_siser_paper.Size = new System.Drawing.Size(75, 23);
            this.button__rock_siser_paper.TabIndex = 5;
            this.button__rock_siser_paper.Text = "button2";
            this.button__rock_siser_paper.UseVisualStyleBackColor = true;
            this.button__rock_siser_paper.Click += new System.EventHandler(this.button__rock_siser_paper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button__rock_siser_paper);
            this.Controls.Add(this.label_rock_siser_paper);
            this.Controls.Add(this.textBox__rock_siser_paper);
            this.Controls.Add(this.label_random);
            this.Controls.Add(this.button1_random);
            this.Controls.Add(this.textBox_output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button1_random;
        private System.Windows.Forms.Label label_random;
        private System.Windows.Forms.TextBox textBox__rock_siser_paper;
        private System.Windows.Forms.Label label_rock_siser_paper;
        private System.Windows.Forms.Button button__rock_siser_paper;
    }
}

