using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Fonction;

namespace FindSerie
{
    class Code
    {
        public static string[] tabepisodeserie;

        public static string[] tabepisodeserierename;

        public static bool isSerie(string namefile)
        {
            char[] c = namefile.ToCharArray();
            string extention = Fonction.OnlyExtention(namefile);
            int i = 6;
            if (c[0] == '.' && c[1] == '_')
                return false;
            if (extention == ".mkv" || extention == ".avi" || extention == ".mp4")
            {
                while (i < c.Length)
                {
                    //if (Fonction.IsNumeric(c[i]) && ((c[i - 5] == (char)83 || c[i - 5] == (char)115) && (c[i - 2] == (char)69 || c[i - 2] == (char)101)))
                    if ((i > 6) && Fonction.IsNumeric(c[i]) && Fonction.IsNumeric(c[i-1]) && Fonction.IsNumeric(c[i-3]) && Fonction.IsNumeric(c[i-4]) && ((c[i - 5] == (char)83 || c[i - 5] == (char)115) && (c[i - 2] == (char)69 || c[i - 2] == (char)101)))
                    {
                        return true;
                    }
                    i++;
                }
                return false;
            }
            else
                return false;

        }

        public static string nameserie(string namefile)
        {
            ///Trouve le nom de la serie apres transformation///
            char[] c = namefile.ToCharArray();
            char[] newc = new char[c.Length];
            string result;
            int i = 0;
            while(i < c.Length)
            {
                if ((i >= 6) && Fonction.IsNumeric(c[i+2]) && Fonction.IsNumeric(c[i + 3]) && Fonction.IsNumeric(c[i + 5]) && Fonction.IsNumeric(c[i + 6]) && ((c[i + 1] == (char)83 || c[i + 1] == (char)115) && (c[i + 4] == (char)69 || c[i + 4] == (char)101)))
                {
                    result = new string(newc);
                    result = result.TrimEnd('\0');
                    return result;
                }
                newc[i] = c[i];
                i++;
            }
            result = new string(newc);
            result = result.TrimEnd('\0');
            return result;
        }

        public static int numberofserie(string[] tabseriefiles)
        {
            string currentnames = tabseriefiles[0];
            int number = 0;

            foreach (string file in tabseriefiles)
            {
                if (file != currentnames)
                {
                    number++;
                    currentnames = file;
                }
            }
            return number;
        }

        public static void remplirlisteSerie(string[] tab)
        {
            string tmp = Code.nameserie(Code.RenameSerie(Fonction.OnlyFileName(tab[0])));
            List<string> MyListSerie = new List<string>();
            Form1.cpy_cb_Serie.Items.Add("-------------------");
            Form1.cpy_cb_Serie.SelectedIndex = 0;
            Form1.cpy_cb_Serie.Items.Add(tmp);
            foreach (string filename in tab)
            {
                if (Code.nameserie(Code.RenameSerie(Fonction.OnlyFileName(filename))) != tmp)
                {
                    tmp = Code.nameserie(Code.RenameSerie(Fonction.OnlyFileName(filename)));
                    MyListSerie.Add(tmp);
                }
            }
            string[] MyTabSerie = new string[MyListSerie.Count];
            MyTabSerie = MyListSerie.Distinct().ToArray();
            foreach(string serieName in MyTabSerie)
            {
                Form1.cpy_cb_Serie.Items.Add(serieName);
            }
        }

