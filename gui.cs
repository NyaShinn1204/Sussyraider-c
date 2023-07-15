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
            module_setting(1);
            textBox1.BringToFront();
            textBox2.BringToFront();
        }
        public static string get_hwid()
        {
            string text = "SOFTWARE\\Microsoft\\Cryptography";
            string text2 = "MachineGuid";
            string result;
            using (RegistryKey registrykey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey registrykey2 = registrykey1.OpenSubKey(text))
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
        private void defalut_image()
        {
            button_1.Image = Sussyraider_3._0_C_.Properties.Resources.join_leave;
            button_2.Image = Sussyraider_3._0_C_.Properties.Resources.nick_avator;
            button_3.Image = Sussyraider_3._0_C_.Properties.Resources.friend_dm;
            button_4.Image = Sussyraider_3._0_C_.Properties.Resources.spammer;
            button_5.Image = Sussyraider_3._0_C_.Properties.Resources.vcspammer;
            button_6.Image = Sussyraider_3._0_C_.Properties.Resources.reaction;
            button_7.Image = Sussyraider_3._0_C_.Properties.Resources.btnpusher;
            button_8.Image = Sussyraider_3._0_C_.Properties.Resources.report;

            label7.Visible = false;
            label8.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }
        private void hide_image()
        {
            button_1.Hide();
            button_2.Hide();
            button_3.Hide();
            button_4.Hide();
            button_5.Hide();
            button_6.Hide();
            button_7.Hide();
            button_8.Hide();
        }
        private void show_image()
        {
            button_1.Show();
            button_2.Show();
            button_3.Show();
            button_4.Show();
            button_5.Show();
            button_6.Show();
            button_7.Show();
            button_8.Show();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            module_setting(1);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            module_setting(2);
        }

        private void button_3_click(object sender, EventArgs e)
        {
            module_setting(3);
        }

        private void button_4_click(object sender, EventArgs e)
        {
            module_setting(4);
        }

        private void button_5_click(object sender, EventArgs e)
        {
            module_setting(5);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            module_setting(6);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            module_setting(7);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            module_setting(8);
        }
        private void button_frame_1_Click(object sender, EventArgs e)
        {
            module_frame(1);
        }
        private void button_frame_2_Click(object sender, EventArgs e)
        {
            module_frame(2);
        }

        private void module_frame(int click_button)
        {
            if (click_button == 1)
            {
                hide_image();
                next_button_1.Image = Sussyraider_3._0_C_.Properties.Resources.white_right;
                back_button_1.Image = Sussyraider_3._0_C_.Properties.Resources.blue_left;
                back_button_1.Enabled = true;
                defalut_image();
            }
            if (click_button == 2)
            {
                show_image();
                next_button_1.Image = Sussyraider_3._0_C_.Properties.Resources.blue_right;
                back_button_1.Image = Sussyraider_3._0_C_.Properties.Resources.white_left;
                back_button_1.Enabled = false;
                defalut_image();
            }
        }
        private void module_setting(int click_button)
        {
            if (click_button == 1)
            {
                defalut_image();
                button_1.Image = Sussyraider_3._0_C_.Properties.Resources.sel_join_leave;
                label7.Visible = true;
                label8.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            if (click_button == 2)
            {
                defalut_image();
                button_2.Image = Sussyraider_3._0_C_.Properties.Resources.sel_nick_avator;
            }
            if (click_button == 3)
            {
                defalut_image();
                button_3.Image = Sussyraider_3._0_C_.Properties.Resources.sel_friend_dm;
            }
            if (click_button == 4)
            {
                defalut_image();
                button_4.Image = Sussyraider_3._0_C_.Properties.Resources.sel_spammer;
            }
            if (click_button == 5)
            {
                defalut_image();
                button_5.Image = Sussyraider_3._0_C_.Properties.Resources.sel_vcspammer;
            }
            if (click_button == 6)
            {
                defalut_image();
                button_6.Image = Sussyraider_3._0_C_.Properties.Resources.sel_reaction;
            }
            if (click_button == 7)
            {
                defalut_image();
                button_7.Image = Sussyraider_3._0_C_.Properties.Resources.sel_btnpusher;
            }
            if (click_button == 8)
            {
                defalut_image();
                button_8.Image = Sussyraider_3._0_C_.Properties.Resources.sel_report;
            }
        }
    }
}
