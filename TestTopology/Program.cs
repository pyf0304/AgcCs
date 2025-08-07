using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestTopology
{
    class p
    {
        public int x;
        public int st;
    };
    class Program
    {
        List<int>[] r = new List<int>[101];
        //int[][] r = new int[101][100];
        int[] rk = new int[101];
        //vector<int> ans[101];
        List<int>[] ans = new List<int>[101];
        int[] num = new int[101];
        int flag;
        public void Init()
        {
            for (int i = 0; i < 101; i++)
            {
                r[i] = new List<int>();
                ans[i] = new List<int>();
            }
        }
        public void input()
        {
            int t1, t2;
            while (true)
            {

                string strInput = Console.ReadLine();
                string[] sstrInput = strInput.Split(' ');
                if (sstrInput.Length < 2) break;

                t1 = int.Parse(sstrInput[0]);
                t2 = int.Parse(sstrInput[1]);
                //		scanf("%d %d", &t1, &t2);
                if (t1 == 0 && t2 == 0)
                {
                    break;
                }
                //r[t1][rk[t1]] = t2;
                //rk[t1]++;
                r[t1].Add(t2);
                rk[t1]++;
                num[t2]++;

                //r[t1].Add(t2);
                //num[t2]++;
            }
        }
        bool cal(int n)
        {
            int i;
            bool[] flag = new bool[101];
            int count;
            //vector<int>::iterator it;

            p temp = new p();
            Queue<p> qu = new Queue<p>();
            //memset(flag, 0, sizeof(flag));
            count = n;
            temp.st = 1;
            for (i = 1; i <= n; i++)
            {
                if (num[i] == 0)
                {
                    temp.x = i;
                    qu.Enqueue(temp);
                    flag[i] = true;
                }
            }
            while (qu.Count > 0)
            {
                for (i = 0; i < rk[qu.Peek().x]; i++)
                {
                    num[r[qu.Peek().x][i]]--;
                    if (num[r[qu.Peek().x][i]] == 0 && flag[r[qu.Peek().x][i]] == false)
                    {
                        flag[r[qu.Peek().x][i]] = true;
                        temp = new p();
                        temp.st = qu.Peek().st + 1;
                        temp.x = r[qu.Peek().x][i];
                        qu.Enqueue(temp);
                    }
                }
                ans[qu.Peek().st].Add(qu.Peek().x);
                qu.Dequeue();
                count--;
            }

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int n;
            bool iswrong;
            int i;
            Console.WriteLine("请输入课程数量n（编号1-n）：");
            string strInput = Console.ReadLine();
            n = int.Parse(strInput);
            //            scanf("%d", &n);
            Console.WriteLine("请输入课程关系（格式“A B”，表示要学B就必须先把A学掉。以“0 0”表示结束）：\n");
            Program PP = new Program();
            PP.Init();
            PP.input();
            iswrong = PP.cal(n);
            i = 1;
            if (iswrong == true)
            {
                Console.WriteLine("课程关系错误！\n");
            }
            else
            {
                while (PP.ans[i].Count > 0)
                {
                    Console.WriteLine(string.Format("第{0}批课程：", i));
                    while (PP.ans[i].Count > 0)
                    {
                        Console.WriteLine(PP.ans[i][PP.ans[i].Count - 1]);
                        PP.ans[i].RemoveAt(PP.ans[i].Count - 1);
                    }
                    Console.WriteLine("");
                    i++;
                }
            }
            Console.ReadLine();
            return;
        }

    }
}

