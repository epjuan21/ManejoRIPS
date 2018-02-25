using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using ManejoRIPS.ManejoArchivos;

namespace ManejoRIPS
{
    /// <summary>
    /// Lógica de interacción para Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        string dirPath;
        CArchivos oUS = new CArchivos();
        CArchivos oAC = new CArchivos();
        CArchivos oAM = new CArchivos();
        CArchivos oAD = new CArchivos();
        CArchivos oCT = new CArchivos();
        CArchivos oAF = new CArchivos();
        CArchivos oAP = new CArchivos();
        CArchivos oAU = new CArchivos();
        CArchivos oAT = new CArchivos();
        CArchivos oAN = new CArchivos();
        CArchivos oAH = new CArchivos();

        private void btnRuta_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                dirPath = folder.SelectedPath;

                txtFolder.Text = dirPath;

                txtLineasUS.Text = oUS.Lineas(dirPath, "*US*");
                txtNomUS.Text = oUS.NombreArchivo(dirPath, "*US*");

                txtLineasAC.Text = oAC.Lineas(dirPath, "*AC*");
                txtNomAC.Text = oAC.NombreArchivo(dirPath, "*AC*");

                txtLineasAM.Text = oAM.Lineas(dirPath, "*AM*");
                txtNomAM.Text = oAM.NombreArchivo(dirPath, "*AM*");

                txtLineasAD.Text = oAD.Lineas(dirPath, "*AD*");
                txtNomAD.Text = oAD.NombreArchivo(dirPath, "*AD*");

                txtLineasCT.Text = oCT.Lineas(dirPath, "*CT*");
                txtNomCT.Text = oCT.NombreArchivo(dirPath, "*CT*");

                txtLineasAF.Text = oAF.Lineas(dirPath, "*AF*");
                txtNomAF.Text = oAF.NombreArchivo(dirPath, "*AF*");

                txtLineasAP.Text = oAP.Lineas(dirPath, "*AP*");
                txtNomAP.Text = oAP.NombreArchivo(dirPath, "*AP*");

                txtLineasAU.Text = oAU.Lineas(dirPath, "*AU*");
                txtNomAU.Text = oAU.NombreArchivo(dirPath, "*AU*");

                txtLineasAT.Text = oAT.Lineas(dirPath, "*AT*");
                txtNomAT.Text = oAT.NombreArchivo(dirPath, "*AT*");

                txtLineasAN.Text = oAN.Lineas(dirPath, "*AN*");
                txtNomAN.Text = oAN.NombreArchivo(dirPath, "*AN*");

                txtLineasAH.Text = oAH.Lineas(dirPath, "*AH*");
                txtNomAH.Text = oAH.NombreArchivo(dirPath, "*AH*");
            }

        }
    }
}
