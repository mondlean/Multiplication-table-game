using System;

namespace MultiplicationTable
{
 
        class Program
        {
            static void Main(string[] args)
            {
                int ans;
                bool a;
                int fstnum;
                int sndnum;
                int sco;
            int life;
                sco = 0;
            life = 5;
                string yn;
                Random ren = new Random();
                Console.WriteLine("구구단 게임");
                Console.WriteLine("시작하시겠습니까? y:예 | n:아니오");
                yn = Console.ReadLine();
                if (yn == "y")//구구단 시작
                {
                    a = true;
                    while (a)//
                    {
                        fstnum = ren.Next(2, 10);
                        sndnum = ren.Next(1, 10);
                        Console.WriteLine(fstnum + "x" + sndnum + "=?");
                        ans = int.Parse(Console.ReadLine());
                        if (ans == fstnum * sndnum)
                        {
                            sco++;
                            Console.WriteLine("맞았습니다");
                            Console.WriteLine("맞은 개수 :" + sco + "목숨" + life);

                        }
                        else
                        {
                            Console.WriteLine("틀렸습니다");
                            life--;
                            Console.WriteLine("맞은 개수 :" + sco + "목숨" + life);

                            if (life == 0)
                            {
                            Console.WriteLine("game over");
                                a = false;
                            }
                        }
                    }

                }
                else if (yn == "n")
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                }


            }
        }
    }


