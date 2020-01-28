using Zenject;
using UnityEngine;
using WhateverDevs.Core.Runtime.Formatting;

public class TestInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        /*Container.Bind<string>().FromInstance("Hello World!");
        Container.Bind<Greeter>().AsSingle().NonLazy();*/
        Container.Bind<IFormatter<string>>().FromInstance(new JsonFormatter()).AsSingle().Lazy();
    }
}

public class Greeter
{
    public Greeter(string message)
    {
        Debug.Log(message);
    }
}