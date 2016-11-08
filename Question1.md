1. Which data structure would be more suitable for this scenario and why?, write a short code that shows how it would be used for the methods *PlaceOrder (Order o)* and *AttendNext ()*:

  "I have a hot-dog game where the clients place their orders one by one and I have to serve them in the order they place    their orders, in other words the first client to place an order should be the first served."
  
  Answer:
  
  For this type of game where it's required that the first to enter, be the first to come out, i robaly use Queue data structure.
  
  Example code:
  
```c#
using UnityEngine;
using System.Collections;

public class Question1 : MonoBehaviour
{
    private float timeToNewClient;
    private float timeToNewClientTemp;
    private Queue clientsList;
    private GameObject[] clients = new GameObject[5];

    void Start()
    {
        timeToNewClientTemp = timeToNewClient;
    }

    void Update()
    {
        int clientCount = clients.Length - 1;

        timeToNewClient -= Time.deltaTime;

        if (timeToNewClient <= 0)
        {
            clientCount--;
            clientsList.Enqueue(clients[clientCount]);

            timeToNewClient = timeToNewClientTemp;
        }
    }

    private void OrderReady()
    {
        clientsList.Dequeue();
    }
}
```
