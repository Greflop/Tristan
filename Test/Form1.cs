using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
            : base()
        {
            InitializeComboBox();
            InitializeComboBox2(null);
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.Label1.Location = new System.Drawing.Point(8, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 32);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Use drop-down to choose a name:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        public static void Main()
        {
            Application.Run(new Form1());
        }

        internal System.Windows.Forms.Label Label1;

        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.ComboBox ComboBox2;

        // This method initializes the combo box, adding a large string array
        // but limiting the drop-down size to six rows so the combo box doesn't 
        // cover other controls when it expands.
        private void InitializeComboBox()
        {
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            string[] employees = new string[]{"Human", 
				"Animal", "Others"};

            ComboBox1.Items.AddRange(employees);
            this.ComboBox1.Location = new System.Drawing.Point(136, 32);
            this.ComboBox1.IntegralHeight = false;
            this.ComboBox1.MaxDropDownItems = 5;
            this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(136, 81);
            this.ComboBox1.TabIndex = 0;
            this.Controls.Add(this.ComboBox1);

            // Associate the event-handling method with the 
            // SelectedIndexChanged event.
            this.ComboBox1.SelectedIndexChanged +=
                new System.EventHandler(ComboBox1_SelectedIndexChanged);
        }

        private void InitializeComboBox2(string content)
        {
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            string[] emptycbb1 = new string[] { "please fill combobox1" };
            ComboBox2.Items.AddRange(emptycbb1);
            this.ComboBox2.Location = new System.Drawing.Point(64, 128);
            this.ComboBox2.IntegralHeight = false;
            this.ComboBox2.MaxDropDownItems = 5;
            this.ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(136, 81);
            this.ComboBox2.TabIndex = 0;
            this.Controls.Add(this.ComboBox2);
        }

        private void ComboBox1_SelectedIndexChanged(object sender,
            System.EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            string test = (string)ComboBox1.SelectedItem;

            ComboBox2.Items.Clear();

            string[] human = new string[] { "Male", "Female" };
            string[] animal = new string[] { "Cat", "Dog" };
            string[] others = new string[] { "Whatever" };
            string[] emptycbb1 = new string[] { "please fill combobox1" };
            switch (test)
            {
                case "Human":
                    ComboBox2.Items.AddRange(human);
                    break;
                case "Animal":
                    ComboBox2.Items.AddRange(animal);
                    break;
                case "Others":
                    ComboBox2.Items.AddRange(others);
                    break;
                default:
                    ComboBox2.Items.AddRange(emptycbb1);
                    break;
            }            
        }
    }
}