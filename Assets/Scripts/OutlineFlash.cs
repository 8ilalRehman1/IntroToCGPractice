using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineFlash : MonoBehaviour
{
	[SerializeField] private Material outlineMat;
	[SerializeField] private Transform fist;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine(flashOutline());
		}
	}
	
	private IEnumerator flashOutline()
	{
		outlineMat.SetFloat("_OutlineWidth", 0.5f);
		yield return new WaitForSeconds(0.2f);
        outlineMat.SetFloat("_OutlineWidth", 0);
        yield return new WaitForSeconds(0.2f);
        outlineMat.SetFloat("_OutlineWidth", 0.5f);
        yield return new WaitForSeconds(0.2f);
        outlineMat.SetFloat("_OutlineWidth", 0);
		fist.position -= transform.position + Vector3.forward * 5;
        yield return new WaitForSeconds(0.4f);
        fist.position += transform.position + Vector3.forward * 5;

    }
}
