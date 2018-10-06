using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ce script est appliqué à la caméra et contient un tableau publique des éléments à supprimer s'ils sortent de vue
public class IsVisible : MonoBehaviour
{ 
    Camera cam;
    public GameObject[] Joueurs; //Peut être appliqué aux bébés aussi?

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        for (int i = 0; i < Joueurs.Length; i++)
        {
            if (Joueurs[i])
            {
                Vector3 viewPos = cam.WorldToViewportPoint(Joueurs[i].GetComponent<Transform>().position); //Vérifie que le joueur i est visible depuis la caméra
                if (viewPos.x < 0 || viewPos.x > 1 || viewPos.y < 0 || viewPos.y > 1)
                {
                    Destroy(Joueurs[i]); //Dans ce cas-ci, un joueur en dehors de la zone de visibilité est détruit
                }
                
            }
        }
    }
}
