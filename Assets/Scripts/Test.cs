using Sirenix.OdinInspector;
using UnityEngine;
using WhateverDevs.Core.Runtime.Common;
using WhateverDevs.Core.Runtime.DataStructures;

public class Test : LoggableMonoBehaviour<Test>
{
    public SerializableDictionary<string, GameObject> SerializableDictionary =
        new SerializableDictionary<string, GameObject>();

    public Renderer Empty;

    [Button]
    public void Log()
    {
        GetLogger().Info("Test");
        //GetLogger().Info(Empty.enabled);
    }
}