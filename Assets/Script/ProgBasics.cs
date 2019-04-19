using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {
	public int test1;
	public float test2;
	public string test3;

	// Use this for initialization
	void Start () {
		test1 = 1;
		Debug.Log ("test 1 in Start " + test1);

		Operators ();
		VoidMethod ();
		hello ();
		ocean ();

		// add values for parameters
		AddNumbers (5, 3);
		MultNumbers (4, 2, 3, 8);
		SameNumbers (5, 5);
		love (4, 5);

		// combine all methodes
		Combine ();

		// return type
		Debug.Log (MyText ("lmartinusic"));
		string drama = MyText ("lmartinusic");
		Debug.Log ("neu " + drama);

		//run value
		Debug.Log (billie ("lmartinusic"));
		string eilish = billie ("lmartinusic");
		Debug.Log ("country " + eilish);
	}

	// Methode Operatoren
	public void Operators () {

		// Multiplikative Operatoren
		Debug.Log ("Multiplikative Operatoren: * " + (3 * 4));
		Debug.Log ("Multiplikative Operatoren: / " + (12 / 4));
		Debug.Log ("Multiplikative Operatoren: % " + (3 % 4));

		//Additive Operatoren
		Debug.Log ("Additive Operatoren: + " + (3 + 4));
		Debug.Log ("Additive Operatoren: - " + (8 - 4));

		//Relationale Operatoren 
		Debug.Log ("Relationale Operatoren: < " + (3 < 4));
		Debug.Log ("Relationale Operatoren: <= " + (3 <= 4));
		Debug.Log ("Relationale Operatoren: >" + (3 > 4));
		Debug.Log ("Relationale Operatoren: >= " + (3 >= 4));

		//Gleichheits Operatoren 
		Debug.Log ("Gleichheits Operatoren: ==" + (5 == 5));

		Debug.Log ("Gleichheits Operatoren: !=" + (5 != 5));

		//Logische Operatoren   
		Debug.Log ("Logische Operatoren: true&true " + (true & true));
		Debug.Log ("Logische Operatoren: false&&true " + (false && true));
		Debug.Log ("Logische Operatoren: false|true " + (false | true));
		Debug.Log ("Logische Operatoren: true||false " + (true || false));

	}

	public void hello () {
		Debug.Log ("Addieren ist: +" + (8 + 5));
	}

	public void ocean () {
		Debug.Log ("Multiplizieren ist: +" + (8 * 5));
	}

	public void VoidMethod () {
		Debug.Log ("This is a method with no return type");
	}

	// methode add parameters, new variables
	public void AddNumbers (int a, int b) {
		int c = a + b;
		Debug.Log ("add numbers = " + c);
		test1 = 3;
		Debug.Log ("test1 in AddNumbers " + test1);
	}

	public void MultNumbers (int a, int b, int c, int d) {
		int e = a * b * c * d;
		Debug.Log ("multiply numbers = " + e);
	}

	public void SameNumbers (int a, int b) {

		bool c = a == b;
		Debug.Log ("same numbers = " + c);
	}

	// combines all methodes
	public void Combine () {
		AddNumbers (7, 2);
		MultNumbers (5, 2, 4, 6);
	}

	// return type methode string
	public string MyText (string myName) {
		return "Drama" + " " + myName;
	}

	public string billie (string eilish) {
		//run the return after commiting the variable billie
		return "happy" + " " + eilish;
	}

	//Restzahl der beiden Operanden berechnen
	public void love (int a, int b) {
		int c = a % b;
		Debug.Log ("Restzahl= " + c);
	}

	// Update is called once per frame
	void Update () {

	}
}