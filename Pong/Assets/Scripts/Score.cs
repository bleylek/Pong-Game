using UnityEngine.EventSystems;
using UnityEngine;

public class Score : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    private void OnCollisionEnter2D(Collision2D collision) //when the ball collides, this will get called
    {

        Ball ball = collision.gameObject.GetComponent<Ball>();//this will give us the object that collided with our surface we cant guarantee it was the ball that collided with us. When our ball collides with the scoring zone
        if (ball != null) //it wasnt the ball collided with
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData); //we are going to trigger some event that indicates that someone scored
        }
    }
}
