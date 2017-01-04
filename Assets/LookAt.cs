using UnityEngine;

[ExecuteInEditMode]
public class LookAt : MonoBehaviour {

    public Transform target;

    public float deltaX;
    public float deltaY;
    public float zoom = 1.2f;
    public float smooth = 8;
    public float speed = .5f;

    private Geral geral;
    private Modulos modulos;
    private GUIController ctrl;

    private float l;
    private float a;

    public void Update(){

        if (target == null) return;
        if (geral == null) geral = FindObjectOfType<Geral>();
        if (modulos == null) modulos = FindObjectOfType<Modulos>();
        if (ctrl == null) ctrl = FindObjectOfType<GUIController>();

        int i = ctrl.index-1;
        target = (i == -1) ? geral.transform : modulos.transform.GetChild(i);
        float x = (i == -1) ? deltaX : deltaX/zoom;
        float y = (i == -1) ? deltaY : deltaY/zoom;

        var pos = target.position - transform.position;
        var newRot = Quaternion.LookRotation(pos);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRot, speed);

        a = target.lossyScale.y;
        l = target.lossyScale.x;

        var max = (a > l) ? Mathf.Pow(a, .5f) * (1 + y) : Mathf.Pow(l, .5f) * (1 + x);
        max = (max < 40) ? 40 : max;

        Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, max, smooth*Time.deltaTime);
    }
}