        public static string RenameSerie(string oldname)
        {
            oldname = Fonction.RemoveBetween(oldname, '[', ']'); //Supprime " [*] "
            string newname = "";
            char[] c = oldname.ToCharArray();
            int i = 0; //1
            int y = 1;
            int ybis = 0;
            int tablength = c.Length;
            char[] newc = new char[tablength];

            while (c[i] == ' ' || c[i] == '.' || c[i] == '-')
            {
                i++;
            }
            if (c[i] >= 'a' && c[i] <= 'z')
            {
                newc[i] = (char)(c[i] - 32);
                i++;
            }
            else
            {
                newc[0] = c[i];
                i++;
            }
            while (i <= tablength - 5)
            {

                if (c[i] == 46) //point en espace
                    c[i] = (char)32;
                if ((c[i] >= 'a' && c[i] <= 'z') && (c[i - 1] == 32 || c[i - 1] == 46))//Maj des mots
                    c[i] = (char)(c[i] - 32);
                if ((i > 6) && Fonction.IsNumeric(c[i]) && Fonction.IsNumeric(c[i - 1]) && Fonction.IsNumeric(c[i - 3]) && Fonction.IsNumeric(c[i - 4]) && ((c[i - 5] == (char)83 || c[i - 5] == (char)115) && (c[i - 2] == (char)69 || c[i - 2] == (char)101)))
                {
                    if (c[i - 2] == (char)101 || c[i - 5] == (char)115)
                    {
                        newc[i - 2] = 'E';
                        newc[i - 5] = 'S';

                    }
                    newc[y] = c[i];
                    i = tablength - 4; //place le curseur sur le point de .mkv
                    y++;
                    while (i < tablength)
                    {
                        newc[y] = c[i];
                        i++;
                        y++;
                    }
                    break;
                }
                ybis = y + 1;
                newc[y] = c[i];
                y++;
                i++;
            }

            newname = new string(newc);
            newname = newname.TrimEnd('\0');
            return newname;
        }

        public static string addTitleToEpisode(string namefile,string title = "",int idSerie = -1)
        {
            if(title == "")
            {
                if(idSerie == -1)
                {
                    idSerie = MovieDB.getIDofSerie(Code.nameserie(namefile));
                }
                int currentSeason = int.Parse(Code.numberSeason(namefile));
                int currentEpisode = int.Parse(Code.numberEpisode(namefile));
                title = MovieDB.getNameOfTvEpisode(idSerie, currentSeason, currentEpisode);
            }
            namefile = namefile.Insert(namefile.Length - 4, " " + title);
            return (namefile);
        }

        public static string numberSeason(string namefile)
        {
            ///Trouve le numero de la saison apres renameserie///
            char[] c = namefile.ToCharArray();
            char[] tmp = new char[2];
            int i = 0;
            bool find = false;
            while (i < c.Length)
            {
                if ((i > 6) && Fonction.IsNumeric(c[i]) && Fonction.IsNumeric(c[i - 1]) && Fonction.IsNumeric(c[i - 3]) && Fonction.IsNumeric(c[i - 4]) && ((c[i - 5] == (char)83 || c[i - 5] == (char)115) && (c[i - 2] == (char)69 || c[i - 2] == (char)101)))
                {
                    tmp[0] = c[i - 4];
                    tmp[1] = c[i - 3];
                    find = true;
                    break;
                }
                i++;
            }
            if (find == false)
            {
                return ("99");
            }
            string result = new string(tmp);
            result = result.TrimEnd('\0');
            return result;
        }

        public static bool isBlackListed(string line)
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(@"D:\Mes Fichiers\Documents\RenameSerie\BlackList.txt");
                string readline;
                bool a = false;
                //Read the first line of text
                readline = sr.ReadLine();

                while (readline != null)
                {
                    if (readline == line)
                    {
                        a = true;
                        break;
                    }
                    readline = sr.ReadLine();
                }
                //close the file
                sr.Close();

                return a;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return (false);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }

        public static string numberEpisode(string namefile)
        {
            ///Trouve le numero de l'episode apres renameserie///
            char[] c = namefile.ToCharArray();
            char[] tmp = new char[2];
            int i = 0;
            bool find = false;
            while (i < c.Length)
            {
                if ((i > 6) && Fonction.IsNumeric(c[i]) && Fonction.IsNumeric(c[i - 1]) && Fonction.IsNumeric(c[i - 3]) && Fonction.IsNumeric(c[i - 4]) && ((c[i - 5] == (char)83 || c[i - 5] == (char)115) && (c[i - 2] == (char)69 || c[i - 2] == (char)101)))
                {
                    tmp[0] = c[i - 1];
                    tmp[1] = c[i];
                    find = true;
                    break;
                }
                i++;
            }
            if (find == false)
            {
                return ("99");
            }
            string result = new string(tmp);
            result = result.TrimEnd('\0');
            return result;
        }

