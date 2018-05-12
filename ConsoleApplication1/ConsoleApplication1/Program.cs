using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team
{
    class Program
    {
        static void Main(string[] args)
        {

            // 輸入資料
            string[] name = { "葉俊廷", "張澤瑜", "龘䶛䨻䎱㸞蚮䡶䴞䴝䯬䬛䰕㹚王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "張鈺慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新張豐愷", "世新遲正雯", "世新周詮" };

            // 分組迴圈跑動的次數
            int n = 1;

            // 宣告隨機亂數
            Random rand = new Random();

            // 宣告一個list
            List<string> nameList = new List<string>();

            // 讓使用者輸入人數
            Console.WriteLine("請輸入每一組的人數(人數不可小於2或大於10):");

            // 宣告分配每一組的人數
            int minmax = int.Parse(Console.ReadLine());

            if (minmax < 2 || minmax > 10)
            {
                Console.WriteLine("都說不可以了！乖乖聽話！");
                Console.ReadLine();
            }
            else
            {
                for (int i = 0; i < name.Length; i++)
                {
                    nameList.Add(name[i]);
                }

                // 組別的數量
                int numberCount = nameList.Count / minmax;

                // 多餘的人數
                int otherPeople = nameList.Count % minmax;

                // 第二個多餘的人數，以免把多餘的人數都加在第一組
                int otherPeople2 = otherPeople;

                while (n <= numberCount)
                {
                    Console.Write("第" + n + "組的人有:  ");

                    for (int i = 0; i < minmax; i++)
                    {
                        if (otherPeople > 0 && otherPeople2 == otherPeople)
                        {
                            int l = rand.Next(0, nameList.Count);
                            Console.Write(nameList[l] + " ");
                            nameList.RemoveAt(l);
                            otherPeople--;
                        }
                        int j = rand.Next(0, nameList.Count);
                        Console.Write(nameList[j] + " ");
                        nameList.RemoveAt(j);
                    }
                    otherPeople2--;
                    Console.WriteLine("");
                    n++;
                }
                Console.ReadLine();
            }
        }
    }
}