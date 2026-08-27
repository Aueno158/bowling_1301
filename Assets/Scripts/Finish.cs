using System.Net.NetworkInformation;
using UnityEngine;

public class Finish : MonoBehaviour
{
        private void OnTriggerEnter(Collider other)
    {
        Pin p = other.GetComponent<Pin>();
        
        if (p != null)
        {
            GameManager.Instance.ShowScoreText(p.Point);
            Destroy(p.gameObject);
        }
    }
}
