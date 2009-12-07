﻿#region Copyright (c) Lokad 2009
// This code is released under the terms of the new BSD licence.
// URL: http://www.lokad.com/
#endregion

using Autofac.Builder;
using Lokad.Cloud.Diagnostics.Persistence;
using Lokad.Quality;

namespace Lokad.Cloud.Diagnostics
{
	/// <summary>
	/// Cloud Diagnostics IoC Module
	/// </summary>
	[NoCodeCoverage]
	public class DiagnosticsModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.Register<BlobDiagnosticsRepository>().As<ICloudDiagnosticsRepository>();
			builder.Register<ServiceMonitor>().As<IServiceMonitor>();
		}
	}
}
