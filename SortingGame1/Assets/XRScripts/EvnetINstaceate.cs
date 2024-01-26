using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class EvnetINstaceate : MonoBehaviour
{
    public GameObject spawningObject;
    public GameObject spawningPoint;

    public UnityEvent myUnityEvent;
    
    
 public void OnTriggerEnter(Collider other)
 {
     myUnityEvent.Invoke();
     
     Instantiate(spawningObject, spawningPoint.transform.position, quaternion.identity);
     
     
 }
 
}
