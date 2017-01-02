using UnityEngine;

[ExecuteInEditMode]
public class LookAt : MonoBehaviour {

    public Transform target;

	public void Update () {
        if (target == null) return;

        transform.LookAt(target);
	}
}
