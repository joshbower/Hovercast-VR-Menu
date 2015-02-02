﻿using System;
using Hovercast.Core.Navigation;

namespace Hovercast.Core.Settings {

	/*================================================================================================*/
	public interface ISettings {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		Type GetUiArcSegmentRendererType(NavItem pNavItem);

		/*--------------------------------------------------------------------------------------------*/
		Type GetUiCursorRendererType();

		/*--------------------------------------------------------------------------------------------*/
		Type GetUiPalmRendererType();

		/*--------------------------------------------------------------------------------------------*/
		ArcSegmentSettings GetArcSegmentSettings(NavItem pNavItem);
		
		/*--------------------------------------------------------------------------------------------*/
		CursorSettings GetCursorSettings();

		/*--------------------------------------------------------------------------------------------*/
		InteractionSettings GetInteractionSettings();

	}

}