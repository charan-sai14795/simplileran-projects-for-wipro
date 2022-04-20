using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Textfilebasedsystem
{
    internal class Teacher
    {
        public int id;
        public string f_name;
        public string l_name;
        public string clss;
        public string section;
       
        public  void addrecord(string file, string data)
        {
         
            File.AppendAllText(file,data+Environment.NewLine);
        }

    }
}
