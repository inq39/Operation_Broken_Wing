using UnityEngine;

namespace Operation_Broken_Wing.Asset_Packs.Resources_V2_Pro.Scripts
{
	public class JustRotate : MonoBehaviour {

		public bool canRotate=true;
		public float speed=10;
 
		void Update ()
		{
			if(canRotate)
				transform.Rotate(speed*Vector3.forward*Time.deltaTime);
		}
	}
}
