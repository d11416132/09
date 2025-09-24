using System;

namespace ch16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Read();
            Console.Write("請輸入身高（公分）：");
            string inputHeight = Console.ReadLine();
            Console.Write("請輸入體重（公斤）：");
            string inputWeight = Console.ReadLine();

            // 將輸入轉為數值
            double height = Convert.ToDouble(inputHeight);
            double weight = Convert.ToDouble(inputWeight);

            // 計算 BMI（注意：需要把公分轉為公尺）
            double bmi = weight / ((height / 100) * (height / 100));

            // 輸出結果
            Console.WriteLine("您的BMI值為：" + bmi.ToString("0.00"));
        }
    }
}
