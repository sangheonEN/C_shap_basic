namespace encapsluration
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
            this.lboxitem = new System.Windows.Forms.ListBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_result_error = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.cboxitem = new System.Windows.Forms.ComboBox();
            this.cboxrate = new System.Windows.Forms.ComboBox();
            this.numCout = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCout)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxitem
            // 
            this.lboxitem.FormattingEnabled = true;
            this.lboxitem.ItemHeight = 12;
            this.lboxitem.Location = new System.Drawing.Point(41, 12);
            this.lboxitem.Name = "lboxitem";
            this.lboxitem.Size = new System.Drawing.Size(311, 244);
            this.lboxitem.TabIndex = 0;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(102, 292);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(250, 21);
            this.textBox_price.TabIndex = 1;
            // 
            // textBox_result_error
            // 
            this.textBox_result_error.ForeColor = System.Drawing.Color.Red;
            this.textBox_result_error.Location = new System.Drawing.Point(102, 331);
            this.textBox_result_error.Name = "textBox_result_error";
            this.textBox_result_error.Size = new System.Drawing.Size(250, 21);
            this.textBox_result_error.TabIndex = 2;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(390, 208);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(199, 29);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "담기";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // cboxitem
            // 
            this.cboxitem.FormattingEnabled = true;
            this.cboxitem.Location = new System.Drawing.Point(468, 34);
            this.cboxitem.Name = "cboxitem";
            this.cboxitem.Size = new System.Drawing.Size(121, 20);
            this.cboxitem.TabIndex = 7;
            // 
            // cboxrate
            // 
            this.cboxrate.FormattingEnabled = true;
            this.cboxrate.Location = new System.Drawing.Point(468, 79);
            this.cboxrate.Name = "cboxrate";
            this.cboxrate.Size = new System.Drawing.Size(121, 20);
            this.cboxrate.TabIndex = 8;
            // 
            // numCout
            // 
            this.numCout.Location = new System.Drawing.Point(468, 124);
            this.numCout.Name = "numCout";
            this.numCout.Size = new System.Drawing.Size(121, 21);
            this.numCout.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "물건명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "할인율(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "갯수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "결제 금액";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "결제 내역";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCout);
            this.Controls.Add(this.cboxrate);
            this.Controls.Add(this.cboxitem);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_result_error);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.lboxitem);
            this.Name = "Form1";
            this.Text = "결제 시스템";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxitem;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_result_error;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox cboxitem;
        private System.Windows.Forms.ComboBox cboxrate;
        private System.Windows.Forms.NumericUpDown numCout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

