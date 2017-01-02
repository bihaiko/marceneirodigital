using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Tabua))]
public class TabuaLadoExterno : MonoBehaviour {

    public bool direita;
    private Movel movel;
    private Geral geral;
    private Tabua tabua;
    private Tabua tabuaTeto;
    private Tabua tabuaBase;

    public void Update () {

        if (movel == null) movel = FindObjectOfType<Movel>();
        if (geral == null) geral = movel.GetComponentInChildren<Geral>();
        if (tabua == null) tabua = GetComponent<Tabua>();
        if (tabuaTeto == null) tabuaTeto = movel.GetComponentInChildren<TabuaTeto>().GetComponent<Tabua>();
        if (tabuaBase == null) tabuaBase = movel.GetComponentInChildren<TabuaBase>().GetComponent<Tabua>();

        tabua.x = movel.profundidade;
        tabua.z = movel.tabuaExterna;
        tabua.y = Mathf.Abs((int)tabuaBase.transform.position.y - (int)tabuaTeto.transform.position.y) - movel.tabuaExterna;

        transform.position = new Vector3(direita 
                                            ? - geral.transform.localScale.x / 2 + movel.tabuaExterna/2
                                            : geral.transform.localScale.x / 2 - movel.tabuaExterna / 2, 
                                         tabuaTeto.transform.position.y - tabua.y/2 - movel.tabuaExterna/2, 
                                         0);
    }
}
