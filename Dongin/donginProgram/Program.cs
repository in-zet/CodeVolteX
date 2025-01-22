﻿using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.ComponentModel;
using System.Security.AccessControl;

class Program
{
    static void Main()
    {
        StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

        int[] graphInfo = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);  // 정점, 간선
        List<int>[] connects = new List<int>[graphInfo[0] + 1];  // 연결되어있는 정점들의 리스트, index 1부터 시작
        bool[] isVisited = new bool[graphInfo[0] + 1];  // index 1부터 시작
        int[] tempEdge;
        int ccNum = 0;

        for (int i = 1; i <= graphInfo[0]; i++)  // 초기화
        {
            isVisited[i] = false;
            connects[i] = new List<int>();
        }

        for (int edgeIndex = 0; edgeIndex < graphInfo[1]; edgeIndex++)  // 간선 입력
        {
            tempEdge = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            connects[tempEdge[0]].Add(tempEdge[1]);
            connects[tempEdge[1]].Add(tempEdge[0]);
        }

        for (int vertex = 1; vertex <= graphInfo[0]; vertex++)
        {
            if (!isVisited[vertex])
            {
                Visit(vertex);
                ccNum++;
            }
        }

        sw.WriteLine(ccNum);

        sr.Close();
        sw.Close();
        return;

        void Visit(int vertex)  // DFS 재귀 탐색
        {
            isVisited[vertex] = true;
            foreach (int connectedVertex in connects[vertex])
            {
                if (!isVisited[connectedVertex])
                {
                    Visit(connectedVertex);
                }
            }
        }
    }
}
