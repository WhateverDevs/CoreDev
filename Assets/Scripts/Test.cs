using System.Collections;
using WhateverDevs.Core.Runtime.Common;
using WhateverDevs.Core.Runtime.DataStructures;
using WhateverDevs.TwoDAudio.Runtime;

public class Test : LoggableMonoBehaviour<Test>
{
    public PositionData PositionData;

    public AudioReference AudioTest;

    private void OnEnable()
    {
        StartCoroutine(Init());
    }

    private IEnumerator Init()
    {
        bool playing = true;

        yield return AudioManager.Instance.IsAudioPlaying(AudioTest, isPlaying => playing = isPlaying);

        Logger.Info(playing);

        AudioManager.Instance.PlayAudio(AudioTest, true, fadeTime: 1);

        yield return AudioManager.Instance.IsAudioPlaying(AudioTest, isPlaying => playing = isPlaying);

        Logger.Info(playing);
    }
}