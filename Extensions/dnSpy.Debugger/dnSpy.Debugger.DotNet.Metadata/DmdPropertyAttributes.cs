﻿/*
    Copyright (C) 2014-2018 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace dnSpy.Debugger.DotNet.Metadata {
	/// <summary>
	/// Property attributes
	/// </summary>
	[Flags]
	public enum DmdPropertyAttributes : ushort {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
		SpecialName			= 0x0200,
		RTSpecialName		= 0x0400,
		HasDefault			= 0x1000,
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
