﻿// Copyright 2012 Telerik AD
// 
// This program is free software: you can redistribute it and/or modify 
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
using System;
using System.Linq;
using Microsoft.Practices.Prism.Events;

namespace Reflexil.JustDecompile.MenuItems
{
	internal class EmbeddedResourceContextMenu : MenuItemBase
	{
		public EmbeddedResourceContextMenu(IEventAggregator eventAggregator) : base(eventAggregator)
		{
		}

		public override void AddMenuItems()
		{
			this.AddRenameDeleteNodes();
		}
	}
}