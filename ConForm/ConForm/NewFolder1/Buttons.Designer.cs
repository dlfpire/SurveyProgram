namespace ConForm.NewFolder1
{
    partial class Buttons
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrevButton = new MetroFramework.Controls.MetroButton();
            this.HomeButton = new MetroFramework.Controls.MetroButton();
            this.NextButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(15, 24);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 0;
            this.PrevButton.Text = "PREV";
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(272, 24);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "HOME";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(534, 24);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "SAVE";
            this.NextButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Buttons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.PrevButton);
            this.Name = "Buttons";
            this.Size = new System.Drawing.Size(627, 68);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton PrevButton;
        private MetroFramework.Controls.MetroButton HomeButton;
        private MetroFramework.Controls.MetroButton NextButton;
    }
}
