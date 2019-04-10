using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		Operators();
		hello();
		bye();
	}

	public void Operators()
	{

		// Multiplikative Operatoren
		Debug.Log("Multiplikative Operatoren: * " + (3*4));
		Debug.Log("Multiplikative Operatoren: / " + (12/4));
		Debug.Log("Multiplikative Operatoren: % " + (3%4));
		
		//Additive Operatoren
		Debug.Log("Additive Operatoren: + " + (3+4));
		Debug.Log("Additive Operatoren: - " + (8-4));

		//Relationale Operatoren 
		Debug.Log("Relationale Operatoren: < " + (3<4));
		Debug.Log("Relationale Operatoren: <= " + (3<=4));
		Debug.Log("Relationale Operatoren: >" + (3>4));
		Debug.Log("Relationale Operatoren: >= " + (3>=4));

		//Gleichheits Operatoren 
		Debug.Log("Gleichheits Operatoren: ==" + (5==5));
		Debug.Log("Gleichheits Operatoren: !=" + (5!=5));

		//Logische Operatoren 
		Debug.Log("Logische Operatoren: &" + (3&5));
		Debug.Log("Logische Operatoren: |" + (3|5));
		Debug.Log("Logische Operatoren: ^" + (3^5));


		
	}

	public void XY()
	{
		
	}

	public void hello()
	{
		Debug.Log("Addieren: +" + (8+5));
	}

	
	public void bye()
	{
		Debug.Log("Multiplizieren: *" + (5*5));
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}