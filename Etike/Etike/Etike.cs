using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Etike
{
    public partial class Etike : MetroForm
    {

        Util pdftxt = new Util();
        public Etike()
        {

            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
            btnExportar.Enabled = false;
        }



        //private void Converter_Click(object sender, EventArgs e)
        //{
        //    List<Professor> professores = pdftxt.BuscarProfessores(cbxFiltro.Text, pdftxt.ExtrairTexto_PDF(txtCaminhoArquivo.Text));
        //    dgrProfessorValido.Rows.Clear();
        //    dgrProfessorInvalido.Rows.Clear();

        //    for (int i = 0; i < professores.Count; i++)
        //    {
        //        if (professores[i].Matricula.Replace(".", "").Replace("-", "").Length.Equals(7)
        //            && !professores[i].Nome.Replace(" ", "").Equals("")
        //            && !professores[i].CEP.Replace(" ", "").Equals("")
        //            && !professores[i].Endereco.Replace(" ", "").Equals(""))
        //        {
        //            dgrProfessorValido.Rows.Add(professores[i].Matricula, professores[i].Nome, professores[i].Endereco, professores[i].CEP, professores[i].Situacao);
        //        }
        //        else
        //        {
        //            dgrProfessorInvalido.Rows.Add(professores[i].Matricula, professores[i].Nome, professores[i].Endereco, professores[i].CEP, professores[i].Situacao);
        //        }

        //    }
            //if (dgrProfessorValido.RowCount > 0)
            //{
            //    this.somenteValidosToolStripMenuItem.Enabled = true;
            //}
            //else
            //{
            //    this.somenteValidosToolStripMenuItem.Enabled = false;
            //}

            //if (dgrProfessorInvalido.RowCount > 0)
            //{
            //    this.somenteInvalidosToolStripMenuItem.Enabled = true;
            //}
            //else
            //{
            //    this.somenteInvalidosToolStripMenuItem.Enabled = false;
            //}
            //if (dgrProfessorValido.RowCount > 0 && dgrProfessorInvalido.RowCount > 0)
            //{
            //    this.todosToolStripMenuItem.Enabled = true;
            //}
            //else
            //{
            //    this.todosToolStripMenuItem.Enabled = false;
            //}
       // }

        //private void ExportarExcel_Click(object sender, EventArgs e)
        //{

        //}
        ////todos
        //private void eXCELToolStripMenuItem2_Click(object sender, EventArgs e)
        //{
        //    if (dgrProfessorValido.RowCount > 0 && dgrProfessorInvalido.RowCount > 0)
        //    {
        //        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        //        try
        //        {

        //            XcelApp.Application.Workbooks.Add(Type.Missing);
        //            for (int i = 1; i < dgrProfessorValido.Columns.Count + 1; i++)
        //            {
        //                XcelApp.Cells[1, i] = dgrProfessorValido.Columns[i - 1].HeaderText;
        //            }
        //            //
        //            for (int i = 0; i < dgrProfessorValido.Rows.Count - 1; i++)
        //            {
        //                for (int j = 0; j < dgrProfessorValido.Columns.Count; j++)
        //                {
        //                    XcelApp.Cells[i + 2, j + 1] = dgrProfessorValido.Rows[i].Cells[j].Value.ToString();
        //                }
        //            }
        //            for (int i = 1; i < dgrProfessorInvalido.Columns.Count + 1; i++)
        //            {
        //                XcelApp.Cells[1, i] = dgrProfessorInvalido.Columns[i - 1].HeaderText;
        //            }
        //            //
        //            for (int i = 0; i < dgrProfessorInvalido.Rows.Count - 1; i++)
        //            {
        //                for (int j = 0; j < dgrProfessorInvalido.Columns.Count; j++)
        //                {
        //                    XcelApp.Cells[i + 2, j + 1] = dgrProfessorInvalido.Rows[i].Cells[j].Value.ToString();
        //                }
        //            }
        //            //
        //            XcelApp.Columns.AutoFit();
        //            //
        //            XcelApp.Visible = true;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro : " + ex.Message);
        //            XcelApp.Quit();
        //        }
        //    }
        //}
        ////somente validos
        //private void eXCELToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (dgrProfessorValido.Rows.Count > 0)
        //    {
        //        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        //        try
        //        {
        //            XcelApp.Application.Workbooks.Add(Type.Missing);
        //            for (int i = 1; i < dgrProfessorValido.Columns.Count + 1; i++)
        //            {
        //                XcelApp.Cells[1, i] = dgrProfessorValido.Columns[i - 1].HeaderText;
        //            }
        //            //
        //            for (int i = 0; i < dgrProfessorValido.Rows.Count - 1; i++)
        //            {
        //                for (int j = 0; j < dgrProfessorValido.Columns.Count; j++)
        //                {
        //                    XcelApp.Cells[i + 2, j + 1] = dgrProfessorValido.Rows[i].Cells[j].Value.ToString();
        //                }
        //            }
        //            //
        //            XcelApp.Columns.AutoFit();
        //            //
        //            XcelApp.Visible = true;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro : " + ex.Message);
        //            XcelApp.Quit();
        //        }
        //    }
        //}
        //// somente inválidos
        //private void eXCELToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    if (dgrProfessorInvalido.Rows.Count > 0)
        //    {
        //        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        //        try
        //        {
        //            XcelApp.Application.Workbooks.Add(Type.Missing);
        //            for (int i = 1; i < dgrProfessorInvalido.Columns.Count + 1; i++)
        //            {
        //                XcelApp.Cells[1, i] = dgrProfessorInvalido.Columns[i - 1].HeaderText;
        //            }
        //            //
        //            for (int i = 0; i < dgrProfessorInvalido.Rows.Count - 1; i++)
        //            {
        //                for (int j = 0; j < dgrProfessorInvalido.Columns.Count; j++)
        //                {
        //                    XcelApp.Cells[i + 2, j + 1] = dgrProfessorInvalido.Rows[i].Cells[j].Value.ToString();
        //                }
        //            }
        //            //
        //            XcelApp.Columns.AutoFit();
        //            //
        //            XcelApp.Visible = true;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro : " + ex.Message);
        //            XcelApp.Quit();
        //        }
        //    }
        //}


        //private void eTIQUETAToolStripMenuItem2_Click(object sender, EventArgs e)
        //{

        //}



        private void btnBuscarPdf_Click(object sender, EventArgs e)
        {
            this.openFilePdf.Multiselect = false;
            this.openFilePdf.Title = "Selecionar PDF";
            openFilePdf.InitialDirectory = @"C:\dados";
            openFilePdf.CheckFileExists = true;
            openFilePdf.CheckPathExists = true;
            openFilePdf.RestoreDirectory = true;
            openFilePdf.ReadOnlyChecked = true;
            openFilePdf.ShowReadOnly = false;

            DialogResult dr = this.openFilePdf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtCaminhoArquivo.Text = openFilePdf.FileName;
            }
        }
        public string ExtrairTexto_PDF(string caminho)
        {
            using (PdfReader leitor = new PdfReader(caminho))
            {
                StringBuilder texto = new StringBuilder();
                progressoextrairPDF.Maximum = leitor.NumberOfPages;
                for (int i = 1; i <= leitor.NumberOfPages; i++)
                {
                    texto.Append(PdfTextExtractor.GetTextFromPage(leitor, i));
                    progressoextrairPDF.Value = i;
                }
                return texto.ToString();
            }
        }
        private void Converter_Click(object sender, EventArgs e)
        {
           
            progressoCarregar.Value = 0;
            progressoBusca.Value = 0;
            progressoextrairPDF.Value = 0;
            List<Professor> professores = BuscarProfessores(cbxFiltro.Text, ExtrairTexto_PDF(txtCaminhoArquivo.Text));
            
            progressoCarregar.Maximum = professores.Count();
            dgrProfessorValido.Rows.Clear();
            dgrProfessorInvalido.Rows.Clear();

            for (int i = 0; i < professores.Count; i++)
            {
                if (professores[i].Matricula.Replace(".", "").Replace("-", "").Length.Equals(7)
                    && !professores[i].Nome.Replace(" ", "").Equals("")
                    && !professores[i].CEP.Replace(" ", "").Equals("")
                    && !professores[i].Endereco.Replace(" ", "").Equals(""))
                {
                    
                    dgrProfessorValido.Rows.Add(professores[i].Matricula, professores[i].Nome, professores[i].Endereco, professores[i].CEP, professores[i].Situacao?"Efetivo":"Aposentado");
                }
                else
                {
                    
                    dgrProfessorInvalido.Rows.Add(professores[i].Matricula, professores[i].Nome, professores[i].Endereco, professores[i].CEP, professores[i].Situacao ? "Efetivo" : "Aposentado");
                }
                progressoCarregar.Value = i;
            }
            progressoextrairPDF.Value = 0;
            progressoCarregar.Value = 0;
            progressoBusca.Value = 0;
            if (professores.Count() > 0)
            {
                btnExportar.Enabled = true;
            }
            else
            {
                MetroMessageBox.Show(this, "Arquivo incorreto, tente outro arquivo ou entre em contato com o suporte", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtCaminhoArquivo.Text = "";
                btnExportar.Enabled = false;
            }
        }
        public List<Professor> BuscarProfessores(string filtro, string textPdf)
        {
            
            List<Professor> professores = new List<Professor>();
            Professor prof;
            var texto = textPdf.Replace("\n", "");
            texto = texto.Replace("Matricula", "|");
            var textoProf = texto.Split('|');
            string teste = "";
            for (int i = 0; i < textoProf.Length - 1; i++)
            {
                progressoBusca.Maximum = textoProf.Length - 1;
                if (!textoProf[i].Contains(": Nome: ") && !textoProf[i].Contains("Página"))
                {
                    teste = "";
                    teste = textoProf[i].Replace("Nome: ", "|")
                        .Replace("Nome", "|")
                        .Replace("Aposentado", "|")
                        .Replace("Tipo", "|")
                        .Replace("Endereco", "|")
                        .Replace("CEP", "|")
                        .Replace("Bairro", "|")
                        .Replace("Cidade", "|")
                        .Replace(": ", "");
                    var dadosProf = teste.Split('|');
                    if (filtro.Equals("APOSENTADO") && !dadosProf[2].Replace(" ", "").Equals("N")
                        || filtro.Equals("EFETIVO") && dadosProf[2].Replace(" ", "").Equals("N")
                        || filtro.Equals("TODOS"))
                    {
                        prof = new Professor();
                        prof.Matricula = dadosProf[0].Replace(" ", "");
                        var nome = dadosProf[1];
                        if (nome.Substring(0, 1).Equals(" "))
                        {
                            prof.Nome = nome.Substring(1, (nome.Length - 1));
                        }
                        else
                        {
                            prof.Nome = nome;
                        }

                        prof.Situacao = dadosProf[2].Replace(" ", "").Equals("N"); ;
                        prof.Endereco = dadosProf[4];
                        var cep = dadosProf[5].Replace("-", "").Replace(" ", "");
                        if (cep.Length.Equals(8))
                        {
                            prof.CEP = string.Format("{0}.{1}-{2}", cep.Substring(0, 2), cep.Substring(2, 3), cep.Substring(5, 3));
                        }
                        else
                        {
                            prof.CEP = cep;
                        }
                        professores.Add(prof);
                    }


                }

                if (textoProf[i].Contains(": Nome: ") && !textoProf[i].Contains("Página"))
                {
                    teste = "";
                    teste = textoProf[i].Replace(": Nome: Aposentado: ", "")
                        .Replace("Tipo : Estadual", "|")
                        .Replace("Endereco", "|")
                        .Replace("CEP", "|")
                        .Replace("Bairro", "|")
                        .Replace("Cidade", "|")
                        .Replace(": ", "");
                    var dadosProf = teste.Split('|');
                    var situacao = dadosProf[0].Replace(" ", "");
                    var matriculaEnome = dadosProf[1].Split(' ');
                    if (filtro.Equals("APOSENTADO") && !dadosProf[0].Replace(" ", "").Equals("N")
                        || filtro.Equals("EFETIVO") && dadosProf[0].Replace(" ", "").Equals("N")
                        || filtro.Equals("TODOS"))
                    {
                        prof = new Professor();
                        prof.Matricula = matriculaEnome[0].Replace(" ", "");
                        var nome = dadosProf[1].Replace(matriculaEnome[0] + " ", "");
                        if (nome.Substring(0, 1).Equals(" "))
                        {
                            prof.Nome = nome.Substring(1, (nome.Length - 1));
                        }
                        else
                        {
                            prof.Nome = nome;
                        }
                        prof.Situacao = dadosProf[0].Replace(" ", "").Equals("N");
                        prof.Endereco = dadosProf[2];
                        var cep = dadosProf[3].Replace("-", "").Replace(" ", "");
                        if (cep.Length.Equals(8))
                        {
                            prof.CEP = string.Format("{0}.{1}-{2}", cep.Substring(0, 2), cep.Substring(2, 3), cep.Substring(5, 3));
                        }
                        else
                        {
                            prof.CEP = cep;
                        }
                        professores.Add(prof);
                    }

                }
                progressoBusca.Value = i;
            }
            return professores.OrderBy(x => x.Nome).ToList();
           

        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar expForm = new Exportar(this);
            expForm.Show();
        }
    }
}
