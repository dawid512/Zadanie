using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace zadanie
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public static string filename { get; set; }
        public string fraza;
        public Window1(string file)
        {
            InitializeComponent();
            filename = file;
            textBox1.Text = filename;




            







        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Start start = new Start();
            start.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Towar> values = File.ReadAllLines(filename)
                                            .Select(v => Towar.FromCsv(v))
                                            .ToList();

            try
            {
                var xEle = new XElement("Plik",
                    new XElement("Towary",
                            from T in values
                            orderby T.Nazwa ascending
                            select new XElement("Towar",
                                        
                                           new XElement("Nazwa", T.Nazwa),
                                           new XElement("Cena", T.Cena),
                                           new XElement("Opis", 

                                           new XElement("A", T.Opis.A),
                                           new XElement("B", T.Opis.B))
                                       )));

                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

                Nullable<bool> result = dlg.ShowDialog();

                if (result == true)
                {
                    string filename = dlg.FileName;

                    xEle.Save(filename+".xml");
                    MessageBox.Show("Converted to XML");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //button do tabeli

            fraza = slowo_szukaj.Text;

            List<Towar> values = File.ReadAllLines(filename)
                                            .Select(v => Towar.FromCsv(v))
                                            .ToList();
            var result = values.Where(x => x.Opis.A.Contains(fraza) || x.Opis.B.Contains(fraza));

            var resultalternative = values.Count(x => x.Opis.A.Contains(fraza) || x.Opis.B.Contains(fraza));

            if ( resultalternative !=0 )
            {
                GetList.ItemsSource = result;
            }
            else
            {
                MessageBox.Show("Wpisałeś złą wartość. \nPamiętaj o dużych i małych znakach!");
            }
           


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            List<Towar> values = File.ReadAllLines(filename)
                                            .Select(v => Towar.FromCsv(v))
                                            .ToList();
            string txtBoxValue = ograniczenie.Text;
            decimal ogarniczenieWartosc;
            bool parsedOk = decimal.TryParse(txtBoxValue, out ogarniczenieWartosc);

            
            try
            {
                var xEle = new XElement("Plik",
                    new XElement("Towary",
                            from T in values
                            orderby T.Cena descending
                            where T.Cena > ogarniczenieWartosc
                            select new XElement("Towar",

                                           new XElement("Nazwa", T.Nazwa),
                                           new XElement("Cena", T.Cena),
                                           new XElement("Opis",

                                           new XElement("A", T.Opis.A),
                                           new XElement("B", T.Opis.B)
                                           )
                                       )));

                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

                Nullable<bool> result = dlg.ShowDialog();

                if (result == true)
                {
                    string filename = dlg.FileName;

                    xEle.Save(filename + ".xml");
                    MessageBox.Show("Converted to XML");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
