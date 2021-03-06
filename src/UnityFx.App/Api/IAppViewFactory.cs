﻿// Copyright (c) Alexander Bogarsukov.
// Licensed under the MIT license. See the LICENSE.md file in the project root for more information.

using System;

namespace UnityFx.App
{
	/// <summary>
	/// A factory for <see cref="IAppView"/> instances.
	/// </summary>
	public interface IAppViewFactory
	{
		/// <summary>
		/// Creates an empty view with the specified name.
		/// </summary>
		IAppView CreateView(string name, bool exclusive, IAppView insertAfter, object userData);
	}
}
