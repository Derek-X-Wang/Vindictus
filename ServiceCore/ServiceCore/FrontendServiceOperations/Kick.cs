﻿using System;
using UnifiedNetwork.Cooperation;

namespace ServiceCore.FrontendServiceOperations
{
	[Serializable]
	public sealed class Kick : Operation
	{
		public override OperationProcessor RequestProcessor()
		{
			return new NullProcessor(this);
		}
	}
}
