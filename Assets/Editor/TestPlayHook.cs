using UnityEngine;
using WhateverDevs.DefaultToolBarButtons.Editor;

namespace Editor
{
    [CreateAssetMenu(menuName = "Test/PlayHook", fileName = "TestPlayHook")]
    public class TestPlayHook : PlayHook
    {
        // This is very stupid because the console usually clears on play but works as an example.
        public override void Run() => Logger.Info("Running before play.");
    }
}