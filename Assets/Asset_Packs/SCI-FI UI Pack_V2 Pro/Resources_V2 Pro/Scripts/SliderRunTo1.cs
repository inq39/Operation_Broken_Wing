using UnityEngine;
using UnityEngine.UI;

namespace Operation_Broken_Wing.Asset_Packs.Resources_V2_Pro.Scripts
{
	public class SliderRunTo1 : MonoBehaviour
	{
 
		public bool b=true;
		public Slider slider;
		public float speed=0.5f;

		float time =0f;
  
		void Start()
		{
	  
			slider = GetComponent<Slider>();
		}
  
		void Update()
		{
			if(b)
			{
				time+=Time.deltaTime*speed;
				slider.value = time;
			
				if(time>1)
				{
					b = false;
					time=0;
				}
			}
		}
	
	
	}
}
