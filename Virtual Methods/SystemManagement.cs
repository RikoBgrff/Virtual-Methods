using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Methods
{
    class SystemManagement
    {
        public void StartProgram()
        {
            string basic = "basic";
            string pro = "pro";
            string expert = "expert";

            Console.Write("Enter the key:"); string key = Console.ReadLine();
            if(key == basic)
            {
                DocumentProgram docProgram = new DocumentProgram();
                docProgram.OpenDocument();
                docProgram.EditDocument();
                docProgram.SaveDocument();
            }
            if (key == pro)
            {
                DocumentProgram docProgram = new ProDocumentProgram();
                docProgram.OpenDocument();
                docProgram.EditDocument();
                docProgram.SaveDocument();
            }
            if (key == expert)
            {
                DocumentProgram docProgram = new ExpertDocument();
                docProgram.OpenDocument();
                docProgram.EditDocument();
                docProgram.SaveDocument();
            }
        }
    }
}
