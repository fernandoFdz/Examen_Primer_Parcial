namespace _1P_Granja_Fernandez
{
    partial class Form1
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.ListBox();
            this.labelE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Ciudad de México",
            "Cohauila ",
            "Colima",
            "Durango",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Toluca",
            "Michoacan",
            "Morelos",
            "Nayarit",
            "Nuevo Leon",
            "Oaxaca",
            "Puebla ",
            "Queretaro",
            "Quintana Roo ",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco"});
            this.lb1.Location = new System.Drawing.Point(63, 43);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(136, 199);
            this.lb1.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(232, 88);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(340, 43);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(120, 199);
            this.lb2.TabIndex = 2;
            this.lb2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(232, 143);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb3
            // 
            this.lb3.FormattingEnabled = true;
            this.lb3.Location = new System.Drawing.Point(559, 43);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(120, 199);
            this.lb3.TabIndex = 4;
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(511, 252);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(0, 13);
            this.labelE.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 302);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ListBox lb3;
        private System.Windows.Forms.Label labelE;
    }
}

