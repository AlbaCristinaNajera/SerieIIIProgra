namespace Desafio2
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
            this.label = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtPeriodoTiempo = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcularCuotas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtTotalIntereses = new System.Windows.Forms.TextBox();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de Cuotas ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto del prestamo ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(330, 67);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(132, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Tasa de Interés ";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.AutoSize = true;
            this.txtPeriodo.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.Location = new System.Drawing.Point(579, 67);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(126, 17);
            this.txtPeriodo.TabIndex = 3;
            this.txtPeriodo.Text = "Periodo(tiempo)";
            // 
            // txtmonto
            // 
            this.txtmonto.BackColor = System.Drawing.Color.RosyBrown;
            this.txtmonto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonto.Location = new System.Drawing.Point(65, 86);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(157, 25);
            this.txtmonto.TabIndex = 4;
            this.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInteres
            // 
            this.txtInteres.BackColor = System.Drawing.Color.RosyBrown;
            this.txtInteres.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteres.Location = new System.Drawing.Point(333, 85);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(167, 25);
            this.txtInteres.TabIndex = 5;
            this.txtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPeriodoTiempo
            // 
            this.txtPeriodoTiempo.BackColor = System.Drawing.Color.RosyBrown;
            this.txtPeriodoTiempo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodoTiempo.Location = new System.Drawing.Point(582, 85);
            this.txtPeriodoTiempo.Name = "txtPeriodoTiempo";
            this.txtPeriodoTiempo.Size = new System.Drawing.Size(140, 25);
            this.txtPeriodoTiempo.TabIndex = 6;
            this.txtPeriodoTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtResultado.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(162, 161);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(454, 23);
            this.txtResultado.TabIndex = 7;
            // 
            // btnCalcularCuotas
            // 
            this.btnCalcularCuotas.BackColor = System.Drawing.Color.Violet;
            this.btnCalcularCuotas.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularCuotas.Location = new System.Drawing.Point(287, 271);
            this.btnCalcularCuotas.Name = "btnCalcularCuotas";
            this.btnCalcularCuotas.Size = new System.Drawing.Size(91, 57);
            this.btnCalcularCuotas.TabIndex = 8;
            this.btnCalcularCuotas.Text = "Calcular";
            this.btnCalcularCuotas.UseVisualStyleBackColor = false;
            this.btnCalcularCuotas.Click += new System.EventHandler(this.btnCalcularCuotas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSalir.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(3, 404);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 43);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Violet;
            this.btnLimpiar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(429, 271);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 57);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar Pantalla";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtTotalIntereses
            // 
            this.txtTotalIntereses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTotalIntereses.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIntereses.Location = new System.Drawing.Point(162, 191);
            this.txtTotalIntereses.Name = "txtTotalIntereses";
            this.txtTotalIntereses.Size = new System.Drawing.Size(454, 23);
            this.txtTotalIntereses.TabIndex = 11;
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTotalAPagar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAPagar.Location = new System.Drawing.Point(162, 217);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(454, 23);
            this.txtTotalAPagar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalAPagar);
            this.Controls.Add(this.txtTotalIntereses);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularCuotas);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtPeriodoTiempo);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label txtPeriodo;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtPeriodoTiempo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcularCuotas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtTotalIntereses;
        private System.Windows.Forms.TextBox txtTotalAPagar;
    }
}

