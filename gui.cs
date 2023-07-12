using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Sussyraider_3._0_C_
{
    public partial class gui : Form
    {

        public gui()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            label2.Text = "Hardware ID: "+get_hwid();
        }
        public static string get_hwid()
        {
            string text = "SOFTWARE\\Microsoft\\Cryptography";
            string text2 = "MachineGuid";
            string result;
            using (RegistryKey registrykey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey registrykey2 = registrykey.OpenSubKey(text))
                {
                    bool flag = registrykey2 == null;
                    if (flag)
                    {
                        throw new KeyNotFoundException(string.Format("Key not found {0}", text));
                    }
                    object value = registrykey2.GetValue(text2);
                    bool flag2 = value == null;
                    if (flag2)
                    {
                        throw new IndexOutOfRangeException(string.Format("Index not found: {0}", text2));
                    }
                    result = value.ToString();
                    return result;
                }
            }
        }
        private void button_click(int click_button)
        {
            if (click_button == 1)
            {
                button_1.Image = Sussyraider_3._0_C_.Properties.Resources.sel_join_leave;
            }
            else button_1.Image = Sussyraider_3._0_C_.Properties.Resources.join_leave;
            if (click_button == 2)
            {
                button_2.Image = Sussyraider_3._0_C_.Properties.Resources.sel_nick_avator;
            }
            else button_2.Image = Sussyraider_3._0_C_.Properties.Resources.nick_avator;
            if (click_button == 3)
            {
                button_3.Image = Sussyraider_3._0_C_.Properties.Resources.sel_friend_dm;
            }
            else button_3.Image = Sussyraider_3._0_C_.Properties.Resources.friend_dm;
            if (click_button == 4)
            {
                button_4.Image = Sussyraider_3._0_C_.Properties.Resources.sel_spammer;
            }
            else button_4.Image = Sussyraider_3._0_C_.Properties.Resources.spammer;
            if (click_button == 5)
            {
                button_5.Image = Sussyraider_3._0_C_.Properties.Resources.sel_vcspammer;
            }
            else button_5.Image = Sussyraider_3._0_C_.Properties.Resources.vcspammer;
            if (click_button == 6)
            {
                button_6.Image = Sussyraider_3._0_C_.Properties.Resources.sel_reaction;
            }
            else button_6.Image = Sussyraider_3._0_C_.Properties.Resources.reaction;
            if (click_button == 7)
            {
                button_7.Image = Sussyraider_3._0_C_.Properties.Resources.sel_btnpusher;
            }
            else button_7.Image = Sussyraider_3._0_C_.Properties.Resources.btnpusher;
            if (click_button == 8)
            {
                button_8.Image = Sussyraider_3._0_C_.Properties.Resources.sel_report;
            }
            else button_8.Image = Sussyraider_3._0_C_.Properties.Resources.report;
        }
        private void defalut_image(object sender, EventArgs e)
        {
            button_1.Image = Sussyraider_3._0_C_.Properties.Resources.join_leave;
            button_2.Image = Sussyraider_3._0_C_.Properties.Resources.nick_avator;
            button_3.Image = Sussyraider_3._0_C_.Properties.Resources.friend_dm;
            button_4.Image = Sussyraider_3._0_C_.Properties.Resources.spammer;
            button_5.Image = Sussyraider_3._0_C_.Properties.Resources.vcspammer;
            button_6.Image = Sussyraider_3._0_C_.Properties.Resources.reaction;
            button_7.Image = Sussyraider_3._0_C_.Properties.Resources.btnpusher;
            button_8.Image = Sussyraider_3._0_C_.Properties.Resources.report;
        }
        private void next_frame(object sender, EventArgs e)
        {

            defalut_image(sender, e);

            button_1.Hide();
            button_2.Hide();
            button_3.Hide();
            button_4.Hide();
            button_5.Hide();
            button_6.Hide();
            button_7.Hide();
            button_8.Hide();

            back_button_1.Image = Sussyraider_3._0_C_.Properties.Resources.blue_left;
            next_button_1.Image = Sussyraider_3._0_C_.Properties.Resources.white_right;

            back_button_1.Enabled = true;
            back_button_1.Click += back_frame;
        }
        private void back_frame(object sender, EventArgs e)
        {

            defalut_image(sender, e);

            button_1.Show();
            button_2.Show();
            button_3.Show();
            button_4.Show();
            button_5.Show();
            button_6.Show();
            button_7.Show();
            button_8.Show();

            back_button_1.Image = Sussyraider_3._0_C_.Properties.Resources.white_left;
            next_button_1.Image = Sussyraider_3._0_C_.Properties.Resources.blue_right;

            back_button_1.Enabled = false;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            button_click(1);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            button_click(2);
        }

        private void button_3_click(object sender, EventArgs e)
        {
            button_click(3);
        }

        private void button_4_click(object sender, EventArgs e)
        {
            button_click(4);
        }

        private void button_5_click(object sender, EventArgs e)
        {
            button_click(5);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            button_click(6);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            button_click(7);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            button_click(8);
        }

        private void next_button_1_Click(object sender, EventArgs e)
        {
            next_frame(sender, e);
        }
    }
}
