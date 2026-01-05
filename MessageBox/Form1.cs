using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            errorMode.SelectedIndex = 0;
            buttonMode.SelectedIndex = 0;
            comboButton1.SelectedIndex = 1;
            comboButton2.SelectedIndex = 1;
            comboButton3.SelectedIndex = 1;
            comboButton4.SelectedIndex = 1;
        }

        private void buttonMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCustom =
                buttonMode.SelectedItem != null &&
                buttonMode.SelectedItem.ToString() == "カスタム";

            comboButton1.Enabled = isCustom;
            textButton1.Enabled = isCustom;
            comboButton2.Enabled = isCustom;
            textButton2.Enabled = isCustom;
            comboButton3.Enabled = isCustom;
            textButton3.Enabled = isCustom;
            comboButton4.Enabled = isCustom;
            textButton4.Enabled = isCustom;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string msgeBox = msgBox.Text;
            string msgeTitle = messageTitle.Text;
            string errIco = errorMode.SelectedItem.ToString();
            string errBtn = buttonMode.SelectedItem.ToString();

            MessageBoxIcon icon;
            if (errIco == "情報")
                icon = MessageBoxIcon.Information;
            else if (errIco == "注意")
                icon = MessageBoxIcon.Warning;
            else if (errIco == "エラー")
                icon = MessageBoxIcon.Error;
            else if (errIco == "質問")
                icon = MessageBoxIcon.Question;
            else if (errIco == "なし")
                icon = MessageBoxIcon.None;
            else
                throw new NotImplementedException("選択してください");

            MessageBoxButtons btn;
            if (errBtn == "OK")
                btn = MessageBoxButtons.OK;
            else if (errBtn == "OK / キャンセル")
                btn = MessageBoxButtons.OKCancel;
            else if (errBtn == "はい / いいえ")
                btn = MessageBoxButtons.YesNo;
            else if (errBtn == "はい / いいえ / キャンセル")
                btn = MessageBoxButtons.YesNoCancel;
            else if (errBtn == "再試行 / キャンセル")
                btn = MessageBoxButtons.RetryCancel;
            else if (errBtn == "中止 / 再試行 / 無視")
                btn = MessageBoxButtons.AbortRetryIgnore;
            else if (errBtn == "カスタム")
            {
                if (errIco == "情報")
                    System.Media.SystemSounds.Asterisk.Play();
                else if (errIco == "注意")
                    System.Media.SystemSounds.Exclamation.Play();
                else if (errIco == "エラー")
                    System.Media.SystemSounds.Hand.Play();
                else if (errIco == "質問")
                    System.Media.SystemSounds.Question.Play();

                List<string> buttons = new List<string>();

                if (comboButton1.SelectedIndex == 0) // 表示する
                    buttons.Add(textButton1.Text);

                if (comboButton2.SelectedIndex == 0)
                    buttons.Add(textButton2.Text);

                if (comboButton3.SelectedIndex == 0)
                    buttons.Add(textButton3.Text);

                if (comboButton4.SelectedIndex == 0)
                    buttons.Add(textButton4.Text);

                // 右→左なのでそのまま渡す
                string result = CustomMessageBox.Show(
                    msgeBox,
                    msgeTitle,
                    icon,
                    buttons.ToArray()
                );

                return;
            }  
            else
                throw new NotImplementedException("選択してください");

            System.Windows.Forms.MessageBox.Show(msgeBox, msgeTitle, btn, icon);
        }
    }
}
