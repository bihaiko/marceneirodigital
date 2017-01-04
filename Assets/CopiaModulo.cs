using UnityEngine;

[ExecuteInEditMode]
public class CopiaModulo : MonoBehaviour {

    private Modulos modulos;

    public void Update () {
        if (modulos == null) modulos = FindObjectOfType<Modulos>();
        transform.localScale = modulos.transform.GetChild(0).localScale;
    }
}
