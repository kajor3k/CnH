using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
    public int timeOutDestructor;

}

public class Shooting : MonoBehaviour {

    Rigidbody missile;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        

        if (Input.GetKey(KeyCode.G))
        {



            Rigidbody clone = Instantiate(missile, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(new Vector3(0, 0, 1));
      
        }
    
	}
}
