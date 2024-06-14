using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public string scene;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ShoppingCartCollider")
        {
            LoadScene();
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(scene);
    }
}
