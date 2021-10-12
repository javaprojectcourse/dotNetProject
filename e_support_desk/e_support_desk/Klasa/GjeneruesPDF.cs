using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace e_support_desk
{
    class GjeneruesPDF
    {
        private string conn_string;
        private Font font;

        public GjeneruesPDF(string conn_str)
        {
            conn_string = conn_str;
            font = new Font( BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 8, 2, BaseColor.GRAY);
        }

        public void FatureShitje(int id_fature, string fileName)
        {
            try
            {
                DataTable dtbl = MakeDataTable(id_fature);
                ExportDataTableToPdf(dtbl, fileName, "Fature Shitje", id_fature);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RaportCeshtje(int id_ceshtje, string fileName)
        {
            try
            {
                string raporti = GetCeshtjeData(id_ceshtje);
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                Document document = new Document();
                document.SetPageSize(iTextSharp.text.PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();
                //krijojme headerin
                BaseFont bfnt1 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fnt1 = new Font(bfnt1, 16, 1, BaseColor.GRAY);
                Paragraph prgHeading = new Paragraph();
                prgHeading.Alignment = Element.ALIGN_CENTER;
                prgHeading.Add(new Chunk("Raporti i ceshtjes nr." + id_ceshtje, fnt1));
                document.Add(prgHeading);
                //vize ndarese
                Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 0)));
                document.Add(line);
                //rresht bosh
                document.Add(new Chunk("\n", font));
                Paragraph prg_raporti = new Paragraph();
                prg_raporti.Alignment = Element.ALIGN_LEFT;
                prg_raporti.Add(new Chunk(raporti, font));
                document.Add(prg_raporti);

                document.Close();
                writer.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private DataTable MakeDataTable(int id_fature)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conn_string);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select produkti, sasia, cmimi, nentotali from rresht_fature where id_shitje = @id_shitje";
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_shitje", id_fature);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception("Errori ne query"+ex.Message);
            }
        }

        private void ExportDataTableToPdf(DataTable dtbl, string strPdfPth, string strHeader, int id_fature)
        {
            try
            {
                FileStream fs = new FileStream(strPdfPth, FileMode.Create, FileAccess.Write, FileShare.None);
                Document document = new Document();
                document.SetPageSize(iTextSharp.text.PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();
                //headeri i fatures
                BaseFont bfnt1 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fnt1 = new Font(bfnt1, 16, 1, BaseColor.GRAY);
                Paragraph prgHeading = new Paragraph();
                prgHeading.Alignment = Element.ALIGN_CENTER;
                prgHeading.Add(new Chunk(strHeader.ToUpper(), fnt1));
                document.Add(prgHeading);
                //te dhenat e fautres
                Paragraph subHeading = new Paragraph();
                subHeading.Alignment = Element.ALIGN_RIGHT;
                subHeading.Add(new Chunk("Date " + DateTime.Now.ToShortDateString(), font));
                document.Add(subHeading);
                //vize ndarese
                Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 0)));
                document.Add(line);
                //rresht bosh
                document.Add(new Chunk("\n", this.font));
                //shtimi i tabeles
                PdfPTable table = new PdfPTable(dtbl.Columns.Count);
                //table header
                Font fnt_cHeader = new Font(BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 10, 1, BaseColor.WHITE);
                for (int i = 0; i < dtbl.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.BackgroundColor = BaseColor.GRAY;
                    cell.AddElement(new Chunk(dtbl.Columns[i].ColumnName.ToUpper(), fnt_cHeader));
                    table.AddCell(cell);
                }
                //table data
                for (int i = 0; i < dtbl.Rows.Count; i++)
                    for (int j = 0; j < dtbl.Columns.Count; j++)
                        table.AddCell(dtbl.Rows[i][j].ToString());
                document.Add(table);

                //vize ndarese
                document.Add(line);
                //rresht bosh
                document.Add(new Chunk("\n", this.font));

                //shkrimi i totalit
                //leximi i totalit ne db
                string tot = " Shuma: "; 
                try
                {
                    SqlConnection conn = new SqlConnection(conn_string);
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Select vlera from vlere_fature where id_fatura = @id";
                    cmd.Parameters.AddWithValue("@id", id_fature);
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    tot += (string) cmd.ExecuteScalar();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Errori ne query" + ex.Message);
                }
                Paragraph prgTotali = new Paragraph();
                prgTotali.Alignment = Element.ALIGN_RIGHT;
                prgTotali.Add(new Chunk(tot, fnt1));
                document.Add(prgTotali);

                document.Close();
                writer.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ex ne tabele"+ ex.Message);
            }
        }

        private string GetCeshtjeData(int id_ceshtje)
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select raporti from analize_ceshtjesh where id_ceshtje=@id_ceshtje;";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_ceshtje", id_ceshtje);
                try
                {
                    conn.Open();
                    return cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
