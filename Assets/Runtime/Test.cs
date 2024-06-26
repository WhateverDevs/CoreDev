using System.Collections;
using System.Linq;
using Sirenix.OdinInspector;
using WhateverDevs.Core.Runtime.Common;
using WhateverDevs.Core.Runtime.DataStructures;
using WhateverDevs.Localization.Runtime;
using WhateverDevs.TwoDAudio.Runtime;
using Zenject;

public class Test : LoggableMonoBehaviour<Test>
{
    public PositionData PositionData;

    public AudioReference AudioTest;

    public SerializableDictionary<int, int> TestDictionary;

    [Inject]
    private ILocalizer localizer;

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

    [Button]
    [HideInEditorMode]
    private void ReloadLanguages() => localizer.ReDownloadLanguagesFromGoogleSheet();
}