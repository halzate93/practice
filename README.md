# Practice scripting 2016 questions
In this repository I've compilated a set of question which should be useful as an study tool to prepare for the coming final exam for the Scripting class. It includes both applied and theory questions.

The goal is for all of the students to contribute to solve the whole problem set in order to be prepared for the final exam and foster team-work using common tools in the game-development industry.

## How to submit a solution
In order to submit a solution students need to create a fork of this repository and solve the question there. Then they should make a pull request with their solution to the problem and if correct, I will merge the pool request to the code base and it will be available to everyone.

*If the answer solves a theory question the student should modify this README file and place the answer right below the question. This document is written using Markdown, a common formatted language on the internet used on blogs or reddit, to learn how to embed code and others you can go to [this link](https://daringfireball.net/projects/markdown/syntax)* 
0. How should you solve a theory question?

In order to solve a theory question you should place the answer right below the question and place any graphics, code, etc. There as well.

A test response should be done through a pull request.

![A cat image](http://i.imgur.com/lVlPvCB.gif =200x)

```c#
  if (cat)
    Debug.Log ("Meow");
```

*If the solution involves code, the students are expected to create a folder with the number of the question and the organizational folder structure we've used through the semester as follows*

![Example Folder Structure](http://i.imgur.com/Dbcdfg7.png =200x)

------------------------------------------------------
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

2. How do dictionaries work?, how fast is it to search for an element in a dictionary?. How does hashing have anything to do with it?

3. How would you enhance the performance of the following code using data structures?

```c#
public class Character
{
  public string greeting;
  public string name;
}

public class Greeter
{
  private List<Character> characters;
  
  public void Greet (string name)
  {
    foreach (Character c in characters)
    {
      if (c.name == name)
         Debug.Log (c.greeting);
    }
  }
}
```
