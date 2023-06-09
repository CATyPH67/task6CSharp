using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5task
{
    public class LazerPrinter : Printer
    {
        public string PrinterName { get; set; }
        public int PaperCount { get; set; } = 0;

        public LazerPrinter() : base()
        {
        }

        public LazerPrinter(int DeviceId, string name, int startPaperCount) : base(DeviceId)
        {
            PrinterName = name;
            PaperCount = startPaperCount;
        }

        public override bool CheckPaper()
        {
            return PaperCount >= Documents.Count;
        }

        public override void AddNewPaper(int paperCount)
        {
            if (paperCount < 0)
                throw new Exception("Неправильное переданное количество бумаги");
            PaperCount += paperCount;
        }
    }
}
