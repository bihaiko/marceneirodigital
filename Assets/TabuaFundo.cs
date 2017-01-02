using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Tabua))]
public class TabuaFundo : MonoBehaviour {

    public Tabua tabua;
    public Externo externo;
    public Movel movel;

    public void Update () {
        tabua.x = (int)externo.transform.localScale.x - movel.tabuaExterna*2;
        tabua.y = (int)externo.transform.localScale.y - movel.tabuaExterna*2;
        tabua.z = movel.tabuaExterna;

        Vector3 p = externo.transform.position;

        transform.position = new Vector3(p.x, p.y, p.z - externo.transform.localScale.z/2 + movel.tabuaExterna/2);
    }
}
