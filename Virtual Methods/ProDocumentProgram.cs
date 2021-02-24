using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Methods
{
    class ProDocumentProgram:DocumentProgram
    {
        public sealed override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in Doc format,for PDF format buy Expert Packet");
        }
    }
}
