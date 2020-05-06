using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WhateverDevs.Core.Runtime.Configuration;

[CreateAssetMenu]
public class Test2 : ConfigurationScriptableHolderUsingFirstValidPersister<Test2Data>
{
    
}

[Serializable]
public class Test2Data : ConfigurationData
{
    public int random;
}
