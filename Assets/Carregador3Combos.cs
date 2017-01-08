using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

[ExecuteInEditMode]
public class Carregador3Combos : MonoBehaviour {


	public Transform conteudo;
	public Transform currentNode;
	public Transform lastSelectedTipo;
	public Transform lastSelectedSubTipo;
	public Transform lastSelectedContainer;

	public Dropdown tipo;
	public Dropdown subtipo;
	public Dropdown container;

	public void Start(){
		ResetTipos ();
	}

	public void ResetTipos(){
		Debug.Log ("Restarting Tipos");
		tipo.options.Clear();

		List<Dropdown.OptionData> result = new List<Dropdown.OptionData> ();
		for (int i = 0; i < conteudo.childCount; i++) {
			result.Add (new Dropdown.OptionData (conteudo.GetChild (i).name));
		}

		tipo.AddOptions (result);
		lastSelectedTipo = conteudo.GetChild (0);

		ResetSupTipos();

	}

	public void ResetSupTipos(){
		Debug.Log ("Restarting SubTipos");
		subtipo.options.Clear();

		List<Dropdown.OptionData> result = new List<Dropdown.OptionData> ();
		for (int i = 0; i < lastSelectedTipo.childCount; i++) {
			result.Add (new Dropdown.OptionData (lastSelectedTipo.GetChild (i).name));
		}

		subtipo.AddOptions (result);
		lastSelectedSubTipo = lastSelectedTipo.GetChild (0);
	}


	public void ResetContainer(){
		Debug.Log ("Restarting Containers");
		container.options.Clear ();

		List<Dropdown.OptionData> result = new List<Dropdown.OptionData> ();
		for (int i = 0; i < lastSelectedTipo.childCount; i++) {
			result.Add (new Dropdown.OptionData (lastSelectedTipo.GetChild (i).name));
		}

		container.AddOptions (result);
		lastSelectedContainer = lastSelectedSubTipo.GetChild (0);
	}

	public void Update(){

		if (lastSelectedTipo == null) {
			ResetTipos();
			return;
		}
	}
}