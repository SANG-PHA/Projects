using UnityEngine;
using System.IO.Ports;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class GameManager : MonoBehaviour
{
  public static GameManager instance;
  public PlaneController PlayerPlane;
  public PlaneController PlayerPlane2;
  public GameObject Camera;

  public float mgameSpeed = 6f;
  public float mgameSpeed2 = 6f;

  SerialPort spp = new SerialPort("COM7", 9600);
  SerialPort spp2 = new SerialPort("COM8", 9600);

  public bool gameStart =  false;
  public bool gameDead = false;
  public bool gameDead2 = false;
  public GameObject gameOverText;
  public GameObject quitGameText;

  public Text counterText;
  public float seconds, minutes;

  string fileName = "User_information_Player1";
  string fileName2 = "User_information_Player2";
  public float dataA = 0.0f;
  public float dataB = 0.0f;
  

  void Start()
  {
    gameStart = true;
    if (SoundManager.instance.canPlayMusic){
      SoundManager.instance.musicSource.Play();
    }
    if (!instance){
      instance = this;
    }
    else if (instance != this){
      Destroy(gameObject);
    }

    OpenConnection();
  }

  public void OpenConnection(){
    if (spp != null){
      if (spp.IsOpen){
        spp.Close();
        print("Closing port, because it was already open!");
      }
      else{
        spp.Open();
        //spp.ReadTimeout = 16;
        print("Port Opened!");
      }
    }
    else{
      if (spp.IsOpen){
        print("Port is already open");
      }
      else{
        print("Port == null");
      }
    }
    /// check connection port 2
    if (spp2 != null){
      if (spp2.IsOpen){
        spp2.Close();
        print("Closing port2, because it was already open!");
      }
      else{
        spp2.Open();
        //spp2.ReadTimeout = 16;
        print("Port2 Opened!");
      }
    }
    else{
      if (spp2.IsOpen){
        print("Port2 is already open");
      }
      else{
        print("Port2 == null");
      }
    }
  }

  void OnApplicationQuit(){
    spp.Close();
    spp2.Close();
  }

  void Update()
  {
    if (gameDead == true && gameDead2 == true){ 
      if (gameDead == true && gameDead2 == true && Input.GetKeyDown("space")){
        //SceneManager.LoadScene("Menu");
        Debug.Log("Quit");
        gameOverText.SetActive(false);
        quitGameText.SetActive(true);
        Application.Quit();
        ///EditorApplication.Exit(0);
      }
      return;
    }
    
    // Set the `TargetY` of the plane1 to the latest value that our `GameManager` has received from SerialPort
    PlayerPlane.TargetY = -2.97f + float.Parse(spp.ReadLine())/100.0f;
    dataA = (float.Parse(PlayerPlane.TargetY.ToString()) + 2.97f)*100.0f;
    Debug.Log("dataA: "+dataA);
    ///Debug.Log(PlayerPlane.TargetY);

    // Move our plane and camera
    var movement = mgameSpeed * Time.deltaTime;
    PlayerPlane.transform.Translate(movement, 0, 0);
    Camera.transform.Translate(movement, 0, 0);

    // Set the `TargetY2` of the plane2 to the latest value that our `GameManager` has received from SerialPort
    PlayerPlane2.TargetY2 = -2.97f + float.Parse(spp2.ReadLine())/100.0f;
    dataB = (float.Parse(PlayerPlane2.TargetY2.ToString()) + 2.97f)*100.0f;
    ///Debug.Log(PlayerPlane2.TargetY2);

    // Move our plane2 and camera
    var movement2 = mgameSpeed2 * Time.deltaTime;
    PlayerPlane2.transform.Translate(movement2, 0, 0);
    //Camera.transform.Translate(movement2, 0, 0);

    // set time count for game playing
    minutes = (int)(Time.time / 60f);
    seconds = (int)(Time.time % 60f);
    counterText.text = "Time: " + minutes.ToString("00")+":"+seconds.ToString("00");
    
    // Add the data from player 1 into csv file
    if (gameDead == false){
      try{
        string textAdd = "";
        textAdd = string.Format("\"{0}\"\n", dataA.ToString());
        File.AppendAllText(fileName+".csv", textAdd);
      }
      catch (System.Exception e){
        Debug.LogWarning("Exception writing to data file :\n" +e);
      }
    }
    
    // Add the data from Player 2 into csv file
    if (gameDead2 == false){
      try{
        string textAdd2 = "";
        textAdd2 = string.Format("\"{0}\"\n", dataB.ToString());
        File.AppendAllText(fileName2 + ".csv", textAdd2);
      }
      catch (System.Exception e){
        Debug.LogWarning("Exception writing to data file :\n" + e);
      }
    }  
  }

  public void Die1()
  {
    Debug.Log("hiting1");
    gameDead = true;
    // Checking if the both players are die, so the the game over text appear.
    if (gameDead == true && gameDead2 == true){
      gameOverText.SetActive(true);
      if (SoundManager.instance.canPlayMusic){
        SoundManager.instance.musicSource.Stop();
      }
    }  
  }
  public void Die2()
  {
    Debug.Log("hiting2");
    gameDead2 = true;
    // Checking if the both players are die, so the the game over text appear.
    if (gameDead == true && gameDead2 == true){
      gameOverText.SetActive(true);
      if (SoundManager.instance.canPlayMusic){
        SoundManager.instance.musicSource.Stop();
      } 
    }
  }
}

