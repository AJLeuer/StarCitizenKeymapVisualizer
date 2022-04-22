using System.Drawing;
using SFML.Graphics;
using StarCitizenKeymapVisualizer.SourceCode.Utility;
using Svg;
using Image = SFML.Graphics.Image;

namespace StarCitizenKeymapVisualizer.SourceCode.Models;

public class Key : Sprite
{
    public Key() : base()
    {
        using MemoryStream blankKeyVectorImageStream = new (Resources.Assets.BlankKeyVectorImage);
        SvgDocument? blankKeySVG = SvgDocument.Open<SvgDocument>(blankKeyVectorImageStream);
        using Bitmap? blankKeyRaster = blankKeySVG?.Draw(600, 600);
        using Image? blankKeyImage = Converters.ConvertBitmapToSFMLImage(blankKeyRaster);

        this.Texture = new Texture(blankKeyImage);
    }
}