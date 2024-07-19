using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelIndi : MonoBehaviour {
    WheelController wheelController;
    int wheelDegree;
    GameObject n1,n2,n3,n4,n5,n6,n7,n8,n9,n10,n11,n12,n13,n14,n15,n16,n17,n18,n19,n20,n21,
        n22,n23,n24,n25,n26,n27,n28,n29,n30,n31,n32,n33,n34,n35,n36,n37,n38,n39,n40,n41,n42;
    // Use this for initialization

	void Start () {

        
        GameObject wheelIndi = GameObject.Find("wheelIndi2");
        GameObject wheel = GameObject.FindGameObjectWithTag("wheel");
        wheelController =  wheel.GetComponent<WheelController>();
        //green
        n1 = wheelIndi.transform.GetChild(1).gameObject;
        n2 = wheelIndi.transform.GetChild(2).gameObject;
        n3 = wheelIndi.transform.GetChild(3).gameObject;
        n4 = wheelIndi.transform.GetChild(4).gameObject;
        n5 = wheelIndi.transform.GetChild(5).gameObject;
        n6 = wheelIndi.transform.GetChild(6).gameObject;
        n7 = wheelIndi.transform.GetChild(7).gameObject;
        n8 = wheelIndi.transform.GetChild(8).gameObject;
        n9 = wheelIndi.transform.GetChild(9).gameObject;
        n10 = wheelIndi.transform.GetChild(10).gameObject;
        n11 = wheelIndi.transform.GetChild(11).gameObject;
        n12 = wheelIndi.transform.GetChild(12).gameObject;
        n13 = wheelIndi.transform.GetChild(13).gameObject;
        n14 = wheelIndi.transform.GetChild(14).gameObject;
        n15 = wheelIndi.transform.GetChild(15).gameObject;
        n16 = wheelIndi.transform.GetChild(16).gameObject;
        n17 = wheelIndi.transform.GetChild(17).gameObject;
        n18 = wheelIndi.transform.GetChild(18).gameObject;
        n19 = wheelIndi.transform.GetChild(19).gameObject;
        n20 = wheelIndi.transform.GetChild(20).gameObject;
        n21 = wheelIndi.transform.GetChild(21).gameObject;

        //red
        n22 = wheelIndi.transform.GetChild(22).gameObject;
        n23 = wheelIndi.transform.GetChild(23).gameObject;
        n24 = wheelIndi.transform.GetChild(24).gameObject;
        n25 = wheelIndi.transform.GetChild(25).gameObject;
        n26 = wheelIndi.transform.GetChild(26).gameObject;
        n27 = wheelIndi.transform.GetChild(27).gameObject;
        n28 = wheelIndi.transform.GetChild(28).gameObject;
        n29 = wheelIndi.transform.GetChild(29).gameObject;
        n30 = wheelIndi.transform.GetChild(30).gameObject;
        n31 = wheelIndi.transform.GetChild(31).gameObject;
        n32 = wheelIndi.transform.GetChild(32).gameObject;
        n33 = wheelIndi.transform.GetChild(33).gameObject;
        n34 = wheelIndi.transform.GetChild(34).gameObject;
        n35 = wheelIndi.transform.GetChild(35).gameObject;
        n36 = wheelIndi.transform.GetChild(36).gameObject;
        n37 = wheelIndi.transform.GetChild(37).gameObject;
        n38 = wheelIndi.transform.GetChild(38).gameObject;
        n39 = wheelIndi.transform.GetChild(39).gameObject;
        n40 = wheelIndi.transform.GetChild(40).gameObject;
        n41 = wheelIndi.transform.GetChild(41).gameObject;
        n42 = wheelIndi.transform.GetChild(42).gameObject;

        

    }
	
	// Update is called once per frame
	void Update () {

        wheelDegree = (int)wheelController.rudderReader();
        wheelDegree /= 16;
        Debug.Log(wheelDegree);
        //start port
        if (wheelDegree > 2)
            n22.GetComponent<Renderer>().material.color = Color.red;
            else
                n22.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 4)
            n23.GetComponent<Renderer>().material.color = Color.red;
            else
                n23.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 6)
            n24.GetComponent<Renderer>().material.color = Color.red;
            else
                n24.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 8)
            n25.GetComponent<Renderer>().material.color = Color.red;
            else
                n25.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 10)
            n26.GetComponent<Renderer>().material.color = Color.red;
            else
                n26.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 12)
            n27.GetComponent<Renderer>().material.color = Color.red;
            else
                n27.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 14)
            n28.GetComponent<Renderer>().material.color = Color.red;
            else
                n28.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 16)
            n29.GetComponent<Renderer>().material.color = Color.red;
            else
                n29.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 18)
            n30.GetComponent<Renderer>().material.color = Color.red;
            else
                n30.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 20)
            n31.GetComponent<Renderer>().material.color = Color.red;
            else
                n31.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 22)
            n32.GetComponent<Renderer>().material.color = Color.red;
            else
                n32.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 24)
            n33.GetComponent<Renderer>().material.color = Color.red;
            else
                n33.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 26)
            n34.GetComponent<Renderer>().material.color = Color.red;
            else
                n34.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 28)
            n35.GetComponent<Renderer>().material.color = Color.red;
            else
                n35.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 30)
            n36.GetComponent<Renderer>().material.color = Color.red;
            else
                n36.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 32)
            n37.GetComponent<Renderer>().material.color = Color.red;
            else
                n37.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 34)
            n38.GetComponent<Renderer>().material.color = Color.red;
            else
                n38.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 36)
            n39.GetComponent<Renderer>().material.color = Color.red;
            else
                n39.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 38)
            n40.GetComponent<Renderer>().material.color = Color.red;
            else
                n40.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 40)
            n41.GetComponent<Renderer>().material.color = Color.red;
            else
                n41.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree > 42)
            n41.GetComponent<Renderer>().material.color = Color.red;
        else
            n41.GetComponent<Renderer>().material.color = Color.white;

        //start stardboard
        if (wheelDegree < -2)
            n21.GetComponent<Renderer>().material.color = Color.green;
            else
                n21.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -4)
            n20.GetComponent<Renderer>().material.color = Color.green;
            else
                n20.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -6)
            n19.GetComponent<Renderer>().material.color = Color.green;
            else
                n19.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -8)
            n18.GetComponent<Renderer>().material.color = Color.green;
            else
                n18.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -10)
            n17.GetComponent<Renderer>().material.color = Color.green;
            else
                n17.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -12)
            n16.GetComponent<Renderer>().material.color = Color.green;
            else
                n16.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -14)
            n15.GetComponent<Renderer>().material.color = Color.green;
            else
                n15.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -16)
            n14.GetComponent<Renderer>().material.color = Color.green;
            else
                n14.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -18)
            n13.GetComponent<Renderer>().material.color = Color.green;
            else
                n13.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -20)
            n12.GetComponent<Renderer>().material.color = Color.green;
            else
                n12.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -22)
            n11.GetComponent<Renderer>().material.color = Color.green;
            else
                n11.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -24)
            n10.GetComponent<Renderer>().material.color = Color.green;
            else
                n10.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -26)
            n9.GetComponent<Renderer>().material.color = Color.green;
            else
                n9.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -28)
            n8.GetComponent<Renderer>().material.color = Color.green;
            else
                n8.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -30)
            n7.GetComponent<Renderer>().material.color = Color.green;
            else
                n7.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -32)
            n6.GetComponent<Renderer>().material.color = Color.green;
            else
                n6.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -34)
            n5.GetComponent<Renderer>().material.color = Color.green;
            else
                n5.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -36)
            n4.GetComponent<Renderer>().material.color = Color.green;
            else
                n4.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -38)
            n3.GetComponent<Renderer>().material.color = Color.green;
            else
                n3.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -40)
            n2.GetComponent<Renderer>().material.color = Color.green;
            else
                n2.GetComponent<Renderer>().material.color = Color.white;
        if (wheelDegree < -42)
            n1.GetComponent<Renderer>().material.color = Color.green;
            else
                n1.GetComponent<Renderer>().material.color = Color.white;


    }
}
