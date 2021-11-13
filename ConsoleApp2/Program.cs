using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2 {
    class Program {
        static String[][] readFile(string path) {
            List<String[]> list = new List<String[]>();
            using (StreamReader reader = new StreamReader(path)) {
                while (!reader.EndOfStream) {
                    String line = reader.ReadLine();
                    String[] values = line.Split(';');
                    list.Add(values);
                }
            }

            return list.ToArray();
        }

        static void Main(string[] args) {
            int buff = 0;
            string line_buff = "";

            foreach (string[] record in readFile("identyfikator.txt")) {
                foreach (string line in record) {
                    int wynik = 0;
                    string numbers = line.Remove(0, 3);

                    for (int i = 0; i <= 5; i++) {
                        wynik += int.Parse(numbers[i].ToString());
                    }

                    if (wynik > buff) {
                        buff = wynik;
                        line_buff = line;
                    }
                }
            }
            Console.WriteLine(line_buff);
        }
    }
}
