using System;
using System.IO;

namespace exam.Helper
{
    internal class ReadDate
    {
        public static int readDateHour(string path)
        {
            string[] lines = File.ReadAllLines(path);
            return Convert.ToInt32(lines[0]);
        }

        public static int readDateMinute(string path)
        {
            string[] lines = File.ReadAllLines(path);
            return Convert.ToInt32(lines[1]);
        }
    }
}
