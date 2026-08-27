using UnityEngine;

public class Pin : MonoBehaviour
{
   [SerializeField]
   private int point;
   public int Point
    { 
    get { return point;} 
    set { point = value;} 
    }
    void Start()
    {
    }
    void Update()
    {
        
    }
}
