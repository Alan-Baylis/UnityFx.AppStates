﻿// Copyright (c) Alexander Bogarsukov.
// Licensed under the MIT license. See the LICENSE.md file in the project root for more information.

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityFx.App
{
	/// <summary>
	/// A generic application view.
	/// </summary>
	/// <seealso cref="IAppViewFactory"/>
	public interface IAppView : ICollection<GameObject>, IDisposable
	{
		/// <summary>
		/// Returns name of the view. Read only.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Return user-specified data (if any). Read only.
		/// </summary>
		object UserData { get; }

		/// <summary>
		/// Returns view bounds (in world space) based on its content. Read only.
		/// </summary>
		Bounds Bounds { get; }

		/// <summary>
		/// Returns <c>true</c> if the view should cover all screen (views under it are not visible); <c>false</c> otherwise. Read only.
		/// </summary>
		bool IsExclusive { get; }

		/// <summary>
		/// Enabled or disables the view (enabled views are visible, disabled are not visible and not interactable).
		/// </summary>
		/// <remarks>
		/// If value of the property is <c>true</c> the view may or may not be visible. For example, if any view above this one
		/// has <see cref="IsExclusive"/> flag set the view will not be rendered.
		/// </remarks>
		/// <seealso cref="Interactable"/>
		/// <seealso cref="IsExclusive"/>
		bool Enabled { get; set; }

		/// <summary>
		/// Enabled or disapbes input processing for the view.
		/// </summary>
		/// <seealso cref="Enabled"/>
		bool Interactable { get; set; }
	}
}