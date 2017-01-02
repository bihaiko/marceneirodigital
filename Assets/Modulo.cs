using UnityEngine;

[ExecuteInEditMode]
public class Modulo : MonoBehaviour {

    public GameObject paredes;

    private Movel movel;
    private Modulos modulos;
    private Interno interno;

    public int indice = 0;

    public void Update(){
        gameObject.name = "Modulo" + indice;
        paredes.name = gameObject.name;

        if (movel == null) movel = FindObjectOfType<Movel>();
        if (modulos == null) modulos = movel.GetComponentInChildren<Modulos>();
        if (interno == null) interno = movel.GetComponentInChildren<Interno>();

        Vector3 s = interno.transform.localScale;
        Vector3 p = interno.transform.position;
        transform.localScale = new Vector3(modulos.laguraInternaModulo, s.y, s.z);
        int x0 = (int)(p.x - s.x / 2);

        int divisor = modulos.comParedesInternas ? movel.tabuaInterna*2 : movel.tabuaExterna;
        int lateral = modulos.comParedesInternas ? movel.tabuaInterna : 0;
        int deltaModulo = modulos.laguraInternaModulo/2 + lateral + indice * (modulos.laguraInternaModulo + divisor);
        transform.position = new Vector3( x0 + deltaModulo, p.y, p.z);
    }

    public void OnEnable(){
        paredes.SetActive(true);
        var tlm = paredes.GetComponentsInChildren<TabuaLadoModulo>();
        foreach (TabuaLadoModulo t in tlm) 
            t.modulo = this;
        
    }
    public void OnDisable(){paredes.SetActive(false);}
}