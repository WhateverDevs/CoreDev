using System;
using WhateverDevs.Core.Runtime.Common;
using WhateverDevs.Core.Runtime.DataStructures;
using WhateverDevs.TwoDAudio.Runtime;

public class Test : LoggableMonoBehaviour<Test>
{
    public PositionData PositionData;

    public AudioReference AudioTest;

    private void OnEnable()
    {
        foreach (TestEnum testEnum in Utils.GetAllItems<TestEnum>())
        {
            Logger.Info(testEnum);
        }
    }
}

public enum TestEnum
{
    test1,
    test2,
    test3
}