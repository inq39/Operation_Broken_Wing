using UnityEngine;
using UnityEngine.UI;

namespace Operation_Broken_Wing.Asset_Packs.Resources_V2_Pro.Scripts
{
	public class SliderValuePass : MonoBehaviour {

		Text progress;

		// Use this for initialization
		void Start () {
			progress = GetComponent<Text>();

		}
	
		public  void UpdateProgress (float content) {
			progress.text = Mathf.Round( content*100) +"%";
		}


	}
}
