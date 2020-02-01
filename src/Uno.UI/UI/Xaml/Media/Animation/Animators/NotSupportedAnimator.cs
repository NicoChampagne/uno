﻿#pragma warning disable CS0067

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Uno.Extensions;
using Uno.Logging;

namespace Windows.UI.Xaml.Media.Animation
{
	internal sealed class NotSupportedAnimator : IValueAnimator, IDisposable
	{
		public void Start()
		{
			this.Log().Error("NotSupportedAnimator.Start");

			if (Debugger.IsAttached)
			{
				throw new NotSupportedException();
			}
		}

		public void Resume()
		{
			this.Log().Error("NotSupportedAnimator.Resume");

			if (Debugger.IsAttached)
			{
				throw new NotSupportedException();
			}
		}
		public void Pause()
		{
			this.Log().Error("NotSupportedAnimator.Pause");

			if (Debugger.IsAttached)
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>
		/// Cancel this instance.
		/// </summary>
		public void Cancel()
		{
			this.Log().Error("NotSupportedAnimator.Cancel");

			IsRunning = false;
		}

		/// <summary>
		/// Stop this instance.
		/// </summary>
		private void Stop()
		{
			this.Log().Error("NotSupportedAnimator.Stop");

			if (Debugger.IsAttached)
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>
		/// Sets the duration.
		/// </summary>
		/// <param name="duration">Duration.</param>
		public void SetDuration(long duration)
		{
			if (Debugger.IsAttached)
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>
		/// Sets the duration.
		/// </summary>
		/// <param name="duration">Duration.</param>
		public void SetEasingFunction(IEasingFunction easingFunction)
		{
			this.Log().Error("NotSupportedAnimator.SetEasingFunction");

			if (Debugger.IsAttached)
			{
				throw new NotSupportedException();
			}
		}

		public event EventHandler AnimationEnd;

		public event EventHandler AnimationPause;

		public event EventHandler AnimationCancel;

		public event EventHandler Update;

		public long StartDelay { get; set; }
		public bool IsRunning { get; set; }
		public long CurrentPlayTime { get; set; }

		public object AnimatedValue { get; set; }
		public long Duration { get; internal set; }

		public void Dispose()
		{
			if (Debugger.IsAttached)
			{
				throw new NotSupportedException();
			}
		}

	}

}

