using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    bool hasended = false;

    public void Endgame()
    {
        if (hasended)
            return;
        StartCoroutine(playend());
        hasended = true;
    }

    IEnumerator playend ()
    {
        Debug.Log("gameover");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