        public static string[] getFinalEpisodes(string[] pathOFfiles)
        {
            int i = 0;
            List<string> pathFinalEpisode = new List<string>();
            string currentserie = nameserie(Fonction.OnlyFileName(pathOFfiles[0]));
            string currentseason = numberSeason(Fonction.OnlyFileName(pathOFfiles[0]));
            string currentepisode = numberEpisode(Fonction.OnlyFileName(pathOFfiles[0]));
            int maxcurrentepisode = 0;
            int indexmaxepisode = 0;
            while(i < pathOFfiles.Length)
            {
                if (currentserie != nameserie(Fonction.OnlyFileName(pathOFfiles[i])) || currentseason != numberSeason(Fonction.OnlyFileName(pathOFfiles[i])))
                {
                    string FileNameOfCurrentSerie = Fonction.OnlyFileName(pathOFfiles[indexmaxepisode]);
                    int MyNbMaxEpisode = int.Parse(numberEpisode(FileNameOfCurrentSerie));
                    int MovieDBMaxEpisode = MovieDB.getFinalNumberEpispdeTV(nameserie(FileNameOfCurrentSerie), int.Parse(numberSeason(FileNameOfCurrentSerie)));
                    if (MyNbMaxEpisode == MovieDBMaxEpisode)
                    {
                        pathFinalEpisode.Add(pathOFfiles[indexmaxepisode]);
                    }
                    maxcurrentepisode = 0;
                    currentserie = nameserie(Fonction.OnlyFileName(pathOFfiles[i]));
                    currentseason = numberSeason(Fonction.OnlyFileName(pathOFfiles[i]));
                }
                else if (maxcurrentepisode < int.Parse(numberEpisode(Fonction.OnlyFileName(pathOFfiles[i]))))
                {
                    maxcurrentepisode = int.Parse(numberEpisode(Fonction.OnlyFileName(pathOFfiles[i])));
                    indexmaxepisode = i;
                }
                i++;
            }
            return pathFinalEpisode.ToArray();
        }

        public static string[] getFinalEpisodesdos(string[] pathOFfiles)
        {
            int i = 0;
            List<string> pathFinalEpisode = new List<string>();
            string currentserie = nameserie(Fonction.OnlyFileName(pathOFfiles[0]));
            string currentseason = numberSeason(Fonction.OnlyFileName(pathOFfiles[0]));
            string currentepisode = numberEpisode(Fonction.OnlyFileName(pathOFfiles[0]));
            int maxcurrentepisode = 0;
            int indexmaxepisode = 0;

            while (i < pathOFfiles.Length)
            {
                if (currentserie != nameserie(Fonction.OnlyFileName(pathOFfiles[i])) || currentseason != numberSeason(Fonction.OnlyFileName(pathOFfiles[i])))
                { 
                    pathFinalEpisode.Add(pathOFfiles[indexmaxepisode]);
                    maxcurrentepisode = 0;
                    currentserie = nameserie(Fonction.OnlyFileName(pathOFfiles[i]));
                    currentseason = numberSeason(Fonction.OnlyFileName(pathOFfiles[i]));
                }
                else if (maxcurrentepisode < int.Parse(numberEpisode(Fonction.OnlyFileName(pathOFfiles[i]))))
                {
                    maxcurrentepisode = int.Parse(numberEpisode(Fonction.OnlyFileName(pathOFfiles[i])));
                    indexmaxepisode = i;
                }
                i++;
            }
            return pathFinalEpisode.ToArray();
        }


    }
}
