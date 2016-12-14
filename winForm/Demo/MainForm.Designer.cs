namespace Multithreading
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxA = new System.Windows.Forms.ListBox();
            this.listBoxB = new System.Windows.Forms.ListBox();
            this.btnStartA = new System.Windows.Forms.Button();
            this.btnStopA = new System.Windows.Forms.Button();
            this.UserNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStartB = new System.Windows.Forms.Button();
            this.btnStopB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxA
            // 
            this.listBoxA.FormattingEnabled = true;
            this.listBoxA.ItemHeight = 15;
            this.listBoxA.Location = new System.Drawing.Point(40, 30);
            this.listBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxA.Name = "listBoxA";
            this.listBoxA.Size = new System.Drawing.Size(208, 499);
            this.listBoxA.TabIndex = 0;
            this.listBoxA.SelectedIndexChanged += new System.EventHandler(this.listBoxA_SelectedIndexChanged);
            // 
            // listBoxB
            // 
            this.listBoxB.FormattingEnabled = true;
            this.listBoxB.ItemHeight = 15;
            this.listBoxB.Location = new System.Drawing.Point(270, 30);
            this.listBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxB.Name = "listBoxB";
            this.listBoxB.Size = new System.Drawing.Size(215, 499);
            this.listBoxB.TabIndex = 1;
            // 
            // btnStartA
            // 
            this.btnStartA.Location = new System.Drawing.Point(40, 538);
            this.btnStartA.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartA.Name = "btnStartA";
            this.btnStartA.Size = new System.Drawing.Size(127, 29);
            this.btnStartA.TabIndex = 2;
            this.btnStartA.Text = "開始Thread1";
            this.btnStartA.UseVisualStyleBackColor = true;
            this.btnStartA.Click += new System.EventHandler(this.btnStartA_Click);
            // 
            // btnStopA
            // 
            this.btnStopA.Location = new System.Drawing.Point(40, 574);
            this.btnStopA.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopA.Name = "btnStopA";
            this.btnStopA.Size = new System.Drawing.Size(127, 29);
            this.btnStopA.TabIndex = 3;
            this.btnStopA.Text = "暫停Thread1";
            this.btnStopA.UseVisualStyleBackColor = true;
            this.btnStopA.Click += new System.EventHandler(this.btnStopA_Click);
            // 
            // UserNumber
            // 
            this.UserNumber.Location = new System.Drawing.Point(512, 30);
            this.UserNumber.Margin = new System.Windows.Forms.Padding(4);
            this.UserNumber.Name = "UserNumber";
            this.UserNumber.Size = new System.Drawing.Size(132, 25);
            this.UserNumber.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(652, 30);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "加入使用者自訂數字";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStartB
            // 
            this.btnStartB.Location = new System.Drawing.Point(175, 537);
            this.btnStartB.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartB.Name = "btnStartB";
            this.btnStartB.Size = new System.Drawing.Size(134, 29);
            this.btnStartB.TabIndex = 6;
            this.btnStartB.Text = "開始Thread2";
            this.btnStartB.UseVisualStyleBackColor = true;
            this.btnStartB.Click += new System.EventHandler(this.btnStartB_Click);
            // 
            // btnStopB
            // 
            this.btnStopB.Location = new System.Drawing.Point(175, 574);
            this.btnStopB.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopB.Name = "btnStopB";
            this.btnStopB.Size = new System.Drawing.Size(134, 29);
            this.btnStopB.TabIndex = 7;
            this.btnStopB.Text = "暫停Thread2";
            this.btnStopB.UseVisualStyleBackColor = true;
            this.btnStopB.Click += new System.EventHandler(this.btnStopB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 636);
            this.Controls.Add(this.btnStopB);
            this.Controls.Add(this.btnStartB);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.UserNumber);
            this.Controls.Add(this.btnStopA);
            this.Controls.Add(this.btnStartA);
            this.Controls.Add(this.listBoxB);
            this.Controls.Add(this.listBoxA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxA;
        private System.Windows.Forms.ListBox listBoxB;
        private System.Windows.Forms.Button btnStartA;
        private System.Windows.Forms.Button btnStopA;
        private System.Windows.Forms.TextBox UserNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStartB;
        private System.Windows.Forms.Button btnStopB;
    }
}

