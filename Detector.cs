using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NHunspell;

namespace NewWordsDetector
{
    class Detector
    {
        static void Main(string[] args)
        {
            // 检查文件夹
            if (!Directory.Exists("known"))
            {
                Console.WriteLine("known文件夹怎么没了，我给你重新创建了哈");
                Console.WriteLine($"路径: {Path.GetFullPath("known")}");
                Directory.CreateDirectory("known");
            }
            if (!Directory.Exists("input"))
            {
                Console.WriteLine("input文件夹怎么没了，我给你重新创建了哈");
                Console.WriteLine($"路径: {Path.GetFullPath("input")}");
                Directory.CreateDirectory("input");
            }
            if (!Directory.Exists("output"))
            {
                Console.WriteLine("output文件夹怎么没了，我给你重新创建了哈");
                Console.WriteLine($"路径: {Path.GetFullPath("output")}");
                Directory.CreateDirectory("output");
            }


            // 加载已知词汇
            var knownWords = new List<string>();
            var knownFiles = Directory.GetFiles("known", "*.txt");
            foreach (var file in knownFiles)
            {
                var words = File.ReadAllLines(file)
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .SelectMany(line => line.Split(' '))
                    .Distinct()
                    .Select(word => word.ToLowerInvariant())
                    .ToList();

                knownWords.AddRange(words);
            }

            // 拼写检查
            var spellChecker = new Hunspell("en_US.aff", "en_US.dic");

            // 开始处理生词流程
            var inputFiles = Directory.GetFiles("input", "*.txt");
            if (inputFiles.Length == 0)
            {
                Console.WriteLine("input文件夹中什么都没有，请放点东西进去，我等你……");
                Console.WriteLine($" ");
                Console.WriteLine($"路径: {Path.GetFullPath("input")}");
                Console.WriteLine($" ");
                Console.WriteLine($"放进来之后，按键继续哦~");
                Console.ReadLine();
                Main(args);
                return;
            }
            int processedFiles = 0;
            int newWordsCount = 0;
            foreach (var file in inputFiles)
            {
                // 读取文件内容
                var lines = File.ReadAllLines(file)
                    .Where(line => !string.IsNullOrWhiteSpace(line));

                // 获取并处理所有生词
                var newWords = lines
                    .SelectMany(line => line.Split(' '))
                    .Select(word => word.ToLowerInvariant().Trim())
                    .Distinct() 
                    .Where(word => !knownWords.Contains(word) && spellChecker.Spell(word)
                                   && !string.IsNullOrWhiteSpace(word)
                                   && !word.Any(c => char.IsDigit(c)) 
                                   && !word.Any(c => !char.IsLetter(c)))
                    .SelectMany(word => spellChecker.Stem(word))
                    .Distinct() 
                    .Where(stem => !knownWords.Contains(stem)) 
                    .ToList();


                // 生词记数
                newWordsCount += newWords.Count;

                // 输出
                var outputPath = Path.Combine("output", $"{Path.GetFileNameWithoutExtension(file)}-提取-{DateTime.Now:yyyyMMddHHmmss}.txt");
                outputPath = Path.GetFullPath(outputPath);
                File.WriteAllLines(outputPath, newWords);
                
                // 文件计数
                processedFiles++;
            }

            Console.WriteLine(" ");

            // 显示结果
            Console.WriteLine($"已处理 {processedFiles} 个文件，共获取了 {newWordsCount} 个新词。");
            Console.WriteLine(" ");
            Console.WriteLine("路径：" + Path.GetFullPath("output"));
            Console.WriteLine(" ");
            Console.WriteLine("作者的主页：https://github.com/rhythm4night/");
            Console.ReadLine();
        }
    }
}
