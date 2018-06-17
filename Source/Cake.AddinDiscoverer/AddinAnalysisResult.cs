﻿using Cake.AddinDiscoverer.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Cake.AddinDiscoverer
{
	/// <summary>
	/// Contains the result of the analysis of a given addin
	/// </summary>
	internal class AddinAnalysisResult
	{
		/// <summary>
		/// Gets or sets the version of Cake.Core referenced by this addin or a null value if the addin does not reference Cake.Core
		/// </summary>
		public SemVersion CakeCoreVersion { get; set; }

		/// <summary>
		/// Gets or sets the version of Cake.Common referenced by this addin or a null value if the addin does not reference Cake.Common
		/// </summary>
		public SemVersion CakeCommonVersion { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether reference to Cake.Core is private
		/// </summary>
		public bool CakeCoreIsPrivate { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether reference to Cake.Common is private
		/// </summary>
		public bool CakeCommonIsPrivate { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the addin references the cake-contrib icon
		/// </summary>
		public bool UsingCakeContribIcon { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the addin has a YAML file on the Cake website
		/// </summary>
		public bool HasYamlFileOnWebSite { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the addin was transfered to the cake-contrib github organisation
		/// </summary>
		public bool TransferedToCakeContribOrganisation { get; set; }

		/// <summary>
		/// Gets or sets notes (such as error messages)
		/// </summary>
		public string Notes { get; set; }
	}
}
