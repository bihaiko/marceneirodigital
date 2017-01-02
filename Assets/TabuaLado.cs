using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Tabua))]
public class TabuaLado : MonoBehaviour {

    public Movel.TipoEspessura tipoEspessura;
    public Transform areaDisponivel;
    public int indice;
    public int laguraInternoModulo;

    private Movel movel;
    private Modulos modulos;
    private Tabua tabua;

    public void Update () {

        if (movel == null) movel = FindObjectOfType<Movel>();
        if (modulos == null) modulos = movel.GetComponentInChildren<Modulos>();
        if (tabua == null) tabua = GetComponent<Tabua>();

        Vector3 p = areaDisponivel.position;
        Vector3 s = areaDisponivel.localScale;

        laguraInternoModulo = (int)(s.x - (modulos.quantidade -1) * tabua.z + tabua.z/2) / modulos.quantidade;

        tabua.z = tipoEspessura == Movel.TipoEspessura.Externa ? movel.tabuaExterna : movel.tabuaInterna;
        tabua.x = (int)s.z;
        tabua.y = (int)areaDisponivel.localScale.y;
        int x0 = (int)p.x - (int)s.x / 2;

        transform.position = new Vector3(x0 + laguraInternoModulo*indice + tabua.z/2, p.y, p.z);
    }
}
