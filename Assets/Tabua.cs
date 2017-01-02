using UnityEngine;

[ExecuteInEditMode]
public class Tabua : MonoBehaviour {

    public int x = 1000;
    public int y = 1500;
    public int z = 18;

    public void Update(){
        transform.localScale = new Vector3(x, y, z);
    }
}
