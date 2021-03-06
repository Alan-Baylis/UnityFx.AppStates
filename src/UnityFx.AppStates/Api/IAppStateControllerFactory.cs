﻿// Copyright (c) Alexander Bogarsukov.
// Licensed under the MIT license. See the LICENSE.md file in the project root for more information.

using System;

namespace UnityFx.App
{
	/// <summary>
	/// A factory for <see cref="IAppStateController"/> instances.
	/// </summary>
	/// <seealso cref="IAppStateController"/>
	/// <seealso cref="IAppState"/>
	public interface IAppStateControllerFactory
	{
		/// <summary>
		/// Creates a new instance of <see cref="IAppStateController"/> and injects its dependencies (if needed).
		/// </summary>
		/// <param name="controllerType">Type of the controller to be created.</param>
		/// <param name="stateContext">State context.</param>
		/// <param name="serviceProvider">A service provider instance. Should be used as a source for the controller dependencies.</param>
		/// <returns></returns>
		IAppStateController CreateController(Type controllerType, IAppStateContext stateContext, IServiceProvider serviceProvider);
	}
}