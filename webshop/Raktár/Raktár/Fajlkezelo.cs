using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Raktár
{
    internal class Fajlkezelo
    {

        public static void PDFMentes(Vevo v, Aru a, Rendeles r)
        {
            PdfDocument document = new PdfDocument();

       
            PdfPage page = document.AddPage();
        
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

        
            XFont font = new XFont("Arial", 20, XFontStyle.Bold, options);

          
            
            gfx.DrawString("Tekerj Kerékpárüzlet Kft.",new XFont("Arial",20,XFontStyle.Bold),XBrushes.Black,30,50);
            gfx.DrawString("1234 Budapest, Mekk Elek utca 7", new XFont("Arial", 15, XFontStyle.Bold), XBrushes.Black, 30, 80);
            gfx.DrawString("Adószám: 1234567-2-13", new XFont("Arial", 15, XFontStyle.Bold), XBrushes.Black, 30, 100);
            gfx.DrawString("SZÁMLA", new XFont("Arial", 15, XFontStyle.Bold), XBrushes.Black, 430, 120);
            gfx.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------------", new XFont("Arial", 15, XFontStyle.Bold), XBrushes.Black, 0, 135);
            gfx.DrawString("Vevő: "+v.Nev, new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 30, 155);
            gfx.DrawString("Cím: "+v.Irsz+" "+v.Helyseg+" "+v.Utca+" "+v.Hsz, new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 30, 175);
            gfx.DrawString("Adószám: " + v.Adoszam, new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 30, 195);

            //--------

            gfx.DrawString("Kiállítás dátuma:", new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 430, 155);
            gfx.DrawString(""+DateTime.Today, new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 430, 175);

            gfx.DrawString("Termék megnevezése", new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 30, 245);
            gfx.DrawString("Menny.", new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 210, 245);
            gfx.DrawString("Egységár.", new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 280, 245);
            gfx.DrawString("Nettó ár.", new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 350, 245);
            gfx.DrawString("Áfa", new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 420, 245);
            gfx.DrawString("Bruttó ár", new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 490, 245);
            gfx.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------------", new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 0, 265);
            gfx.DrawString(a.Nev, new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 30, 285);
            gfx.DrawString(r.Darab.ToString(), new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 210, 285);
            gfx.DrawString(a.Darabar.ToString(), new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 280, 285);
            gfx.DrawString(r.Netto().ToString(), new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 350, 285);
            gfx.DrawString("27%", new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 420, 285);
            gfx.DrawString(r.Osszertek().ToString(), new XFont("Arial", 12, XFontStyle.Bold), XBrushes.Black, 490, 285);


            SaveFileDialog mentes = new SaveFileDialog();
            mentes.Filter = "PDF dokumentum|*.PDF";
            if (mentes.ShowDialog()==DialogResult.OK)
            {
                string filename = mentes.FileName;
                document.Save(filename);
                Process.Start(filename);
            }
           
           
        }

        public static void BeallitasBetolt()
        {
            string[] beallitas = File.ReadAllLines("Beallitas.csv");
            string[] adatok = beallitas[0].Split(';');
            Beallitas.htmlMappa = beallitas[1];
            Beallitas.szerver = adatok[0];
            Beallitas.felh = adatok[1];
            Beallitas.jel = adatok[2];
            Beallitas.db = adatok[3];

        }

        public static void BeallitasMent(string mappahely)
        {
            StreamWriter ment = new StreamWriter("Beallitas.csv", false);
           
            Beallitas.htmlMappa = mappahely;
            ment.WriteLine(Beallitas.szerver + ";" + Beallitas.felh + ";" + Beallitas.jel + ";" + Beallitas.db);
            ment.WriteLine(Beallitas.htmlMappa);
           
            
            ment.Close();

        }

      
    }
}
