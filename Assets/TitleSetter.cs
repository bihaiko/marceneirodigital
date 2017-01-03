using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class TitleSetter : MonoBehaviour {

    public Text text;
    public string tile;

    private GUIController ctrl;

    public void Update () {
        if (ctrl == null) ctrl = FindObjectOfType<GUIController>();

        text.text = tile + (ctrl.index==0 ? "" : ""+(ctrl.index)) ;
    }
}
