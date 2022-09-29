#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NativeUI;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.CoreBase;
using FTOptix.Core;
#endregion

public class RuntimeNetLogic2 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void TestMe(){
        Log.Info("hello");
    }

    [ExportMethod]
    public void TestMe2()
    {
        Log.Info("hello2");
    }
}
