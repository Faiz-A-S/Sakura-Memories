using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<string> inventory;
    bool pindah = false;

    //private 
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("ambil") && Input.GetKey("e"))
        {
            Debug.Log("coll");
            inventory.Add(collision.gameObject.GetComponent<ItemType>().nameType);
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("teleport") && Input.GetKey("e"))
        {
            if (pindah == false)
            {
                Debug.Log("Belum Ambil Kunci");
                Pindah();
            }
            else
            {
            Pindah();
            }
            
        }
    }
    void Pindah()
    {
        for (int i = 0; i < inventory.Count; i++) {
            if (inventory[i] == "key")
            {
                pindah = true;
                Debug.Log("nice" + i);
                inventory.RemoveAt(i);
            }
            
        }
    }
}
