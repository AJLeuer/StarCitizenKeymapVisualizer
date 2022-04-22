using SFML.Graphics;

namespace StarCitizenKeymapVisualizer.SourceCode.Utility;

public static class Converters
{
    public static SFML.Graphics.Image? ConvertBitmapToSFMLImage(System.Drawing.Bitmap? bmp) 
    {
        if (bmp is null)
        {
            return null;
        }
        
        SFML.Graphics.Color[,] sfmlColorArray = new Color[bmp.Height, bmp.Width];
        
        for (int x = 0; x < bmp.Width; x++)
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                System.Drawing.Color csharpColor = bmp.GetPixel(x, y);
                sfmlColorArray[y,x] = new SFML.Graphics.Color(csharpColor.R, csharpColor.G, csharpColor.B, csharpColor.A);
            }
        }
        
        var newImage = new SFML.Graphics.Image(sfmlColorArray);
        return newImage;
    }
}