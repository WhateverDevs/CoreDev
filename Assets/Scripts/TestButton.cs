using WhateverDevs.Core.Runtime.Ui;

public class TestButton : ActionOnButtonClick<TestButton>
{
    public Test Tester;

    protected override void ButtonClicked() => Tester.Log();
}
