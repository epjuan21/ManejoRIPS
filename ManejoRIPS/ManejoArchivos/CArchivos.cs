using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoRIPS.ManejoArchivos
{
    class CArchivos
    {
        private string NumeroLineas;
        private DirectoryInfo Directorio;
        private string Nombre;

        public string ContarLineas(string PathFile)
        {
            if (File.Exists(PathFile))
            {
                using (StreamReader reader = new StreamReader(PathFile, Encoding.GetEncoding("Windows-1252")))
                {
                    NumeroLineas = File.ReadAllLines(PathFile).Length.ToString();
                }
            }
            else
            {
                MessageBox.Show("Archivo no Existe");
            }

            return NumeroLineas;
        }

        /// <summary>
        /// Retorna una Lista de todos los archivos de una carpeta según un criterio
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <param name="searchPattern"></param>
        /// <returns></returns>
        public List<string> ListarArchivos(string directoryPath, string searchPattern)
        {
            Directorio = new DirectoryInfo(directoryPath);

            List<string> files = new List<string>();

            foreach (var file in Directorio.GetFiles(searchPattern, SearchOption.TopDirectoryOnly))
            {

                String nameFile = file.FullName;
                files.Add(nameFile);

            }

            return files;
        }


        // Número de Lineas Segun Archivo
        public string Lineas(string directoryPath, string searchPattern)
        {
            Directorio = new DirectoryInfo(directoryPath);

            foreach (var item in Directorio.GetFiles(searchPattern))
            {
                String nameFile = item.FullName;
                string NumeroLineas = ContarLineas(nameFile);
            }

            return NumeroLineas;
        }

        public string NombreArchivo(string directoryPath, string searchPattern)
        {
            Directorio = new DirectoryInfo(directoryPath);

            foreach (var item in Directorio.GetFiles(searchPattern))
            {
                Nombre = item.Name;
            }

            return Nombre;
        }
    }
}
