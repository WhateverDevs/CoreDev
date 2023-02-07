using TMPro;
using UnityEngine;
using WhateverDevs.Core.Runtime.Common;

namespace DefaultNamespace
{
    public class ErrorDisplayer : MonoBehaviour
    {
        public TMP_Text Text;

        private void OnEnable() => AppEventsListener.Instance.ErrorLogged += error => Text.SetText(error);
    }
}