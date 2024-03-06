namespace Borderlands3ModdingLibrary.Patches;

public class Patch(PatchOperation operation, PatchType type, string syntax = "", bool matchAll = false, int bitfield = 0, string target = "", string comment = "")
{
    public PatchOperation Operation => operation;
    public PatchType Type => type;
    public bool MatchAll => matchAll;
    public int Bitfield => bitfield;
    public string Target => target;
    public string FinalOutput
    {
        get
        {
            string output = string.Empty;
            string targetStr = matchAll ? "MatchAll" : target;
            output += $"{operation},(1,{(int)type},{bitfield},{targetStr}),";
            output += GetFinalSyntax();
            return output;
        }
    }

    public virtual string GetComment()
    {
        return comment;
    }

    protected virtual string GetFinalSyntax()
    {
        return syntax;
    }
}