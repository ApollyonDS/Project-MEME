using UnityEngine;
using System.Collections;

public class LevelOneScript : MonoBehaviour {
    string message = "";
    bool msg = false;
    //public GameObject[] Bridge;
    // Use this for initialization
    void Start () {
        GameObject.FindGameObjectWithTag("BridgeParts").GetComponent<Rigidbody2D>().isKinematic = true;
        //Bridge = GameObject.FindGameObjectsWithTag("BridgeParts");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
       // Debug.Log("collde");
        if (this.tag == "SecretMSG1")
        {
            msg = true;
            Debug.Log("Collidede with trigger.");
            message = "There's nothing that way.";
        }

        else if (this.tag == "SecretMSG2")
        {
            msg = true;
            message = "Seriously, don't go there.\nIt's pointless.";
        }

        else if (this.tag == "SecretMSG3")
        {
            msg = true;
            message = "It's just a brick wall\nat the end bro.";
        }

        else if(this.tag == "BridgeTrap")
        {
            GameObject.FindGameObjectWithTag("BridgeParts").GetComponent<Rigidbody2D>().isKinematic = false;
            //foreach(GameObject part in Bridge)
            //{
            //    Destroy(part);
            //}
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        message = "";
        msg = false;
    }

    public void OnGUI()
    {
        if(msg == true)
        {
            GUI.color = Color.cyan;
            GUI.Button(new Rect(490, 230, 200, 38), message);
        }
        //GUI.Label(new Rect(Screen.width / 3, Screen.height/3, 100, 100), message);
    }
}
