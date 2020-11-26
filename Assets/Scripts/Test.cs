using System;
using Sirenix.OdinInspector;
using UnityEngine;
using WhateverDevs.Core.Runtime.Common;

public class Test : LoggableMonoBehaviour<Test>
{
    public Renderer Empty;
    
    [Button]
    public void Log()
    {
        GetLogger().Info("Test");
        GetLogger().Info(Empty.enabled);
    }
}