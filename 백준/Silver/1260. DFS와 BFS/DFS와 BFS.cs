using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static List<int>[] graph;
    static bool[] visited;
    static int N, M, V;

    static void Main()
    {
        // 1. 입력 처리
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        N = input[0];
        M = input[1];
        V = input[2];

        graph = new List<int>[N + 1];

        for(int i = 0; i <= N; i++)
        {
            graph[i] = new List<int>();
        }

        for (int i = 0; i < M; i++)
        {
            var edge = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int u = edge[0];
            int v = edge[1];
            graph[u].Add(v);
            graph[v].Add(u);
        }

        for (int i = 1; i <= N; i++)
        {
            graph[i].Sort();
        }

        // 2. DFS 수행
        visited = new bool[N + 1];
        DFS(V);
        Console.WriteLine();

        // 3. BFS 수행
        visited = new bool[N + 1];
        BFS(V);
        Console.WriteLine();
    }
    static void DFS(int v)
    {
        // TODO: DFS 구현
        visited[v] = true;
        Console.Write($"{v} ");

        foreach (var child in graph[v])
        {
            if (!visited[child])
                DFS(child);
        }
    }

    static void BFS(int v)
    {
        // TODO: BFS 구현
        Queue<int> q = new Queue<int>();
        q.Enqueue(v);
        visited[v] = true;

        while (q.Count > 0)
        {
            int dq = q.Dequeue();
            Console.Write($"{dq} ");

            foreach(var child in graph[dq])
            {
                if(!visited[child])
                {
                    visited[child] = true;
                    q.Enqueue(child);
                }
            }
        }
    }
}