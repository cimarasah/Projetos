using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etike
{
    public partial class Exportar : MetroForm
    {
        Etike formEtike;

        public Exportar(Etike etike)
        {
            InitializeComponent();
            formEtike = etike;
            rbtnExcel.Checked = true;
            if (!chkValido.Checked && !chkInvalido.Checked)
            {
                btnImprimir.Enabled = false;
            }
        }
        PrintDocument pda = new PrintDocument();
        int qtdProfessor = 0;
        int qtdProf = 0;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            loadExportar.Value = 0;
            qtdProfessor = 0;
            qtdProf = 0;

            if (rbtnExcel.Checked)
            {


                //Todos
                if (chkValido.Checked && chkInvalido.Checked)
                {
                    if (formEtike.dgrProfessorValido.RowCount > 0 && formEtike.dgrProfessorInvalido.RowCount > 0)
                    {
                        loadExportar.Maximum = formEtike.dgrProfessorValido.RowCount + formEtike.dgrProfessorInvalido.RowCount;
                        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                        try
                        {

                            XcelApp.Application.Workbooks.Add(Type.Missing);
                            for (int i = 1; i < formEtike.dgrProfessorValido.Columns.Count + 1; i++)
                            {
                                XcelApp.Cells[1, i] = formEtike.dgrProfessorValido.Columns[i - 1].HeaderText;
                            }
                            //
                            for (int i = 0; i < formEtike.dgrProfessorValido.Rows.Count - 1 + formEtike.dgrProfessorInvalido.Rows.Count - 1; i++)
                            {
                                if (i < formEtike.dgrProfessorInvalido.Rows.Count - 1)
                                {
                                    for (int j = 0; j < formEtike.dgrProfessorInvalido.Columns.Count; j++)
                                    {
                                        XcelApp.Cells[i + 2, j + 1] = formEtike.dgrProfessorInvalido.Rows[i].Cells[j].Value.ToString();
                                    }

                                }
                                else
                                {
                                    for (int j = 0; j < formEtike.dgrProfessorValido.Columns.Count; j++)
                                    {
                                        XcelApp.Cells[i + 2, j + 1] = formEtike.dgrProfessorValido.Rows[i - formEtike.dgrProfessorInvalido.Rows.Count + 1].Cells[j].Value.ToString();
                                    }
                                }
                                loadExportar.Value += 1;
                            }

                            XcelApp.Columns.AutoFit();
                            //
                            XcelApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
                            XcelApp.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro : " + ex.Message);
                            XcelApp.Quit();
                        }
                    }
                }

                //imprimir Validos
                else if (chkValido.Checked)
                {
                    if (formEtike.dgrProfessorValido.Rows.Count > 0)
                    {
                        loadExportar.Maximum = formEtike.dgrProfessorValido.RowCount;
                        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                        try
                        {
                            XcelApp.Application.Workbooks.Add(Type.Missing);
                            for (int i = 1; i < formEtike.dgrProfessorValido.Columns.Count + 1; i++)
                            {
                                XcelApp.Cells[1, i] = formEtike.dgrProfessorValido.Columns[i - 1].HeaderText;
                            }
                            //
                            for (int i = 0; i < formEtike.dgrProfessorValido.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < formEtike.dgrProfessorValido.Columns.Count; j++)
                                {
                                    XcelApp.Cells[i + 2, j + 1] = formEtike.dgrProfessorValido.Rows[i].Cells[j].Value.ToString();
                                }
                                loadExportar.Value += 1;
                            }
                            //
                            XcelApp.Columns.AutoFit();
                            //
                            XcelApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
                            XcelApp.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro : " + ex.Message);
                            XcelApp.Quit();
                        }
                    }
                }
                else
                { //imprimir invalidos
                    if (formEtike.dgrProfessorInvalido.Rows.Count > 0)
                    {
                        loadExportar.Maximum = formEtike.dgrProfessorInvalido.RowCount;
                        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                        try
                        {
                            XcelApp.Application.Workbooks.Add(Type.Missing);
                            for (int i = 1; i < formEtike.dgrProfessorInvalido.Columns.Count + 1; i++)
                            {
                                XcelApp.Cells[1, i] = formEtike.dgrProfessorInvalido.Columns[i - 1].HeaderText;
                            }
                            //
                            for (int i = 0; i < formEtike.dgrProfessorInvalido.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < formEtike.dgrProfessorInvalido.Columns.Count; j++)
                                {
                                    XcelApp.Cells[i + 2, j + 1] = formEtike.dgrProfessorInvalido.Rows[i].Cells[j].Value.ToString();
                                }
                                loadExportar.Value += 1;
                            }
                            //
                            XcelApp.Columns.AutoFit();
                            //
                            XcelApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
                            XcelApp.Visible = true;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro : " + ex.Message);
                            XcelApp.Quit();
                        }
                    }
                }

            }
            else
            {
                //define os objetos printdocument e os eventos associados


                //IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
                pda.PrintPage += new PrintPageEventHandler(this.pdaRelatorios_PrintPage);
                //pda.BeginPrint += new PrintEventHandler(this.Begin_Print_Aniv_Filtro);
                //pda.EndPrint += new PrintEventHandler(this.End_Print_Aniv_Filtro);

                //define o objeto para visualizar a impressao
                PrintPreviewDialog objPrintPreview = new PrintPreviewDialog();
                try
                {
                    //define o formulário como maximizado e com Zoom
                    var _with1 = objPrintPreview;
                    _with1.Document = pda;
                    _with1.WindowState = FormWindowState.Maximized;
                    _with1.PrintPreviewControl.Zoom = 1;
                    _with1.Text = "Professores";


                    PrintDialog dialogo = new PrintDialog();
                    dialogo.Document = pda;
                    pda.Print();
                   // _with1.ShowDialog();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            this.Close();

        }

        System.Object document=null;
        private void pdaRelatorios_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Variaveis das linhas



            float linesPerPage = 0;
            int qtdPg =1;
            Font printFont = this.Font;

            //    string line = null;
            float x = 10.0f; //posicçao horizontal inicial da etiqueta em mm
            float y = 0f;//posicçao vertical inicial da etiqueta em mm
           
                float largura = 89f;//largura da etiqueta em mm
            float altura = 23f;//altura da etiqueta em mm


            int count = 0;
            int countetq = 0;//contador de etiquetas



            SolidBrush myBrush = new SolidBrush(Color.White);
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            //Variaveis das fontes
            Font FonteNegrito = default(Font);
            Font FonteTitulo = default(Font);
            Font FonteSubTitulo = default(Font);
            Font FonteRodape = default(Font);
            Font FonteNormal = default(Font);

            //define efeitos em fontes
            FonteNegrito = new Font("SansSerif", 9, FontStyle.Bold);
            FonteTitulo = new Font("SansSerif", 15, FontStyle.Bold);
            FonteSubTitulo = new Font("SansSerif", 12, FontStyle.Bold);
            FonteRodape = new Font("SansSerif", 8);
            FonteNormal = new Font("SansSerif", 9);
            string matricula = "";
            string nome = "";
            string endereco = "";
            string cep = "";


            //define quantas linhas por pagina

            //Aqui sao lidos os dados
            //Etiquetas para todos
            if (chkValido.Checked && chkInvalido.Checked)
            {
                if (!((formEtike.dgrProfessorValido.Rows.Count - 1 + formEtike.dgrProfessorInvalido.Rows.Count - 1).Equals(qtdProf)))
                {
                    document = sender;
                    for (int k = 0; k < formEtike.dgrProfessorValido.Rows.Count - 1 + formEtike.dgrProfessorInvalido.Rows.Count - 1; k++)
                    {
                        k = qtdProf;
                        if (k < formEtike.dgrProfessorInvalido.Rows.Count - 1)
                        {
                            matricula = formEtike.dgrProfessorInvalido.Rows[k].Cells[0].Value.ToString();
                            nome = formEtike.dgrProfessorInvalido.Rows[k].Cells[1].Value.ToString().Count() <= 32 ?
                                formEtike.dgrProfessorInvalido.Rows[k].Cells[1].Value.ToString() :
                                formEtike.dgrProfessorInvalido.Rows[k].Cells[1].Value.ToString().Substring(0, 32) + ".";

                            endereco = "";
                            int qtdCaractEndereco = formEtike.dgrProfessorInvalido.Rows[k].Cells[2].Value.ToString().Count();
                            if (qtdCaractEndereco <= 35)
                            {
                                endereco = formEtike.dgrProfessorInvalido.Rows[k].Cells[2].Value.ToString();
                                for (int j = 0; j < (35 - qtdCaractEndereco); j++)
                                {
                                    endereco += " ";
                                }

                            }
                            else
                            {
                                endereco = formEtike.dgrProfessorInvalido.Rows[k].Cells[2].Value.ToString().Substring(0, 35) + ".";
                            }

                            cep = formEtike.dgrProfessorInvalido.Rows[k].Cells[3].Value.ToString();

                        }
                        else
                        {
                            matricula = formEtike.dgrProfessorValido.Rows[k - formEtike.dgrProfessorInvalido.Rows.Count + 1].Cells[0].Value.ToString();
                            nome = formEtike.dgrProfessorValido.Rows[k - formEtike.dgrProfessorInvalido.Rows.Count + 1].Cells[1].Value.ToString().Count() <= 32 ?
                                formEtike.dgrProfessorValido.Rows[k - formEtike.dgrProfessorInvalido.Rows.Count + 1].Cells[1].Value.ToString() :
                                formEtike.dgrProfessorValido.Rows[k - formEtike.dgrProfessorInvalido.Rows.Count + 1].Cells[1].Value.ToString().Substring(0, 32) + ".";


                            int qtdCaractEndereco = formEtike.dgrProfessorValido.Rows[k - formEtike.dgrProfessorInvalido.Rows.Count + 1].Cells[2].Value.ToString().Count();
                            if (qtdCaractEndereco <= 35)
                            {
                                endereco = formEtike.dgrProfessorValido.Rows[k - formEtike.dgrProfessorInvalido.Rows.Count + 1].Cells[2].Value.ToString();
                                for (int j = 0; j < (35 - qtdCaractEndereco); j++)
                                {
                                    endereco += " ";
                                }

                            }
                            else
                            {
                                endereco = formEtike.dgrProfessorValido.Rows[k - formEtike.dgrProfessorInvalido.Rows.Count + 1].Cells[2].Value.ToString().Substring(0, 35) + ".";
                            }
                            cep = formEtike.dgrProfessorValido.Rows[k - formEtike.dgrProfessorInvalido.Rows.Count + 1].Cells[3].Value.ToString();
                        }
                        //
                        //defini o tamanho do retangulo
                        e.Graphics.DrawRectangle(new Pen(myBrush), x, y, largura, altura);


                        //imprime os dados relativo ao codigo , nome do eleitor e endereço

                        e.Graphics.DrawString(" " + matricula + "  " + nome, FonteNormal, Brushes.Black, x, y + 6, new StringFormat());
                        e.Graphics.DrawString(" " + endereco + "  " + cep, FonteNormal, Brushes.Black, x, y + 12, new StringFormat());

                        //soma +  2.54 cm vericalmente
                        y += 25.4f;
                        count++;
                        countetq++;
                        // a cada 10 linhas adicicone uma coluna
                        if (count == 12)
                        {
                            x +=10f; //adicione 6.98cm na posicao horiz.
                            y = 40f; //volta para o topo da pagina
                            count = 0; // contador de linhas volta a ser zero}

                        }
                        qtdProf = k + 1;
                        //verifica se continua imprimindo
                        if (countetq == 12) //se tiver mais do que 30 etiquetas na pagina, adicione uma nova pagina
                        {
                            e.HasMorePages = true;
                            return;
                        }
                        else
                            e.HasMorePages = false;
                    }
                }

            }
            //Etiquetas para válidos
            else if (chkValido.Checked)
            {
                if (!((formEtike.dgrProfessorValido.Rows.Count - 1).Equals(qtdProfessor)))
                {
                    for (int i = 0; i < formEtike.dgrProfessorValido.Rows.Count - 1; i++)
                    {
                        i = qtdProfessor;

                        //obtem os valores do datareader
                        matricula = formEtike.dgrProfessorValido.Rows[i].Cells[0].Value.ToString();
                        nome = formEtike.dgrProfessorValido.Rows[i].Cells[1].Value.ToString().Count() <= 32 ?
                           formEtike.dgrProfessorValido.Rows[i].Cells[1].Value.ToString() :
                           formEtike.dgrProfessorValido.Rows[i].Cells[1].Value.ToString().Substring(0, 32) + ".";

                        endereco = "";
                        int qtdCaractEndereco = formEtike.dgrProfessorValido.Rows[i].Cells[2].Value.ToString().Count();
                        if (qtdCaractEndereco <= 35)
                        {
                            endereco = formEtike.dgrProfessorValido.Rows[i].Cells[2].Value.ToString();
                            for (int j = 0; j < (35 - qtdCaractEndereco); j++)
                            {
                                endereco += " ";
                            }

                        }
                        else
                        {
                            endereco = formEtike.dgrProfessorValido.Rows[i].Cells[2].Value.ToString().Substring(0, 35) + ".";
                        }
                        cep = formEtike.dgrProfessorValido.Rows[i].Cells[3].Value.ToString();
                        qtdProfessor = i + 1;
                        if (i == 0)
                        {
                            y = -8;
                        }
                        //inicia a impressao

                        //defini o tamanho do retangulo
                        e.Graphics.DrawRectangle(new Pen(myBrush), x, y, largura, altura);


                        //imprime os dados relativo ao codigo , nome do eleitor e endereço

                        e.Graphics.DrawString(" " + matricula + "  " + nome, FonteNormal, Brushes.Black, x, y + 7, new StringFormat());
                        e.Graphics.DrawString(" " + endereco + "  " + cep, FonteNormal, Brushes.Black, x, y + 14, new StringFormat());

                        //soma +  2.54 cm vericalmente
                        y += 25.4f;
                        count++;
                        countetq++;
                        // a cada 10 linhas adicicone uma coluna
                        if (count == 12)
                        {
                            x += 10f; //adicione 6.98cm na posicao horiz.
                            y = 30f; //volta para o topo da pagina
                            count = 0; // contador de linhas volta a ser zero}

                        }

                        //verifica se continua imprimindo
                        if (countetq == 12) //se tiver mais do que 30 etiquetas na pagina, adicione uma nova pagina
                        {
                            e.HasMorePages = true;
                            return;
                        }
                        else
                            e.HasMorePages = false;
                    }//fim do laço drDados.Read()
                }

            }
            //Etiquetas para inválidos
            else
            {
                if (!((formEtike.dgrProfessorInvalido.Rows.Count - 1).Equals(qtdProfessor)))
                //{
                    {
                        for (int i = 0; i < formEtike.dgrProfessorInvalido.Rows.Count - 1; i++)
                        {


                            i = qtdProfessor;
                            //obtem os valores do datareader
                            matricula = formEtike.dgrProfessorInvalido.Rows[i].Cells[0].Value.ToString();
                            nome = formEtike.dgrProfessorInvalido.Rows[i].Cells[1].Value.ToString().Count() <= 32 ?
                                formEtike.dgrProfessorInvalido.Rows[i].Cells[1].Value.ToString() :
                                formEtike.dgrProfessorInvalido.Rows[i].Cells[1].Value.ToString().Substring(0, 32) + ".";

                            endereco = "";
                            int qtdCaractEndereco = formEtike.dgrProfessorInvalido.Rows[i].Cells[2].Value.ToString().Count();
                            if (qtdCaractEndereco <= 35)
                            {
                                endereco = formEtike.dgrProfessorInvalido.Rows[i].Cells[2].Value.ToString();
                                for (int j = 0; j < (35 - qtdCaractEndereco); j++)
                                {
                                    endereco += " ";
                                }

                            }
                            else
                            {
                                endereco = formEtike.dgrProfessorInvalido.Rows[i].Cells[2].Value.ToString().Substring(0, 35) + ".";
                            }

                            cep = formEtike.dgrProfessorInvalido.Rows[i].Cells[3].Value.ToString();
                            qtdProfessor = i + 1;

                            //inicia a impressao

                            //defini o tamanho do retangulo
                            e.Graphics.DrawRectangle(new Pen(myBrush), x, y, largura, altura);


                            //imprime os dados relativo ao codigo , nome do eleitor e endereço

                            e.Graphics.DrawString(" " + matricula + "  " + nome, FonteNormal, Brushes.Black, x, y + 5, new StringFormat());
                            e.Graphics.DrawString(" " + endereco + "  " + cep, FonteNormal, Brushes.Black, x, y + 10, new StringFormat());

                            //soma +  2.54 cm vericalmente
                            y += 24.4f;
                            count++;
                            countetq++;
                            // a cada 10 linhas adicicone uma coluna
                            if (count == 12)
                            {
                                x += 92.8f; //adicione 6.98cm na posicao horiz.
                                y = 11.7f; //volta para o topo da pagina
                                count = 0; // contador de linhas volta a ser zero}

                            }

                            //verifica se continua imprimindo
                            if (countetq == 12) //se tiver mais do que 30 etiquetas na pagina, adicione uma nova pagina
                            {
                                e.HasMorePages = true;
                                return;
                            }
                            else
                                e.HasMorePages = false;
                        }
                    }
                //}

            }
        }


        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void chkValido_Click(object sender, EventArgs e)
        {
            if (!chkValido.Checked && !chkInvalido.Checked)
            {
                btnImprimir.Enabled = false;
            }
            else
            {
                btnImprimir.Enabled = true;
            }
        }

        private void chkInvalido_Click(object sender, EventArgs e)
        {
            if (!chkValido.Checked && !chkInvalido.Checked)
            {
                btnImprimir.Enabled = false;
            }
            else
            {
                btnImprimir.Enabled = true;
            }
        }


    }

}
