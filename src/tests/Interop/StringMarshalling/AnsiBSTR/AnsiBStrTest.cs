// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using System;
using System.Reflection;
using System.Text;
using Xunit;

public class AnsiBStrTest
{
    [Fact]
    public static int TestEntryPoint()
    {
        try
        {
            CommonStringTests.RunTests(runStringBuilderTests: false, runStructTests: false);
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return 101;
        }
        return 100;
    }
}
