﻿using Borderlands3ModdingLibrary.Patches;

namespace Borderlands3ModdingLibrary.Hotfixes;

public class Hotfix(string comment = "", List<Patch> patches = default)
{
    public virtual List<Patch> GetPatches()
    {
        return patches;
    }

    public virtual string GetComment()
    {
        return comment;
    }
}