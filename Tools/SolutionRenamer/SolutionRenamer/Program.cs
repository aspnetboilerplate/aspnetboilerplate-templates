using System;
using System.IO;
using System.Linq;
using System.Text;

namespace SolutionRenamer
{
    public class Program
    {
        private static string _placeHolder = "";
        private static string _templatePath = "";
        private static string _solutionName = "";

        static void Main(string[] args)
        {
            try
            {
                GetAllParametersFromConsole();
                RenameSolution();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("FINISHED!");
            }
            catch (Exception ex)
            {
                ConsoleHelper.WriteError(ex.Message);
            }

            Console.ResetColor();
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }

        public static void GetAllParametersFromConsole()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Solution Renamer for ASP.NET Boilerplate");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("This is a simple application to prepare solution templates from existing templates.");
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1 - Single-Page Application");
            Console.WriteLine("2 - Multi-Page Application");
            var templateNo = ConsoleHelper.GetParameterFromConsole("Enter project type: ", new[] { "1", "2" });
            switch (templateNo)
            {
                case "1":
                    _templatePath = "SinglePageApplication";
                    _placeHolder = "MySpaProject";
                    break;
                case "2":
                    _templatePath = "MultiPageApplication";
                    _placeHolder = "MyMvcProject";
                    break;
            }

            if (!Path.IsPathRooted(_templatePath))
            {
                _templatePath = Path.Combine(Directory.GetCurrentDirectory(), _templatePath);
            }

            _solutionName = ConsoleHelper.GetParameterFromConsole("Enter your solution's name: ");
            if (_solutionName.Contains(" "))
            {
                throw new Exception("Solution name can not contain spaces");
            }
        }

        private static void RenameSolution()
        {
            RenameDirRecursively(_templatePath);
            RenameAllFiles(_templatePath);
            ReplaceContent(_templatePath);
        }

        private static void RenameDirRecursively(string rootPath)
        {
            var dirs = Directory.GetDirectories(rootPath, "*.*", SearchOption.TopDirectoryOnly);
            foreach (var dir in dirs)
            {
                var newDir = dir;
                if (dir.Contains(_placeHolder))
                {
                    newDir = dir.Replace(_placeHolder, _solutionName);
                    Directory.Move(dir, newDir);
                }

                RenameDirRecursively(newDir);
            }
        }

        private static void RenameAllFiles(string rootPath)
        {
            var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                if (file.Contains(_placeHolder))
                {
                    File.Move(file, file.Replace(_placeHolder, _solutionName));
                }
            }
        }

        private static void ReplaceContent(string rootPath)
        {
            var skipExtensions = new[]
                                 {
                                     ".exe", ".dll", ".bin", ".suo", ".png", ".pdb", ".obj"
                                 };

            var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                if (skipExtensions.Contains(Path.GetExtension(file)))
                {
                    continue;
                }

                var fileSize = GetFileSize(file);
                if (fileSize < _placeHolder.Length)
                {
                    continue;
                }

                var encoding = GetEncoding(file);

                var content = File.ReadAllText(file, encoding);
                var newContent = content.Replace(_placeHolder, _solutionName);
                if (newContent != content)
                {
                    File.WriteAllText(file, newContent, encoding);
                }
            }
        }

        private static long GetFileSize(string file)
        {
            return new FileInfo(file).Length;
        }

        private static Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open)) file.Read(bom, 0, 4);

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.ASCII;
        }
    }
}
