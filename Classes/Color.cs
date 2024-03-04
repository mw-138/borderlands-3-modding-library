namespace Borderlands3ModdingLibrary.Classes;

public class Color(float r, float g, float b, float a = 1f)
{
    public float R { get; private set; } = r;
    public float G { get; private set; } = g;
    public float B { get; private set; } = b;
    public float A { get; private set; } = a;
}
