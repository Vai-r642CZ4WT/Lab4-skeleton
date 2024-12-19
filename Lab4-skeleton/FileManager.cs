using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_skeleton
{
    public class FileManager
    {
        public static string path = DateTime.Now.ToString("dd.MM.yyyy_hh-mm-ss") + ".txt";
        public static void Save(byte[] strBin2)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Append)))
            {
                foreach (var item in strBin2)
                {
                    writer.Write(item);
                }
            }
        }
    }
}
