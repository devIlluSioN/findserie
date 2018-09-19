using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FindSerie
{
    class Fonction
    {

        public static string OnlyFileName(string filePath)
        {
            ///Retourne uniquement le nom du fichier d'un chemin///
            string[] tmp = filePath.Split('\\');
            return (tmp[tmp.Length - 1]);
        }

        public static string OnlyExtention(string filepath)
        {
            char[] c = filepath.ToCharArray();
            char[] cextention = new char[4]; ;
            int y = 0;
            for(int i = c.Length - 4; i < c.Length;i++)
            {
                cextention[y] = c[i];
                y++;
            }
            string extention = new string(cextention);
            extention = extention.TrimEnd('\0');
            return extention;
        }

        public static string OnlyDirectoryPath(string filepath)
        {
            int i = 0;
            string OnlyDirectory = "";
            string[] tmp = filepath.Split('\\');
            for (i = 0; i < tmp.Length - 1; i++)
            {
                OnlyDirectory += tmp[i] + '\\';
            }
            return OnlyDirectory;
        }

        public static bool IsNumeric(char c)
        {
            int output;
            string s = c.ToString();

            return Int32.TryParse(s, out output);
        }

        public static string RemoveBetween(string s, char begin, char end)
        {
            Regex regex = new Regex(string.Format("\\{0}.*?\\{1}", begin, end));
            return regex.Replace(s, string.Empty);
        }

        public static string pathCreator(string path)
        {
            Uri MyPath = new Uri(path);
            string newpath = "";
            if (MyPath.IsUnc)
            {
                newpath = "\\\\?\\UNC\\" + path.Substring(2);
                return newpath;
            }
            else
            {
                newpath = "\\\\?\\" + path;
                return newpath;
            }
        }
    }
}
