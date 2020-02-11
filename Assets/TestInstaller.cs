using Zenject;
using UnityEngine;
using WhateverDevs.Core.Runtime.Serialization;

public class TestInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        /*Container.Bind<string>().FromInstance("Hello World!");
        Container.Bind<Greeter>().AsSingle().NonLazy();*/
        Container.Bind<ISerializer<string>>().FromInstance(new JsonSerializer()).AsSingle().Lazy();
    }
}

public class Greeter
{
    public Greeter(string message)
    {
        Debug.Log(message);
    }
}