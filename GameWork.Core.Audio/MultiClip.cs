﻿using GameWork.Core.Audio.Interfaces;
using GameWork.Core.Utilities;

namespace GameWork.Core.Audio
{
	public class MultiClip
	{
		private readonly MultiClipModel _model;

		private int _previousIndex = int.MinValue;

		public MultiClip(MultiClipModel model)
		{
			_model = model;
		}

		public IAudioClip GetRandom()
		{
			var randomIndex = RandomUtil.Next(_model.Clips.Length);
			return _model.Clips[randomIndex];
		}

		public IAudioClip GetDifferentRandom()
		{
			var randomIndex = RandomUtil.Next(_model.Clips.Length);

			if(_previousIndex == randomIndex)
			{
				randomIndex = (randomIndex + 1) % _model.Clips.Length;
			}

		    _previousIndex = randomIndex;

			return _model.Clips[randomIndex];
		}
	}
}