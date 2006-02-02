﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

using System;

using Progs = Debugger.Tests.TestPrograms;

namespace Debugger.Tests
{
	public class TestProgram
	{
		public static void Main(string[] args)
		{
			if (args.Length == 0) {
				return;
			}
			switch (args[0]) {
				case "ArrayValue": Progs.ArrayValue.Main(); break;
				case "Break": Progs.Break.Main(); break;
				case "Breakpoint": Progs.Breakpoint.Main(); break;
				case "Callstack": Progs.Callstack.Main(); break;
				case "FileRelease": Progs.FileRelease.Main(); break;
				case "FunctionArgumentVariables": Progs.FunctionArgumentVariables.Main(); break;
				case "FunctionLifetime": Progs.FunctionLifetime.Main(); break;
				case "FunctionLocalVariables": Progs.FunctionLocalVariables.Main(); break;
				case "FunctionVariablesLifetime": Progs.FunctionVariablesLifetime.Main(); break;
				case "HelloWorld": Progs.HelloWorld.Main(); break;
				case "ObjectValue": Progs.ObjectValue.Main(); break;
				case "PropertyVariable": Progs.PropertyVariable.Main(); break;
				case "PropertyVariableForm": Progs.PropertyVariableForm.Main(); break;
				case "SetIP": Progs.SetIP.Main(); break;
				case "SimpleProgram": Progs.SimpleProgram.Main(); break;
				case "Stepping": Progs.Stepping.Main(); break;
				case "Symbols": Progs.Symbols.Main(); break;
			}
		}
	}
}
