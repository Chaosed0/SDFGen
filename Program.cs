using Raylib_CsLo;

class Program
{
    static void Main(string[] args)
    {
        Image source = Raylib.LoadImage(args[0]);
        Image destination = Raylib.ImageCopy(source);
        SDFTextureGenerator.Generate(source, destination, float.Parse(args[2]), float.Parse(args[3]), 1f, RGBFillMode.White);
        Raylib.ExportImage(destination, args[1]);
    }
}
