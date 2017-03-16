namespace Etike
{
    partial class Exportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exportar));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.rbtnExcel = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnEtiqueta = new MetroFramework.Controls.MetroRadioButton();
            this.btnImprimir = new MetroFramework.Controls.MetroButton();
            this.chkInvalido = new MetroFramework.Controls.MetroCheckBox();
            this.chkValido = new MetroFramework.Controls.MetroCheckBox();
            this.loadExportar = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(74, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(149, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Exportar Registros";
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(66, 174);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(164, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Formato do Arquivo";
            this.metroLabel3.UseStyleColors = true;
            // 
            // rbtnExcel
            // 
            this.rbtnExcel.AutoSize = true;
            this.rbtnExcel.Location = new System.Drawing.Point(111, 202);
            this.rbtnExcel.Name = "rbtnExcel";
            this.rbtnExcel.Size = new System.Drawing.Size(49, 15);
            this.rbtnExcel.Style = MetroFramework.MetroColorStyle.Purple;
            this.rbtnExcel.TabIndex = 7;
            this.rbtnExcel.Text = "Excel";
            this.rbtnExcel.UseSelectable = true;
            // 
            // rbtnEtiqueta
            // 
            this.rbtnEtiqueta.AutoSize = true;
            this.rbtnEtiqueta.Location = new System.Drawing.Point(111, 223);
            this.rbtnEtiqueta.Name = "rbtnEtiqueta";
            this.rbtnEtiqueta.Size = new System.Drawing.Size(66, 15);
            this.rbtnEtiqueta.Style = MetroFramework.MetroColorStyle.Purple;
            this.rbtnEtiqueta.TabIndex = 8;
            this.rbtnEtiqueta.Text = "Etiqueta";
            this.rbtnEtiqueta.UseSelectable = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnImprimir.Location = new System.Drawing.Point(74, 255);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(149, 57);
            this.btnImprimir.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseSelectable = true;
            this.btnImprimir.UseStyleColors = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // chkInvalido
            // 
            this.chkInvalido.AutoSize = true;
            this.chkInvalido.Location = new System.Drawing.Point(111, 137);
            this.chkInvalido.Name = "chkInvalido";
            this.chkInvalido.Size = new System.Drawing.Size(70, 15);
            this.chkInvalido.Style = MetroFramework.MetroColorStyle.Purple;
            this.chkInvalido.TabIndex = 2;
            this.chkInvalido.Text = "Inválidos";
            this.chkInvalido.UseSelectable = true;
            this.chkInvalido.Click += new System.EventHandler(this.chkInvalido_Click);
            // 
            // chkValido
            // 
            this.chkValido.AutoSize = true;
            this.chkValido.Location = new System.Drawing.Point(111, 116);
            this.chkValido.Name = "chkValido";
            this.chkValido.Size = new System.Drawing.Size(60, 15);
            this.chkValido.Style = MetroFramework.MetroColorStyle.Purple;
            this.chkValido.TabIndex = 1;
            this.chkValido.Text = "Válidos";
            this.chkValido.UseSelectable = true;
            this.chkValido.Click += new System.EventHandler(this.chkValido_Click);
            // 
            // loadExportar
            // 
            this.loadExportar.Location = new System.Drawing.Point(10, 62);
            this.loadExportar.Name = "loadExportar";
            this.loadExportar.Size = new System.Drawing.Size(278, 4);
            this.loadExportar.Style = MetroFramework.MetroColorStyle.Purple;
            this.loadExportar.TabIndex = 11;
            this.loadExportar.UseCustomBackColor = true;
            // 
            // Exportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 336);
            this.Controls.Add(this.loadExportar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.rbtnEtiqueta);
            this.Controls.Add(this.rbtnExcel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.chkInvalido);
            this.Controls.Add(this.chkValido);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exportar";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Exportar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroRadioButton rbtnExcel;
        private MetroFramework.Controls.MetroRadioButton rbtnEtiqueta;
        private MetroFramework.Controls.MetroButton btnImprimir;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox chkInvalido;
        private MetroFramework.Controls.MetroCheckBox chkValido;
        private MetroFramework.Controls.MetroProgressBar loadExportar;
    }
}