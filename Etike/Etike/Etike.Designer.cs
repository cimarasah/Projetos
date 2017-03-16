using iTextSharp.text;
using System.Drawing;

namespace Etike
{
    partial class Etike
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etike));
            this.openFilePdf = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCaminhoArquivo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbxFiltro = new MetroFramework.Controls.MetroComboBox();
            this.invalido = new MetroFramework.Controls.MetroTabControl();
            this.validos = new MetroFramework.Controls.MetroTabPage();
            this.dgrProfessorValido = new MetroFramework.Controls.MetroGrid();
            this.matriculaValida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeValido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoValido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEPvalido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SituacaoValido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invalido1 = new MetroFramework.Controls.MetroTabPage();
            this.dgrProfessorInvalido = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Converter = new MetroFramework.Controls.MetroButton();
            this.btnBuscarPdf = new MetroFramework.Controls.MetroButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnExportar = new MetroFramework.Controls.MetroButton();
            this.progressoCarregar = new MetroFramework.Controls.MetroProgressBar();
            this.progressoBusca = new MetroFramework.Controls.MetroProgressBar();
            this.progressoextrairPDF = new MetroFramework.Controls.MetroProgressBar();
            this.invalido.SuspendLayout();
            this.validos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProfessorValido)).BeginInit();
            this.invalido1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProfessorInvalido)).BeginInit();
            this.SuspendLayout();
            // 
            // openFilePdf
            // 
            this.openFilePdf.Filter = "pdf files (*.pdf)|*.pdf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(30, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Arquivo";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtCaminhoArquivo
            // 
            // 
            // 
            // 
            this.txtCaminhoArquivo.CustomButton.Image = null;
            this.txtCaminhoArquivo.CustomButton.Location = new System.Drawing.Point(325, 1);
            this.txtCaminhoArquivo.CustomButton.Name = "";
            this.txtCaminhoArquivo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCaminhoArquivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCaminhoArquivo.CustomButton.TabIndex = 1;
            this.txtCaminhoArquivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCaminhoArquivo.CustomButton.UseSelectable = true;
            this.txtCaminhoArquivo.CustomButton.Visible = false;
            this.txtCaminhoArquivo.Enabled = false;
            this.txtCaminhoArquivo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCaminhoArquivo.Lines = new string[0];
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(107, 66);
            this.txtCaminhoArquivo.MaxLength = 32767;
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.PasswordChar = '\0';
            this.txtCaminhoArquivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCaminhoArquivo.SelectedText = "";
            this.txtCaminhoArquivo.SelectionLength = 0;
            this.txtCaminhoArquivo.SelectionStart = 0;
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(353, 29);
            this.txtCaminhoArquivo.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtCaminhoArquivo.TabIndex = 15;
            this.txtCaminhoArquivo.UseSelectable = true;
            this.txtCaminhoArquivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCaminhoArquivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(565, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 25);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Filtro";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.ItemHeight = 23;
            this.cbxFiltro.Items.AddRange(new object[] {
            "TODOS",
            "EFETIVO",
            "APOSENTADO"});
            this.cbxFiltro.Location = new System.Drawing.Point(620, 66);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(189, 29);
            this.cbxFiltro.Style = MetroFramework.MetroColorStyle.Purple;
            this.cbxFiltro.TabIndex = 18;
            this.cbxFiltro.UseSelectable = true;
            // 
            // invalido
            // 
            this.invalido.Controls.Add(this.validos);
            this.invalido.Controls.Add(this.invalido1);
            this.invalido.Location = new System.Drawing.Point(34, 117);
            this.invalido.Name = "invalido";
            this.invalido.SelectedIndex = 0;
            this.invalido.Size = new System.Drawing.Size(1232, 513);
            this.invalido.Style = MetroFramework.MetroColorStyle.Purple;
            this.invalido.TabIndex = 19;
            this.invalido.UseSelectable = true;
            // 
            // validos
            // 
            this.validos.Controls.Add(this.dgrProfessorValido);
            this.validos.HorizontalScrollbarBarColor = true;
            this.validos.HorizontalScrollbarHighlightOnWheel = false;
            this.validos.HorizontalScrollbarSize = 10;
            this.validos.Location = new System.Drawing.Point(4, 38);
            this.validos.Name = "validos";
            this.validos.Size = new System.Drawing.Size(1224, 471);
            this.validos.Style = MetroFramework.MetroColorStyle.Red;
            this.validos.TabIndex = 0;
            this.validos.Text = "Registros Válidos";
            this.validos.VerticalScrollbarBarColor = true;
            this.validos.VerticalScrollbarHighlightOnWheel = false;
            this.validos.VerticalScrollbarSize = 10;
            // 
            // dgrProfessorValido
            // 
            this.dgrProfessorValido.AllowUserToResizeRows = false;
            this.dgrProfessorValido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgrProfessorValido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrProfessorValido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrProfessorValido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrProfessorValido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrProfessorValido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrProfessorValido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaValida,
            this.nomeValido,
            this.EnderecoValido,
            this.CEPvalido,
            this.SituacaoValido});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrProfessorValido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrProfessorValido.EnableHeadersVisualStyles = false;
            this.dgrProfessorValido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgrProfessorValido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgrProfessorValido.Location = new System.Drawing.Point(0, 13);
            this.dgrProfessorValido.Name = "dgrProfessorValido";
            this.dgrProfessorValido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrProfessorValido.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrProfessorValido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgrProfessorValido.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgrProfessorValido.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrProfessorValido.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Purple;
            this.dgrProfessorValido.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Thistle;
            this.dgrProfessorValido.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgrProfessorValido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrProfessorValido.Size = new System.Drawing.Size(1221, 384);
            this.dgrProfessorValido.Style = MetroFramework.MetroColorStyle.Purple;
            this.dgrProfessorValido.TabIndex = 2;
            // 
            // matriculaValida
            // 
            this.matriculaValida.HeaderText = "Matrícula";
            this.matriculaValida.Name = "matriculaValida";
            this.matriculaValida.Width = 120;
            // 
            // nomeValido
            // 
            this.nomeValido.HeaderText = "Nome";
            this.nomeValido.Name = "nomeValido";
            this.nomeValido.Width = 350;
            // 
            // EnderecoValido
            // 
            this.EnderecoValido.HeaderText = "Endereço";
            this.EnderecoValido.Name = "EnderecoValido";
            this.EnderecoValido.Width = 450;
            // 
            // CEPvalido
            // 
            this.CEPvalido.HeaderText = "CEP";
            this.CEPvalido.Name = "CEPvalido";
            this.CEPvalido.Width = 120;
            // 
            // SituacaoValido
            // 
            this.SituacaoValido.HeaderText = "Situação";
            this.SituacaoValido.Name = "SituacaoValido";
            this.SituacaoValido.Width = 120;
            // 
            // invalido1
            // 
            this.invalido1.Controls.Add(this.dgrProfessorInvalido);
            this.invalido1.HorizontalScrollbarBarColor = true;
            this.invalido1.HorizontalScrollbarHighlightOnWheel = false;
            this.invalido1.HorizontalScrollbarSize = 10;
            this.invalido1.Location = new System.Drawing.Point(4, 38);
            this.invalido1.Name = "invalido1";
            this.invalido1.Size = new System.Drawing.Size(1224, 471);
            this.invalido1.TabIndex = 2;
            this.invalido1.Text = "Registros Inválidos";
            this.invalido1.VerticalScrollbarBarColor = true;
            this.invalido1.VerticalScrollbarHighlightOnWheel = false;
            this.invalido1.VerticalScrollbarSize = 10;
            // 
            // dgrProfessorInvalido
            // 
            this.dgrProfessorInvalido.AllowUserToResizeRows = false;
            this.dgrProfessorInvalido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgrProfessorInvalido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrProfessorInvalido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrProfessorInvalido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrProfessorInvalido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrProfessorInvalido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrProfessorInvalido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrProfessorInvalido.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgrProfessorInvalido.EnableHeadersVisualStyles = false;
            this.dgrProfessorInvalido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgrProfessorInvalido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgrProfessorInvalido.Location = new System.Drawing.Point(0, 13);
            this.dgrProfessorInvalido.Name = "dgrProfessorInvalido";
            this.dgrProfessorInvalido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrProfessorInvalido.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgrProfessorInvalido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgrProfessorInvalido.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgrProfessorInvalido.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrProfessorInvalido.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Purple;
            this.dgrProfessorInvalido.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Thistle;
            this.dgrProfessorInvalido.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgrProfessorInvalido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrProfessorInvalido.Size = new System.Drawing.Size(1221, 421);
            this.dgrProfessorInvalido.Style = MetroFramework.MetroColorStyle.Purple;
            this.dgrProfessorInvalido.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Matrícula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 460;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Situação";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // Converter
            // 
            this.Converter.BackgroundImage = global::Etike.Properties.Resources._1453456749_179_Upload1;
            this.Converter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Converter.Location = new System.Drawing.Point(815, 66);
            this.Converter.Name = "Converter";
            this.Converter.Size = new System.Drawing.Size(37, 29);
            this.Converter.Style = MetroFramework.MetroColorStyle.Purple;
            this.Converter.TabIndex = 20;
            this.Converter.UseSelectable = true;
            this.Converter.Click += new System.EventHandler(this.Converter_Click);
            // 
            // btnBuscarPdf
            // 
            this.btnBuscarPdf.BackgroundImage = global::Etike.Properties.Resources._1453457269_Search_Icon;
            this.btnBuscarPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarPdf.Location = new System.Drawing.Point(466, 66);
            this.btnBuscarPdf.Name = "btnBuscarPdf";
            this.btnBuscarPdf.Size = new System.Drawing.Size(36, 28);
            this.btnBuscarPdf.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnBuscarPdf.TabIndex = 16;
            this.btnBuscarPdf.UseSelectable = true;
            this.btnBuscarPdf.Click += new System.EventHandler(this.btnBuscarPdf_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.White;
            this.btnExportar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(1093, 658);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(169, 38);
            this.btnExportar.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnExportar.TabIndex = 21;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseCustomBackColor = true;
            this.btnExportar.UseSelectable = true;
            this.btnExportar.UseStyleColors = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // progressoCarregar
            // 
            this.progressoCarregar.HideProgressText = false;
            this.progressoCarregar.Location = new System.Drawing.Point(650, 107);
            this.progressoCarregar.Name = "progressoCarregar";
            this.progressoCarregar.Size = new System.Drawing.Size(612, 4);
            this.progressoCarregar.Style = MetroFramework.MetroColorStyle.Purple;
            this.progressoCarregar.TabIndex = 22;
            this.progressoCarregar.UseCustomBackColor = true;
            // 
            // progressoBusca
            // 
            this.progressoBusca.HideProgressText = false;
            this.progressoBusca.Location = new System.Drawing.Point(344, 107);
            this.progressoBusca.Name = "progressoBusca";
            this.progressoBusca.Size = new System.Drawing.Size(306, 4);
            this.progressoBusca.Style = MetroFramework.MetroColorStyle.Purple;
            this.progressoBusca.TabIndex = 24;
            this.progressoBusca.UseCustomBackColor = true;
            // 
            // progressoextrairPDF
            // 
            this.progressoextrairPDF.HideProgressText = false;
            this.progressoextrairPDF.Location = new System.Drawing.Point(38, 107);
            this.progressoextrairPDF.Name = "progressoextrairPDF";
            this.progressoextrairPDF.Size = new System.Drawing.Size(306, 4);
            this.progressoextrairPDF.Style = MetroFramework.MetroColorStyle.Purple;
            this.progressoextrairPDF.TabIndex = 25;
            this.progressoextrairPDF.UseCustomBackColor = true;
            // 
            // Etike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 716);
            this.Controls.Add(this.progressoextrairPDF);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.progressoCarregar);
            this.Controls.Add(this.Converter);
            this.Controls.Add(this.progressoBusca);
            this.Controls.Add(this.invalido);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnBuscarPdf);
            this.Controls.Add(this.txtCaminhoArquivo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Etike";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Etike";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.invalido.ResumeLayout(false);
            this.validos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrProfessorValido)).EndInit();
            this.invalido1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrProfessorInvalido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFilePdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCaminhoArquivo;
        private MetroFramework.Controls.MetroButton btnBuscarPdf;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbxFiltro;
        private MetroFramework.Controls.MetroTabControl invalido;
        private MetroFramework.Controls.MetroTabPage validos;
        public MetroFramework.Controls.MetroGrid dgrProfessorValido;
        private MetroFramework.Controls.MetroTabPage invalido1;
        private MetroFramework.Controls.MetroButton Converter;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroButton btnExportar;
        private MetroFramework.Controls.MetroProgressBar progressoCarregar;
        private MetroFramework.Controls.MetroProgressBar progressoBusca;
        public MetroFramework.Controls.MetroGrid dgrProfessorInvalido;
        private MetroFramework.Controls.MetroProgressBar progressoextrairPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SituacaoValido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEPvalido;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoValido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeValido;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaValida;
    }
}

