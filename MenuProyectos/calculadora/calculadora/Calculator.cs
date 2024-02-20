using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
        public class Calculator
        {
            public string firstNumber = "0";
            public List<int> numberList = new List<int>();
            public List<string> numberSign = new List<string>();
            public int result = 0;
        
            public void SetNumber(string num)
            {
                this.firstNumber += num;
            }

        public void AddToArrayList(string button)
        {
            if (!string.IsNullOrEmpty(firstNumber)) {
                int newFirstNumber = Convert.ToInt32(firstNumber);
                numberList.Add(newFirstNumber);
                numberSign.Add(button);
                firstNumber = "";
            }
            else
            {
                ClearValues();
            }
            }

            public int Operation()
            {
                int newNumber = int.Parse(firstNumber);
                numberList.Add(newNumber);

                if (numberList.Count == 0 || numberSign.Count == 0)
                {
                    return 0;
                }
                result = numberList[0];

                for (int i = 0; i < numberSign.Count; i++)
                {
                    string sign = numberSign[i];

                    if (i + 1 < numberList.Count)
                    {
                        int nextNum = numberList[i + 1];

                        switch (sign)
                        {
                            case "+":
                                result += nextNum;
                                break;
                            case "-":
                                result -= nextNum;
                                break;
                            case "*":
                                result *= nextNum;
                                break;
                            case "/":
                                result /= nextNum;
                                break;
                        }
                    }
                }
                return result;
            }

            public void ClearValues()
            {
                numberList.Clear();
                numberSign.Clear();
                firstNumber = "0";
                result = 0;
            }
        }
    }
