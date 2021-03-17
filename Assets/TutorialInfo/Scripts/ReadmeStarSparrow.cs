using System;
using UnityEngine;

namespace Operation_Broken_Wing.TutorialInfo.Scripts
{
	public class ReadmeStarSparrow : ScriptableObject {
		public Texture2D icon;
		public string title;
		public Section[] sections;
		public bool loadedLayout;
	
		[Serializable]
		public class Section {
			public string heading, text, linkText, url;
		}
	}
}
