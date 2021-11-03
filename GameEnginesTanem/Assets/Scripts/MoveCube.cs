using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
  [SerializeField]
  private bool _isMovingForward = true;
    // Start is called before the first frame update
    [SerializeField]
    private float _speed =1f;
    [SerializeField]
    private GameObject _myTarget;

    void Start()
    {

    }

    // Update is called once per frame
    void Update(){
    //back and forth on z achse
    if(transform.position.z >=10){
      _isMovingForward=false;
    }else if(transform.position.z <= -5){
      _isMovingForward=true;
    }
    if(_isMovingForward){
      transform.position += new Vector3(0,0,1f) * Time.deltaTime * _speed;
    }else{
      transform.position -= new Vector3(0,0,1f)* Time.deltaTime * _speed;
    }
    //RANDOM VALUE
    float randomValue = UnityEngine.Random.Range(-10f, 10f);
    //Rotation
    transform.rotation *= Quaternion.Euler(0,0,10);

    _myTarget.transform.position =transform.position;
}
private void OnCollisionEnter(Collision other){
  _isMovingForward = !_isMovingForward;
}
}
