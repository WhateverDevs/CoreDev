using Sirenix.OdinInspector;
using WhateverDevs.Core.Runtime.Common;

public class Test : LoggableMonoBehaviour<Test>
{
    [Button]
    public void Log() => GetLogger().Info("Test");
}