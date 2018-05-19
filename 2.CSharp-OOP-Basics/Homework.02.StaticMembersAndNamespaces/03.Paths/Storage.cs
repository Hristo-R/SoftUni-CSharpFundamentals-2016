namespace _03.Paths
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public static class Storage
    {
        public static void SavePath(Path3D path)
        {
            using (StreamWriter writer = new StreamWriter("paths.txt", true))
            {
                writer.WriteLine(path);
            }
        }

        public static void LoadPath()
        {
            StringBuilder sb = new StringBuilder();
            string line;

            using (StreamReader reader = new StreamReader("paths.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    sb.AppendLine($"3D path: {line}");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
