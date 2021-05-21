using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;
using WhateverDevs.Core.Runtime.Common;
using WhateverDevs.Core.Runtime.DataStructures;

public class Test : LoggableMonoBehaviour<Test>
{
    public SerializableDictionary<LoadSceneMode, GameObject> SerializableDictionary =
        new SerializableDictionary<LoadSceneMode, GameObject>();

    public Renderer Empty;

    [Button]
    public void Log()
    {
        GetLogger().Info("Test");
        //GetLogger().Info(Empty.enabled);
    }
}