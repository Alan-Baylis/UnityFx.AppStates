﻿// Copyright (c) Alexander Bogarsukov.
// Licensed under the MIT license. See the LICENSE.md file in the project root for more information.

using System;

namespace UnityFx.App.Tests
{
	internal class TestController_DisposeError : IAppStateController, IDisposable
	{
		public void Dispose()
		{
			throw new Exception();
		}
	}
}
