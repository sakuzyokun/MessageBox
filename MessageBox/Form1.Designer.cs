namespace MessageBox
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.messageTitle = new System.Windows.Forms.TextBox();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMode = new System.Windows.Forms.ComboBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textButton1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboButton1 = new System.Windows.Forms.ComboBox();
            this.comboButton2 = new System.Windows.Forms.ComboBox();
            this.textButton2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboButton3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textButton3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboButton4 = new System.Windows.Forms.ComboBox();
            this.textButton4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "メッセージタイトル";
            // 
            // messageTitle
            // 
            this.messageTitle.Location = new System.Drawing.Point(13, 24);
            this.messageTitle.Name = "messageTitle";
            this.messageTitle.Size = new System.Drawing.Size(625, 19);
            this.messageTitle.TabIndex = 1;
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(14, 61);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgBox.Size = new System.Drawing.Size(624, 192);
            this.msgBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "メッセージ内容";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "エラーアイコン";
            // 
            // errorMode
            // 
            this.errorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorMode.FormattingEnabled = true;
            this.errorMode.Items.AddRange(new object[] {
            "情報",
            "注意",
            "エラー",
            "質問",
            "なし"});
            this.errorMode.Location = new System.Drawing.Point(13, 271);
            this.errorMode.Name = "errorMode";
            this.errorMode.Size = new System.Drawing.Size(192, 20);
            this.errorMode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "ボタン";
            // 
            // buttonMode
            // 
            this.buttonMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buttonMode.FormattingEnabled = true;
            this.buttonMode.Items.AddRange(new object[] {
            "OK",
            "OK / キャンセル",
            "はい / いいえ",
            "はい / いいえ / キャンセル",
            "再試行 / キャンセル",
            "中止 / 再試行 / 無視",
            "カスタム"});
            this.buttonMode.Location = new System.Drawing.Point(13, 309);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(192, 20);
            this.buttonMode.TabIndex = 7;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCreate.Location = new System.Drawing.Point(510, 355);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(128, 64);
            this.buttonCreate.TabIndex = 8;
            this.buttonCreate.Text = "作成";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textButton1
            // 
            this.textButton1.Location = new System.Drawing.Point(211, 335);
            this.textButton1.Name = "textButton1";
            this.textButton1.Size = new System.Drawing.Size(121, 19);
            this.textButton1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "[ボタン]が[カスタム]の時の設定";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "ボタン1";
            // 
            // comboButton1
            // 
            this.comboButton1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboButton1.FormattingEnabled = true;
            this.comboButton1.Items.AddRange(new object[] {
            "表示する",
            "表示しない"});
            this.comboButton1.Location = new System.Drawing.Point(211, 309);
            this.comboButton1.Name = "comboButton1";
            this.comboButton1.Size = new System.Drawing.Size(121, 20);
            this.comboButton1.TabIndex = 12;
            // 
            // comboButton2
            // 
            this.comboButton2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboButton2.FormattingEnabled = true;
            this.comboButton2.Items.AddRange(new object[] {
            "表示する",
            "表示しない"});
            this.comboButton2.Location = new System.Drawing.Point(338, 309);
            this.comboButton2.Name = "comboButton2";
            this.comboButton2.Size = new System.Drawing.Size(121, 20);
            this.comboButton2.TabIndex = 13;
            // 
            // textButton2
            // 
            this.textButton2.Location = new System.Drawing.Point(338, 335);
            this.textButton2.Name = "textButton2";
            this.textButton2.Size = new System.Drawing.Size(121, 19);
            this.textButton2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "ボタン2";
            // 
            // comboButton3
            // 
            this.comboButton3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboButton3.FormattingEnabled = true;
            this.comboButton3.Items.AddRange(new object[] {
            "表示する",
            "表示しない"});
            this.comboButton3.Location = new System.Drawing.Point(211, 372);
            this.comboButton3.Name = "comboButton3";
            this.comboButton3.Size = new System.Drawing.Size(121, 20);
            this.comboButton3.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "ボタン3";
            // 
            // textButton3
            // 
            this.textButton3.Location = new System.Drawing.Point(211, 398);
            this.textButton3.Name = "textButton3";
            this.textButton3.Size = new System.Drawing.Size(121, 19);
            this.textButton3.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "ボタン4";
            // 
            // comboButton4
            // 
            this.comboButton4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboButton4.FormattingEnabled = true;
            this.comboButton4.Items.AddRange(new object[] {
            "表示する",
            "表示しない"});
            this.comboButton4.Location = new System.Drawing.Point(338, 372);
            this.comboButton4.Name = "comboButton4";
            this.comboButton4.Size = new System.Drawing.Size(121, 20);
            this.comboButton4.TabIndex = 20;
            // 
            // textButton4
            // 
            this.textButton4.Location = new System.Drawing.Point(338, 398);
            this.textButton4.Name = "textButton4";
            this.textButton4.Size = new System.Drawing.Size(121, 19);
            this.textButton4.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 431);
            this.Controls.Add(this.textButton4);
            this.Controls.Add(this.comboButton4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textButton3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboButton3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textButton2);
            this.Controls.Add(this.comboButton2);
            this.Controls.Add(this.comboButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textButton1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.messageTitle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox messageTitle;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox errorMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox buttonMode;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboButton1;
        private System.Windows.Forms.ComboBox comboButton2;
        private System.Windows.Forms.TextBox textButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboButton3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textButton3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboButton4;
        private System.Windows.Forms.TextBox textButton4;
    }
}

