﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Nexon.Com.Group.Game.Wrapper.HeroesGameGuild
{
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	public class GroupGetInfoByGuildNameCompletedEventArgs : AsyncCompletedEventArgs
	{
		internal GroupGetInfoByGuildNameCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}

		public int Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (int)this.results[0];
			}
		}

		public string strErrorMessage
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.results[1];
			}
		}

		public GroupInfo Info
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (GroupInfo)this.results[2];
			}
		}

		private object[] results;
	}
}
