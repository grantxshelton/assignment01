using UnityEngine;
using UnityEngine.UI;
public class Credits : MonoBehaviour
{
    public Text playerThanks;
    public static string playerName = ReadInput.playerName;
    public void Awake()
    {
        string thanksmsg = "THANK YOU " + playerName.ToUpper();
        playerThanks.text = thanksmsg;
    }

    public void Quit()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
