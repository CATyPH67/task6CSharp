using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5task
{
    public interface IPrintingDevice
    {
        int DeviceId { get; set; }

        string Print();
        string GetStatus();
    }
}
