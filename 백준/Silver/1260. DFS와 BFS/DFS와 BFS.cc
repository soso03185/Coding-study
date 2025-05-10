#include <iostream>
#include <list>
#include <vector>
#include <queue>
#include <algorithm>

using namespace std;

class Graph_BFS
{
public:
	Graph_BFS(int _numVertices)
	{
		numVertices = _numVertices;
		visited.resize(_numVertices, false);
		data.resize(_numVertices);
	}

private:
	int numVertices = 0;
	vector<bool> visited;
	vector<list<int>> data;

public:
	void AddEdge(int _src, int _dest)
	{
		data[_src].push_back(_dest);
		data[_dest].push_back(_src);
	}

	void BFS(int _startIndex)
	{
		queue<int> que;

		visited[_startIndex] = true;
		que.push(_startIndex);

		while (!que.empty())
		{					
			int index = que.front();
			cout << index << " ";
			que.pop();
			
			data[index].sort();

			for (auto child : data[index])
			{
				if (!visited[child])
				{
					visited[child] = true;
					que.push(child);
				}
			}
		}
	}
};

class Graph_DFS
{
public:
	Graph_DFS(int _numVertices)
	{
		numVertices = _numVertices;
		visited.resize(_numVertices, false);
		data.resize(_numVertices);
	}

private:
	int numVertices = 0;
	vector<bool> visited;
	vector<list<int>> data;

public:
	void AddEdge(int _src, int _dest)
	{
		data[_src].push_back(_dest);
		data[_dest].push_back(_src);
	}

	void DFS(int _startIndex)
	{
		visited[_startIndex] = true;

		cout << _startIndex << " ";

		data[_startIndex].sort();

		for (int child : data[_startIndex])
		{
			if (!visited[child])
				DFS(child);
		}
	}
};

int main()
{
	int vertecsNum = 0;
	int lineNum = 0;
	int startNum = 0;

	cin >> vertecsNum >> lineNum >> startNum;

	Graph_BFS bfs(vertecsNum + 1);
	Graph_DFS dfs(vertecsNum + 1);

	int a, b;	

	for (int i = 0; i < lineNum; i++)
	{
		cin >> a >> b;

		bfs.AddEdge(a,b);
		dfs.AddEdge(a,b);
	}

	dfs.DFS(startNum);

	cout << endl;

	bfs.BFS(startNum);
}