using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetallverarbeitungEventHandler : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Product;

    public void SwitchToProduct()
    {
        Menu.SetActive(false);
        Product.SetActive(true);
    }

    public void SwitchToMenu()
    {
        Menu.SetActive(true);
        Product.SetActive(false);
    }
}
