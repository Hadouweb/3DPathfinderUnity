using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransparent : MonoBehaviour
{
	void Start()
	{
		Material material = gameObject.GetComponent<Renderer>().material;
		material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.One);
		material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
		material.SetInt("_ZWrite", 0);
		material.DisableKeyword("_ALPHATEST_ON");
		material.DisableKeyword("_ALPHABLEND_ON");
		material.EnableKeyword("_ALPHAPREMULTIPLY_ON");
		material.renderQueue = 3000;
		gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0.1f);
	}
}