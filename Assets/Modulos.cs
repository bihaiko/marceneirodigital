using UnityEngine;

[ExecuteInEditMode]
public class Modulos : MonoBehaviour {

    public int quantidade = 2;
    public int laguraInternaModulo;
    public bool comParedesInternas;

    private Movel movel;
    private Interno interno;
    private Tabua tabuaFundo;

    public void Update () {

        if (quantidade == 0) return;

        if (movel == null) movel = FindObjectOfType<Movel>();
        if (interno == null) interno = movel.GetComponentInChildren<Interno>();
        if (tabuaFundo == null) tabuaFundo = movel.GetComponentInChildren<TabuaFundo>().GetComponent<Tabua>();

        int max = transform.childCount;
        for (int i = 0; i < max; i++){
            GameObject go = transform.GetChild(i).gameObject;
            go.SetActive(i < quantidade);
        }

        laguraInternaModulo = comParedesInternas
                              ? (tabuaFundo.x - 2 * movel.tabuaInterna - (quantidade - 1) * movel.tabuaInterna * 2) / quantidade
                              : (tabuaFundo.x - (quantidade - 1) * movel.tabuaExterna) / quantidade;
    }
}
