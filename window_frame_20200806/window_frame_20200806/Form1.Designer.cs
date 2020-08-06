namespace window_frame_20200806
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
            this.btn_test = new System.Windows.Forms.Button();
            this.btnClickthis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(704, 76);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(516, 307);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "click me";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClickthis
            // 
            this.btnClickthis.BackColor = System.Drawing.Color.GreenYellow;
            this.btnClickthis.Location = new System.Drawing.Point(303, 377);
            this.btnClickthis.Name = "btnClickthis";
            this.btnClickthis.Size = new System.Drawing.Size(484, 104);
            this.btnClickthis.TabIndex = 1;
            this.btnClickthis.Text = "button2";
            this.btnClickthis.UseVisualStyleBackColor = false;
            this.btnClickthis.Click += new System.EventHandler(this.btnClickthis_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(529, 60);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(38, 12);
            this.lblHelloWorld.TabIndex = 3;
            this.lblHelloWorld.Text = "label2";
            this.lblHelloWorld.Click += new System.EventHandler(this.lblHelloWorld_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 552);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickthis);
            this.Controls.Add(this.btn_test);
            this.Name = "Form1";
            this.Text = "기모띠";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btnClickthis;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

