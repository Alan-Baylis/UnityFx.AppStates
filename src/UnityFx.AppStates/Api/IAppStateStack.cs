﻿// Copyright (c) Alexander Bogarsukov.
// Licensed under the MIT license. See the LICENSE.md file in the project root for more information.

using System;
using System.Collections.Generic;

namespace UnityFx.App
{
	/// <summary>
	/// Returns a read-only stack of the <see cref="IAppState"/> instances.
	/// </summary>
	public interface IAppStateStack : IReadOnlyCollection<IAppState>
	{
		/// <summary>
		/// Returns the state at the top of the stack without removing it.
		/// </summary>
		/// <exception cref="InvalidOperationException">Thrown if the stack is empty.</exception>
		IAppState Peek();

		/// <summary>
		/// Returns the state at the top of the stack without removing it. Returns <c>false</c> if the stack is empty.
		/// </summary>
		bool TryPeek(out IAppState result);

		/// <summary>
		/// Determines whether the specified state is in the stack.
		/// </summary>
		bool Contains(IAppState state);
	}
}
