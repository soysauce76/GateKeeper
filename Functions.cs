using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameGatekeeper
{
    class Functions
    {



        // find word count of a string
        static public int checkWordCount(String textboxContents)
        {
            int count = 0;
            String[] words = textboxContents.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
            count = words.Length;
            return count;
        }

        // initialize the games ( < gameName, path > ) dictionary with all my main games
        static public Dictionary<String,String> initializeGamesDictionary()
        {
            Dictionary<String, String> GamesDict = new Dictionary<String, String>();
            GamesDict.Add("FreeCell", @"C:\Program Files\Microsoft Games\FreeCell\FreeCell.exe");
            GamesDict.Add("Chess", @"C:\Program Files\Microsoft Games\Chess\Chess.exe");
            GamesDict.Add("Hearts", @"C:\Program Files\Microsoft Games\Hearts\Hearts.exe");
            GamesDict.Add("Mahjong", @"C:\Program Files\Microsoft Games\Mahjong\Mahjong.exe");
            GamesDict.Add("Minesweeper", @"C:\Program Files\Microsoft Games\Minesweeper\Minesweeper.exe");
            GamesDict.Add("PurblePalace", @"C:\Program Files\Microsoft Games\PurblePlace\PurblePalace.exe");
            GamesDict.Add("Solitaire", @"C:\Program Files\Microsoft Games\Solitaire\Solitaire.exe");
            GamesDict.Add("Spider Solitaire", @"C:\Program Files\Microsoft Games\SpiderSolitaire\SpiderSolitaire.exe");
            return GamesDict;
        }


        static public String getFinalFilePath(String[] tokens)
        {
            String fileName = "GateKeeper_" + String.Join("_", tokens) + ".rtf";
            String folder = Constants.DEST_WRITING_FOLDER;
            String filePath = Path.Combine(folder, fileName);
            return filePath;
        }

        static public String getDraftFilePath(String[] tokens)
        {
            String fileName = "draftGateKeeper_" + String.Join("_", tokens) + ".rtf";
            String folder = Constants.DEST_WRITING_FOLDER;
            String filePath = Path.Combine(folder, fileName);
            return filePath;
        }

        static public void saveWork(String titleText, String outputText, String type)
        {
            DateTime saveTime = DateTime.Now;
            DateTime currentTime = DateTime.SpecifyKind(saveTime, DateTimeKind.Local);
            char[] delimiterChars = { ' ', '/' };
            String[] tokens = currentTime.ToString().Replace(':', ';').Split(delimiterChars);
            String filePath;
            if (type.Equals("Draft")) { filePath = getDraftFilePath(tokens); }
            else { filePath = getFinalFilePath(tokens); }
            
            // in case there is a similarly named file, rename this one to new version
            int i = 2;
            while (File.Exists(filePath))
            {
                filePath = filePath.Substring(0, filePath.Length-4) + "_V" + i + ".rtf";
                i++;
            }
            MessageBox.Show(filePath);

            // merge title and main texts into single RTF string (have to cut off RTF tag from first string)
            String rtf1 = titleText.Substring(0, titleText.Length - 3);  
            String rtf2 = outputText.Substring(6);
            String finalString = rtf1 + rtf2; 

            try
            {
                using (StreamWriter writer = new StreamWriter(@filePath))
                {
                    writer.Write(finalString);
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
    // constants, mostly to control parameters of gatekeeper writing rules
    static class Constants
    {
        public const int REQ_WORD_COUNT = 500;
        public const int SECONDS_UNTIL_EXIT = 10;
        public const String DEST_WRITING_FOLDER = @"C:\Users\Owner\Documents\creative writing\GamesGatekeeperWritings";
    }
}
