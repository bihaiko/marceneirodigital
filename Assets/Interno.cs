using UnityEngine;

[ExecuteInEditMode]
public class Interno : MonoBehaviour {

    private Movel movel;
    private Externo externo;
    private Tabua tabuaFundo;

    public void Update(){

        if (movel == null) movel = FindObjectOfType<Movel>();
        if (externo == null) externo = movel.GetComponentInChildren<Externo>();
        if (tabuaFundo == null) tabuaFundo = movel.GetComponentInChildren<TabuaFundo>().GetComponent<Tabua>();

        Vector3 s = externo.transform.localScale;
        Vector3 p = externo.transform.position;

        transform.localScale = new Vector3(s.x - movel.tabuaExterna*2 , s.y - movel.tabuaExterna * 2, s.z - tabuaFundo.z);
        transform.position = new Vector3(p.x, p.y, p.z + tabuaFundo.z/ 2);       
    }
}