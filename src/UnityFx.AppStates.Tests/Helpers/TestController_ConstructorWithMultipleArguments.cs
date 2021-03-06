﻿// Copyright (c) Alexander Bogarsukov.
// Licensed under the MIT license. See the LICENSE.md file in the project root for more information.

using System;

namespace UnityFx.App.Tests
{
	internal class TestController_ConstructorWithMultipleArguments : IAppStateController
	{
		public IServiceProvider ServiceProvider { get; }

		public IAppStateContext Context { get; }

		public object Obj { get; }

		public TestController_ConstructorWithMultipleArguments(IServiceProvider sp, IAppStateContext c, object o)
		{
			ServiceProvider = sp;
			Context = c;
			Obj = o;
		}
	}
}
