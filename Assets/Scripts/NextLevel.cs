using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    public string tenmanchoi;
    public void loadmanchoimoi()
    {
        SceneManager.LoadScene(tenmanchoi);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            loadmanchoimoi();
        }
    }
}
