﻿#region Copyright (c) Lokad 2009
// This code is released under the terms of the new BSD licence.
// URL: http://www.lokad.com/
#endregion

using Lokad.Quality;

namespace Lokad.Cloud.Diagnostics.Persistence
{
	internal class ExecutionProfilingStatisticsName : BaseTypedBlobName<ExecutionProfilingStatistics>
	{
		public override string ContainerName
		{
			get { return "lokad-cloud-diag-profile"; }
		}

		[UsedImplicitly, Rank(0)]
		public readonly string ContextName;

		public ExecutionProfilingStatisticsName(string contextName)
		{
			ContextName = contextName;
		}

		public static ExecutionProfilingStatisticsName New(string contextName)
		{
			return new ExecutionProfilingStatisticsName(contextName);
		}

		public static BlobNamePrefix<ExecutionProfilingStatisticsName> GetPrefix()
		{
			return GetPrefix(new ExecutionProfilingStatisticsName(null), 0);
		}
	}
}