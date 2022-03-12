using Paint_Keyboard.Model;
using System;
using System.IO;
using System.Windows;
using System.Windows.Resources;
using System.Xml.Linq;

namespace Paint_Keyboard
{
    public static partial class XML
    {

        public static Solution ConstructSolutionFile() => XML.ConstructSolutionFile(true, SolutionType.None);
        public static Solution ConstructSolutionFile(SolutionType type) => XML.ConstructSolutionFile(false, type);
        private static Solution ConstructSolutionFile(bool isLocalFolder, SolutionType type)
        {
            bool isLocalFilterExists = File.Exists(SolutionUri.FilePath);

            if (isLocalFilterExists && isLocalFolder == false)
            {
                isLocalFilterExists = false;
                File.Delete(SolutionUri.FilePath);
            }

            if (isLocalFilterExists == false)
            {
                // Read the file from the package.
                StreamResourceInfo info = Application.GetResourceStream(new SolutionUri(type));

                // Copy to the local folder.
                using (Stream stream2 = info.Stream)
                using (FileStream stream = new FileStream(SolutionUri.FilePath, FileMode.CreateNew))
                {
                    stream2.CopyTo(stream);
                };
            }

            using (FileStream stream = new FileStream(SolutionUri.FilePath, FileMode.Open))
            {
                try
                {
                    XDocument document = XDocument.Load(stream);

                    Solution source = XML.LoadSolution(document);
                    return source;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public static void SaveSolutionFile(Solution solution)
        {
            XDocument document = XML.SaveSolution(solution);

            // Save the Solution xml file.
            File.Delete(SolutionUri.FilePath);
            using (FileStream stream = new FileStream(SolutionUri.FilePath, FileMode.CreateNew))
            {
                document.Save(stream);
            };
        }

    }
}