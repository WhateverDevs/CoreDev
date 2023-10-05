using System.Collections;
using System.Linq;
using WhateverDevs.Core.Runtime.Common;
using WhateverDevs.Core.Runtime.DataStructures;
using WhateverDevs.TwoDAudio.Runtime;

public class Test : LoggableMonoBehaviour<Test>
{
    public PositionData PositionData;

    public AudioReference AudioTest;

    public SerializableDictionary<int, int> TestDictionary;

    private void OnEnable()
    {
        TestDictionary = TestDictionary.Where(pair => pair.Key == pair.Value).ToSerializableDictionary();

        StartCoroutine(Init());
    }

    private IEnumerator Init()
    {
        bool playing = true;

        yield return AudioManager.Instance.IsAudioPlaying(AudioTest, isPlaying => playing = isPlaying);

        Logger.Info(playing);

        AudioManager.Instance.PlayAudio(AudioTest,
                                        true
                                        #if WHATEVERDEVS_2DAUDIO_DOTWEEN
                                        ,
                                        fadeTime: 1
                                        #endif
                                       );

        yield return AudioManager.Instance.IsAudioPlaying(AudioTest, isPlaying => playing = isPlaying);

        Logger.Info(playing);
    }
}