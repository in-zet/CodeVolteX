﻿using Microsoft.VisualBasic;
using System.Collections;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
        List<string> outputBuffer = new List<string>();
        int[] tempPos;
        int testCaseNum = int.Parse(sr.ReadLine());

        for (int testCase = 0; testCase < testCaseNum; testCase++)  // 각각의 테스트 케이스마다 시행
        {
            int[] boardInfo = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            Queue<int[]> q = new Queue<int[]>();
            int[][] cabs = new int[boardInfo[2]][];
            int bugNum = 0;
            byte[,] board = new byte[boardInfo[0], boardInfo[1]];  // 0: 없음, 1: 있음, 2: 방문함

            for (int i = 0; i < boardInfo[0]; i++)  // 보드 초기화
            {
                for (int j = 0; j < boardInfo[1]; j++)
                {
                    board[i, j] = 0;
                }
            }

            for (int cabIndex = 0; cabIndex < boardInfo[2]; cabIndex++)  // 배추 좌표 입력
            {
                cabs[cabIndex] = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                board[cabs[cabIndex][0], cabs[cabIndex][1]] = 1;
            }

            for (int i = 0; i < boardInfo[2]; i++)  // 연결 그래프 찾기 - BFS
            {
                tempPos = cabs[i];
                if (board[tempPos[0], tempPos[1]] != 2)  // 출발점 설정
                {
                    bugNum++;
                    board[tempPos[0], tempPos[1]] = 2;
                    q.Enqueue(cabs[i]);
                }

                while (q.Count != 0)  // BFS
                {
                    tempPos = q.Dequeue();

                    foreach (int[] availablePos in AvailablePos(boardInfo, tempPos))  // 연결된 노드 탐색
                    {
                        if (board[availablePos[0], availablePos[1]] == 1)
                        {
                            board[availablePos[0], availablePos[1]] = 2;
                            q.Enqueue(availablePos);
                        }
                    }
                }
            }

            sw.WriteLine(bugNum);
        }
        sr.Close();
        sw.Close();
        return;
    }

    static IEnumerable<int[]> AvailablePos(int[] bInfo, int[] targetPos)  // 가능한 연결된 노드 좌표 반복자
    {
        if (targetPos[0] != 0)
        {
            yield return new int[2] { targetPos[0] - 1, targetPos[1] };
        }

        if (targetPos[1] != 0)
        {
            yield return new int[2] { targetPos[0], targetPos[1] - 1 };
        }

        if (targetPos[0] != bInfo[0] - 1)
        {
            yield return new int[2] { targetPos[0] + 1, targetPos[1] };
        }

        if (targetPos[1] != bInfo[1] - 1)
        {
            yield return new int[2] { targetPos[0], targetPos[1] + 1 };
        }
    }
}
