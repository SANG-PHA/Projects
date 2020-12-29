using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlaneController : MonoBehaviour
{
  public float TargetY;
  public float TargetY2;

  float _velocity;
  public int player_num;
  private bool isDead = false;
  private bool isDead2 = false;

  void Update()
  {
    // Get the current position
    var position = transform.position;
    var position2 = transform.position;
    /*if (player_num == 0){
      switch (GameManager.State)
      {
      case eState.Alive:
      
        // Move towards our `TargetY` value smoothly
        position.y = Mathf.SmoothDamp(position.y, TargetY, ref _velocity, 0.1f);
        break;
      
      case eState.Dead1:
        // Spin around if we're dead
        transform.Rotate(0, 0, 10f);
        // And head downwards
        position.y = transform.position.y - 0.07f;
        break;
      }
    }*/
    if (player_num == 0){
      if( isDead == false){
        position.y = Mathf.SmoothDamp(position.y, TargetY, ref _velocity, 0.1f);
      }
      else if (isDead == true){
        transform.Rotate(0, 0, 10f);
        position.y = transform.position.y - 0.07f;
      }
      transform.position = position;
    }
    /*if (player_num == 1){
      switch(GameManager.State){
        case eState.Alive:
        position2.y = Mathf.SmoothDamp(position2.y, TargetY2, ref _velocity, 0.1f);
        break;
        case eState.Dead2:
        transform.Rotate(0,0,10f);
        position2.y = transform.position.y - 0.07f;
        break;
      }
      transform.position = position2;
    }*/
    if (player_num == 1){
      if (isDead2 == false){
        position2.y = Mathf.SmoothDamp(position2.y, TargetY2, ref _velocity, 0.1f);
      }
      else if (isDead2 == true){
        transform.Rotate(0,0,10f);
        position2.y = transform.position.y - 0.07f;
      }
      transform.position = position2;
    }
    
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    
    // If we hit something, find our `GameManager` and die
    if (isDead == false && player_num == 0){
      
      FindObjectOfType<GameManager>().Die1();
      isDead = true;
    }

    if (player_num == 1){
      FindObjectOfType<GameManager>().Die2();
      isDead2 = true;
    }


    /*if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }*/
  }
}


