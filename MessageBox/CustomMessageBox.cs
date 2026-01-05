using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
            this.Shown += CustomMessageBox_Shown;
        }

        public string ResultText = null;

        public static string Show(
            string message,
            string title,
            MessageBoxIcon icon,
            string[] buttons // 右→左の順で渡す
        )
        {
            CustomMessageBox f = new CustomMessageBox();

            // タイトル
            f.Text = title;

            // メッセージ
            f.label.Text = message;

            // アイコン
            if (icon == MessageBoxIcon.Information)
                f.errorBox.Image = SystemIcons.Information.ToBitmap();
            else if (icon == MessageBoxIcon.Warning)
                f.errorBox.Image = SystemIcons.Warning.ToBitmap();
            else if (icon == MessageBoxIcon.Error)
                f.errorBox.Image = SystemIcons.Error.ToBitmap();
            else if (icon == MessageBoxIcon.Question)
                f.errorBox.Image = SystemIcons.Question.ToBitmap();
            else if (icon == MessageBoxIcon.None)
                f.errorBox.Image = null;

            // ボタン生成
            f.CreateButtons(buttons);

            // サイズ自動調整
            //f.AdjustSize();

            f.ShowDialog();
            return f.ResultText;
        }

        private void CreateButtons(string[] buttons)
        {
            int margin = 10;
            int btnHeight = button.Height;
            int spacing = 6;

            // テンプレ非表示
            button.Visible = false;

            List<Button> btnList = new List<Button>();
            int totalButtonWidth = 0;

            // フォント基準で文字幅計算
            using (Graphics g = this.CreateGraphics())
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    Size textSize = TextRenderer.MeasureText(
                        g,
                        buttons[i],
                        button.Font
                    );

                    int btnWidth = textSize.Width + 20; // 左右余白

                    Button b = new Button();
                    b.Text = buttons[i];
                    b.Width = btnWidth;
                    b.Height = btnHeight;
                    b.UseVisualStyleBackColor = true;
                    b.Click += new EventHandler(Button_Click);
                    b.MinimumSize = new Size(75, 23);

                    btnList.Add(b);
                    totalButtonWidth += btnWidth;

                    if (i > 0)
                        totalButtonWidth += spacing;
                }
            }

            // フォーム幅を確保（内容＋ボタン）
            int contentWidth = errorBox.Right + label.Width + margin * 2;
            int buttonAreaWidth = totalButtonWidth + margin * 2;

            int newWidth = Math.Max(contentWidth, buttonAreaWidth);
            this.ClientSize = new Size(newWidth, this.ClientSize.Height);

            // 右揃え配置
            int x = this.ClientSize.Width - margin;

            foreach (Button b in btnList)
            {
                x -= b.Width;
                b.Left = x;
                b.Top = button.Top;
                this.Controls.Add(b);
                x -= spacing;
            }

            panel1.SendToBack();
            button.BringToFront();
            panel1.Width = this.Width;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            ResultText = b.Text;
            this.Close();
        }

        private void AdjustSize()
        {
            /*label.MaximumSize = new Size(400, 0);
            label.AutoSize = true;*/

            int bottom = Math.Max(
                label.Bottom,
                errorBox.Bottom
            ) + 50;

            if (this.ClientSize.Height < bottom)
                this.ClientSize = new Size(this.ClientSize.Width, bottom);
        }

        void CustomMessageBox_Shown(object sender, EventArgs e)
        {
            AdjustSize();
        }
    }
}
