using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;

namespace _14DB
{
     class Setup
    {
        static public void CreateDirectories()
        {
            Directory.CreateDirectory("api_result");
            Directory.CreateDirectory("characters");
            Debug.WriteLine("Setup finished");
        }
    }
}
