﻿using System;
using System.Data;

class Engine
{
    public Engine()
    {
        gameObjects = new List<GameObject>(); //초기화
        isRunning = true;
    }

    ~Engine()
    {

    }

    public List<GameObject> gameObjects;
    public bool isRunning;

    public void Init()
    {
        Input.Init();
    }

    public void LoadScene(string sceneName)
    {
        string Dir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string[] map = File.ReadAllLines(Dir + "/../data/" + sceneName);

        for(int y = 0; y < map.Length; ++y)
        {
            for(int x = 0; x < map[y].Length; ++x)
            {
                if(map[y][x] == '*')
                {
                    Instantiate(new Wall(x,y));
                    Instantiate(new Floor(x, y));
                    //newGameObject.x = x;
                    //newGameObject.y = y;
                }
                else if (map[y][x] == 'P')
                {
                    Instantiate(new Player(x, y));
                    Instantiate(new Floor(x, y));
                }
                else if (map[y][x] == 'G')
                {
                    Instantiate(new Goal(x, y));
                    Instantiate(new Floor(x, y));
                }
                else if (map[y][x] == 'M')
                {
                    Instantiate(new Monster(x, y));
                    Instantiate(new Floor(x, y));
                }
                else if (map[y][x] == ' ')
                {
                    Instantiate(new Floor(x, y));
                }
            }
        }
        //Load();

    }

    public void Run()
    {
        while (isRunning)
        {
            ProcessInput();
            Update();
            Render();
        }
    }

    public void Term()
    {
        gameObjects.Clear();
    }

    public GameObject Instantiate(GameObject newGameObject)
    {
        gameObjects.Add(newGameObject);
        return newGameObject;
    }

    protected void ProcessInput()
    {
        Input.keyInfo = Console.ReadKey();
    }

    protected void Update()
    {
        foreach (GameObject gameObject in gameObjects)
        {
            gameObject.Update();
        }
    }

    protected void Render()
    {
        //for(int i = 0; i < gameObjects.Count; i++)
        //{
        //    gameObjects[i].Render();
        //}
        Console.Clear();

        foreach(GameObject gameObject in gameObjects)
        {
            gameObject.Render();
        }
    }
}