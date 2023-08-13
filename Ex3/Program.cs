using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        // I added threading and Asynchronization as an additional Feature
        static async Task Main()
        {
            
            using (StreamWriter writer = new StreamWriter("CV_Summary1.txt"))
            {
             
                await writer.WriteLineAsync("I am looking to improve my skills and experiences in a stimulating environment.");
                await writer.WriteLineAsync(". My goal is to contribute to the success of a renowned organization while gaining valuable hands-on experience, particularly as a full-stack web developer/intern.");
                Task.Delay(1000).Wait();
            }

          
            using (StreamWriter writer = new StreamWriter("CV_summary2.txt"))
            {
                await writer.WriteLineAsync("A 23-year-old almost graduated Computer Engineering student from Jordan University of Science and Technology,");
                await writer.WriteLineAsync("seeking hands- on experience in full stack development or any other interesting IT field to complement my academic knowledge.");
                await writer.WriteLineAsync("I have developed knowledge and expertise in numerous programming languages and core programming concepts through various projects and through my academic journey.");
                await writer.WriteLineAsync("I am currently immersing myself in studying and practicing backend technologies");
                Task.Delay(1000).Wait();
            }

      
            using (StreamReader reader = new StreamReader("CV_Summary1.txt"))
            using (StreamWriter writer = new StreamWriter("CV_Summary2.txt", true)) 
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    await writer.WriteLineAsync(line);
                }
            }

            // Reading TextFile2.txt and counting words
            using (StreamReader reader = new StreamReader("CV_Summary2.txt"))
            {
                string content = await reader.ReadToEndAsync();
                int wordCount = content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Count();

                Console.WriteLine($"Total number of words in CV_Summary2: {wordCount}");
            }
        }
    }
}
