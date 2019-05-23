using System;
using System.Diagnostics;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace ImageDownsizer
{
    class Program
    {
        //1920/1080 = 300/x
        static void Main(string[] args)
        {
            var desiredWidth = 500;
            using (Image<Rgba32> image = Image.Load("lambo-large.jpg"))
            {
                var y = (image.Height * desiredWidth) / image.Width;
                image.Mutate(x => x
                    .Resize(desiredWidth, y).Pixelate()
                );
                image.Save("lambo-resized.jpg"); // Automatic encoder selected based on extension.
                //Process.Start("lambo-resized.jpg");
            }
        }
    }
}
