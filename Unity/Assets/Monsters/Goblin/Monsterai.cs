using UnityEngine;
using System.Collections;

public class Monsterai : MonoBehaviour {

    public GameObject Player;
    private Transform target = null;
    public int MovSpeed;
    public float minDist;
   


	void Start () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") target = other.transform;
        Debug.Log("Löyty");
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") target = null;
        Debug.Log("Katosi");
    }


	// Update is called once per frame
	void Update () {
        if (target == null) return;
        
        transform.LookAt(target);
        /*if(Vector3.Distance(transform.position,target.position) >= MinDist){
            transform.position += transform.forward*MovSpeed*Time.deltaTime;
 
            if(Vector3.Distance(transform.position,target.position) <= MaxDist)
            {
                //Hyökkäykset ja muut tänne
            }*/
        float distance = Vector3.Distance(transform.position, target.position);
        Debug.Log("Välimatka saatu");
        bool tooClose = distance < minDist;
        Vector3 direction = tooClose ? Vector3.back : Vector3.forward;
        Debug.Log("Kohta lähtee");
        transform.Translate(direction * MovSpeed * Time.deltaTime);
        Debug.Log("Liikutaan");
 
}
}
