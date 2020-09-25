using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HUDEwiBlazor.Interfaces;
using SkiaSharp;

namespace HUDEwiBlazor.Classes
{
    public class ImageProcessing: IImageProcessing
    {

        public ImageProcessing()
        {

        }
        /// <summary>
        /// Image Resize Async method using skiasharp wrapper
        /// </summary>
        /// <param name="sourceBitmap"></param>
        /// <param name="maxWidth"></param>
        /// <param name="maxHeight"></param>
        /// <param name="quality"></param>
        /// <returns>Resized SKBitmap with given parameter</returns>
        public async Task<MemoryStream> Resize(byte[] byte_image, int maxWidth, int maxHeight, SKFilterQuality quality = SKFilterQuality.Medium)
        {
            var bitmap = SKBitmap.Decode(byte_image);
            int height = Math.Min(maxHeight, bitmap.Height);
            int width = Math.Min(maxWidth, bitmap.Width);
            SKBitmap scaledBitmap = null;
            await Task.Run(() =>
            {
                scaledBitmap = bitmap.Resize(new SKImageInfo(width, height), quality);
            });
            using SKImage img = SKImage.FromBitmap(scaledBitmap);
            using SKData new_bitmap = img.Encode(SKEncodedImageFormat.Png, 100);
            MemoryStream ms = new MemoryStream();
            new_bitmap.SaveTo(ms);

            return ms;
        }
    }
}
