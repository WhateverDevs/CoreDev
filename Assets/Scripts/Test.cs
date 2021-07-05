using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;
using WhateverDevs.Core.Runtime.Common;
using WhateverDevs.Core.Runtime.DataStructures;
using WhateverDevs.SceneManagement.Runtime.SceneManagement;
using WhateverDevs.TwoDAudio.Runtime;
using Zenject;

public class Test : LoggableMonoBehaviour<Test>
{
    public SerializableDictionary<LoadSceneMode, GameObject> SerializableDictionary =
        new SerializableDictionary<LoadSceneMode, GameObject>();

    public Renderer Empty;

    public PositionData SpawnPosition;

    public AudioReference Audio;

    public SceneReference Scene;

    [Inject]
    public IAudioManager AudioManager;

    [Inject]
    public IAudioLibrary AudioLibrary;

    private void OnEnable()
    {
        Log();
    }

    [Button]
    public void Log()
    {
        AudioManager.PlayAudio(Audio);
        AudioManager.PlayAudio(Audio);
        AudioManager.PlayAudio(Audio);
        AudioManager.PlayAudio(Audio);
        AudioManager.PlayAudio(Audio);

        Logger.Error("Fuck!");
    }
}