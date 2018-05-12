using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBasuraForms.Classes;
using LibreriaBasuraForms.Enums;
using LibreriaBasuraForms.Utilities;

namespace LibreriaBasuraForms
{
    public partial class FormLogin : Form
    {
        Inventario inventario;

        public FormLogin()
        {
            InitializeComponent();
            
            inventario = new Inventario();

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDynamicForm("Register");
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDynamicForm("login");
        }

        private void CreateDynamicForm(string text)

        {
            // Create labels
            var num = 0;
            Label l = new Label();
            TextBox tb;
            if (text == "login")
            {
                num = 2;
            }
            else
            {
                num = 3;
            }

            for(int i = 0; i < num; i++)
            {
                l = new Label();
                tb = new TextBox();
                l.AutoSize = true;
                tb.Width = 100;

                switch (i)
                {
                    case 0:
                        l.Text = "correo";
                        break;
                    case 1:
                        l.Text = "contrasenia";
                        break;
                    case 2:
                        l.Text = "Usuario";
                        break;
                }
                tb.Location = new Point(Width / 2 - (tb.Width / 2), (50 * (i + 1)) - (tb.Width / 2));
                l.Location = new Point(Width / 2 - (tb.Width/2) - l.Width, tb.Top);
                l.Name = "dynamiclabel" + i.ToString();
                tb.Name = "dynamictb" + i.ToString();

                Controls.Add(tb);
                Controls.Add(l);
            }

            // Create a Button object
            Button dynamicButton = new Button();

            // Set Button properties
            dynamicButton.AutoSize = true;

            dynamicButton.Text = text;
            dynamicButton.Location = new Point(Width / 2 - (dynamicButton.Width / 2), l.Bottom + 50);
            dynamicButton.Name = "dynamicButton";

            // Add a Button Click Event handler
            if (text == "login")
            {
                dynamicButton.Click += new EventHandler(dynamicButtonLogin_Click);
            }
            else
            {
                dynamicButton.Click += new EventHandler(dynamicButtonRegister_Click);
            }

            Controls.Add(dynamicButton);
        }

        private void dynamicButtonRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void dynamicButtonLogin_Click(object sender, EventArgs e)

        {

            MessageBox.Show("Dynamic button is clicked");

        }
    }
}
