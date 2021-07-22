using WhateverDevs.Core.Runtime.Common;
using WhateverDevs.Core.Runtime.DataStructures;

public class Test : LoggableMonoBehaviour<Test>
{
    public Tag Tag;

    private void OnEnable()
    {
        string someShit = Tag;
        Tag = someShit;
        Logger.Info(someShit);
        Logger.Info(Tag);
    }
}