using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SkiaSharp;

namespace HUDEwiBlazor.Interfaces
{
    public interface IImageProcessing
    {
        Task<MemoryStream> Resize(byte[] byte_image, int maxWidth, int maxHeight, SKFilterQuality quality = SKFilterQuality.Medium);
    }
}
