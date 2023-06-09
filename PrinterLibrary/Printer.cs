using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5task
{
    public abstract class Printer : IPrintingDevice
    {
        public int DeviceId { get; set; }
        public List<string> Documents { get; set; }
        public int Status { get; set; } = -1;

        public Printer()
        {
        }

        public Printer(int DeviceId)
        {
            this.DeviceId = DeviceId;
        }

        public string Print()
        {
            string message = "Печать документа:\n";
            foreach (var doc in Documents)
            {
                message += doc + "\n";
            }
            return message;
        }

        public string GetStatus()
        {
            switch (Status)
            {
                case 0:
                    return "ожидает\n";
                case 1:
                    return "печатает\n";
                case -1:
                    return "выключен\n";
                default:
                    throw new Exception("Неподходящий формат данных для процесса печати\n");
            }
        }

        public void SendDocumentToPrinter(string document)
        {
            Documents = document.Split('\n').ToList();
        }

        public abstract bool CheckPaper();

        public abstract void AddNewPaper(int paperCount);
    }
}
