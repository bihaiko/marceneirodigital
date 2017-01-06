using UnityEngine;

[ExecuteInEditMode]
public class CopiaEscala : MonoBehaviour {

	private Transform target;

	public void Update () {
		if (target == null) return;
		transform.localScale = target.localScale;
	}
}