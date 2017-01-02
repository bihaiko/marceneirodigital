using UnityEngine;

[ExecuteInEditMode]
public class Geral: MonoBehaviour {

    private Movel movel;

    public void Update(){
        if (movel == null) movel = FindObjectOfType<Movel>();
        transform.localScale = new Vector3(movel.largura, movel.altura, movel.profundidade);
    }
}