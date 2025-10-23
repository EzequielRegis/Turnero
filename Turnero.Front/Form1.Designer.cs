namespace Turnero.Front
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNumeroTurno = new System.Windows.Forms.TextBox();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtPac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTurno = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.lstTurnos = new System.Windows.Forms.ListBox();
=======
            this.Buscar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtPac = new System.Windows.Forms.TextBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTurno = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
>>>>>>> 1645dc0dfd8ebab9efb0d64dd12f3770d2602bd5
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Turno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora";
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(504, 78);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 28);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
<<<<<<< HEAD
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(504, 175);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
=======
            // Buscar
            // 
            this.Buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Buscar.Location = new System.Drawing.Point(504, 175);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 6;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
>>>>>>> 1645dc0dfd8ebab9efb0d64dd12f3770d2602bd5
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(504, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.button3.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNumeroTurno
            // 
            this.txtNumeroTurno.Location = new System.Drawing.Point(504, 133);
            this.txtNumeroTurno.Name = "txtNumeroTurno";
            this.txtNumeroTurno.Size = new System.Drawing.Size(75, 24);
            this.txtNumeroTurno.TabIndex = 8;
            this.txtNumeroTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
=======
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(504, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 24);
            this.textBox1.TabIndex = 8;
>>>>>>> 1645dc0dfd8ebab9efb0d64dd12f3770d2602bd5
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(37, 48);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(61, 24);
            this.txtTurno.TabIndex = 10;
            this.txtTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(230, 48);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(100, 24);
            this.txtDoc.TabIndex = 12;
            this.txtDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPac
            // 
            this.txtPac.Location = new System.Drawing.Point(103, 48);
            this.txtPac.Name = "txtPac";
            this.txtPac.Size = new System.Drawing.Size(121, 24);
            this.txtPac.TabIndex = 13;
            this.txtPac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
<<<<<<< HEAD
=======
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(37, 92);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(44, 18);
            this.lblSalida.TabIndex = 15;
            this.lblSalida.Text = "Turnos";
            // 
>>>>>>> 1645dc0dfd8ebab9efb0d64dd12f3770d2602bd5
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(514, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "N° Turno";
            // 
            // dtpTurno
            // 
            this.dtpTurno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTurno.Location = new System.Drawing.Point(342, 48);
            this.dtpTurno.Name = "dtpTurno";
            this.dtpTurno.Size = new System.Drawing.Size(112, 24);
            this.dtpTurno.TabIndex = 17;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(467, 48);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(112, 24);
            this.timePicker.TabIndex = 18;
            // 
<<<<<<< HEAD
            // lstTurnos
            // 
            this.lstTurnos.FormattingEnabled = true;
            this.lstTurnos.ItemHeight = 17;
            this.lstTurnos.Location = new System.Drawing.Point(37, 155);
            this.lstTurnos.Name = "lstTurnos";
            this.lstTurnos.Size = new System.Drawing.Size(436, 225);
            this.lstTurnos.TabIndex = 19;
            // 
=======
>>>>>>> 1645dc0dfd8ebab9efb0d64dd12f3770d2602bd5
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(591, 422);
<<<<<<< HEAD
            this.Controls.Add(this.lstTurnos);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.dtpTurno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPac);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.txtNumeroTurno);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBuscar);
=======
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.dtpTurno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.txtPac);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Buscar);
>>>>>>> 1645dc0dfd8ebab9efb0d64dd12f3770d2602bd5
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Futura Std Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Turnero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNumeroTurno;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtPac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTurno;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.ListBox lstTurnos;
=======
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtPac;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTurno;
        private System.Windows.Forms.DateTimePicker timePicker;
>>>>>>> 1645dc0dfd8ebab9efb0d64dd12f3770d2602bd5
    }
}

