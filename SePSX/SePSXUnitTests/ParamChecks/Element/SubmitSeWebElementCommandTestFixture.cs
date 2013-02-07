﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 7/19/2012
 * Time: 10:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSXUnitTests.CheckCmdletParameters
{
    using System;
    using SePSX; using MbUnit.Framework;
    using OpenQA.Selenium;
    
    /// <summary>
    /// Description of SubmitSeWebElementCommand.
    /// </summary>
    [TestFixture]
    public class SubmitSeWebElementCommand_ParamCheck
    {
        public SubmitSeWebElementCommand_ParamCheck()
        {
        }
        
        [SetUp]
        public void PrepareRunspace()
        {
            MiddleLevelCode.PrepareRunspaceForParamChecks();
        }
        
        [TearDown]
        public void DisposeRunspace()
        {
            // MiddleLevelCode.DisposeRunspace(); // 20121226
        }
        
        [Test]
        [Category("Fast")]
        public void SubmitSeWebElement_InputObject()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_FailureOutput(
                "Submit-SeWebElement " +
                "-InputObject ([SePSXUnitTests.ParamChecks.FakeWebObjectsFactory]::GetFakeWebElement());");
        }
        
        [Test]
        [Category("Fast")]
        public void SubmitSeWebElement_NoInputObject()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_FailureOutput(
                "[SePSXUnitTests.ParamChecks.FakeWebObjectsFactory]::GetFakeWebElement() | " +
                "Submit-SeWebElement;");
        }
    }
}
