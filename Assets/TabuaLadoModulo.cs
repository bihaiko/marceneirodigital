using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Tabua))]
public class TabuaLadoModulo: MonoBehaviour {

    public Modulo modulo;

    private Movel movel;
    private Modulos modulos;
    private Tabua tabua;

    public bool direito;

    public void Update () {

        if (movel == null) movel = FindObjectOfType<Movel>();
        if (modulos == null) modulos = movel.GetComponentInChildren<Modulos>();
        if (modulo == null) modulo = movel.GetComponentInChildren<Modulo>();
        if (tabua == null) tabua = GetComponent<Tabua>();

        Vector3 p = modulo.transform.position;
        Vector3 s = modulo.transform.localScale;

        tabua.z = modulos.comParedesInternas ? movel.tabuaInterna : movel.tabuaExterna;
        tabua.x = (int)s.z;
        tabua.y = (int)s.y;

        int signal = direito ? -1 : 1;
        int x0 = (int)p.x + signal * (int)s.x / 2;
        transform.position = new Vector3(x0 + signal*tabua.z/2, p.y, p.z);
    }
}
