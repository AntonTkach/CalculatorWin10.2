using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWin10._2
{
    class ClickHandler
    {
        public static void InformationPassed(string buttonValue)
        {
            int tempResult;
            if (int.TryParse(buttonValue, out tempResult) |
                buttonValue == ".")
            {
                //DisplayInfo.DisplayNumbers(buttonValue);
            }
            else
            {
                #region BigIfSentence
                if (
                    buttonValue == "memoryClear" ||
                    buttonValue == "memoryRetrieve" ||
                    buttonValue == "memoryAdd" ||
                    buttonValue == "memorySubstract" ||
                    buttonValue == "memorySave" ||
                    buttonValue == "memory")
                {
                    //MemoryHandler.ActionMemory(buttonValue);
                }
                else if (buttonValue == "clear" ||
                         buttonValue == "clearEverything" ||
                         buttonValue == "erase")
                {
                    //DisplayInfo.InfoHandler(buttonValue);
                }
                else if (buttonValue == "percent" ||
                         buttonValue == "squareRoot" ||
                         buttonValue == "powerOfTwo" ||
                         buttonValue == "oneOver" ||
                         buttonValue == "addition" ||
                         buttonValue == "subtraction" ||
                         buttonValue == "multiplication" ||
                         buttonValue == "division"
                )
                {
                    //if (!DisplayInfo.IsFirstOperatorShown)
                    //{
                    //    MathControls.firstOperator = buttonValue;
                    //    MathControls.WriteOperator(MathControls.firstOperator);
                    //}
                    //else
                    //{
                    //    MathControls.currentOperator = buttonValue;
                    //    MathControls.WriteOperator(MathControls.currentOperator);
                    //}


                }
                //else if (buttonValue == "equals")
                //{
                //    DisplayInfo.EqualHandler();
                //}
                //else if (buttonValue == "plusMinus")
                //{
                //    DisplayInfo.PlusMinus();
                //}
                #endregion
            }
        }
    }

}
