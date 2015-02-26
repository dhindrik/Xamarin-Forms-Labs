using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLabs.Platform.Services
{
    public interface IScreenshotManager
    {
        Task<byte[]> CaptureAsync();
    }
}
