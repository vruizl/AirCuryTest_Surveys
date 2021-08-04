
namespace AirCuryTest_Surveys
{
    partial class FormPpal
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
            this.gbEncuestas = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbEncuestas
            // 
            this.gbEncuestas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEncuestas.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEncuestas.Location = new System.Drawing.Point(5, 5);
            this.gbEncuestas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEncuestas.Name = "gbEncuestas";
            this.gbEncuestas.Padding = new System.Windows.Forms.Padding(5);
            this.gbEncuestas.Size = new System.Drawing.Size(737, 404);
            this.gbEncuestas.TabIndex = 0;
            this.gbEncuestas.TabStop = false;
            this.gbEncuestas.Text = "Encuestas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 414);
            this.Controls.Add(this.gbEncuestas);
            this.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Página de encuestas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEncuestas;
    }
}

