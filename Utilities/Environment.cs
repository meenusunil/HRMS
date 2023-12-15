using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Environment
    {
    public string FetchEnv()
    {
        string path = @"C:\Users\mesunil\source\repos\HRMS\HRMS\Utilities\EnvFile.txt";
        string fileData = (File.ReadAllText(path)).ToLower();
        string env = fileData.Substring(6);
        return env;
    }

    }

