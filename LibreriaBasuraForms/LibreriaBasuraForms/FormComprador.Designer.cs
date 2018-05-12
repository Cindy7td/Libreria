namespace LibreriaBasuraForms
{
    partial class FormComprador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnComprar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnAddDinero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnComprar
            // 
            this.bttnComprar.Location = new System.Drawing.Point(607, 569);
            this.bttnComprar.Name = "bttnComprar";
            this.bttnComprar.Size = new System.Drawing.Size(449, 74);
            this.bttnComprar.TabIndex = 0;
            this.bttnComprar.Text = "Comprar";
            this.bttnComprar.UseVisualStyleBackColor = true;
            this.bttnComprar.Click += new System.EventHandler(this.bttnComprar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(936, 295);
            this.dataGridView1.TabIndex = 1;
            // 
            // bttnAddDinero
            // 
            this.bttnAddDinero.Location = new System.Drawing.Point(129, 569);
            this.bttnAddDinero.Name = "bttnAddDinero";
            this.bttnAddDinero.Size = new System.Drawing.Size(414, 74);
            this.bttnAddDinero.TabIndex = 2;
            this.bttnAddDinero.Text = "Agregar dinero";
            this.bttnAddDinero.UseVisualStyleBackColor = true;
            this.bttnAddDinero.Click += new System.EventHandler(this.bttnAddDinero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por titulo:";
            // 
            // txtBTitulo
            // 
            this.txtBTitulo.Location = new System.Drawing.Point(275, 35);
            this.txtBTitulo.Name = "txtBTitulo";
            this.txtBTitulo.Size = new System.Drawing.Size(237, 38);
            this.txtBTitulo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar por genero:";
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(829, 38);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(239, 39);
            this.cbGenero.TabIndex = 7;
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Location = new System.Drawing.Point(196, 98);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(203, 59);
            this.bttnBuscar.TabIndex = 8;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bttnBuscarG_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(735, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Favor de seleccionar el titulo del libro que desee comprar";
            // 
            // FormComprador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 706);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnAddDinero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttnComprar);
            this.Name = "FormComprador";
            this.Text = "FormComprador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnComprar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnAddDinero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}