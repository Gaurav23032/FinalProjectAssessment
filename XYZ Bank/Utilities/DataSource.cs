using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_Bank.Utilities
{
    public  class DataSource
    {
        public static object[] ValidLoginData()

        {

            string[] dataSet1 = new string[5];
            dataSet1[0] = "Hermoine";
            dataSet1[1] = "Granger";
            dataSet1[2] = "E859AB";
            dataSet1[3] = "Hermoine Granger";
            dataSet1[4] = "Dollar";
  


            string[] dataSet2 = new string[5];
            dataSet2[0] = "Harry";
            dataSet2[1] = "Potter";
            dataSet2[2] = "E725JB";
            dataSet2[3] = "Harry Potter";
            dataSet2[4] = "Dollar";
           

            object[] allDataSet = new object[2];
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            return allDataSet;
        }

        public static object[] CustomerInfo()
        {
            string[] data = new string[2];
            data[0] = "Ron Weasly";

            data[1] = "Dollar";

            object[] obj = new object[1];
            obj[0] = data;

            return obj;
        }
        public static object[] ValidBankManagerLogin()
        {
            object[] data = ExcelUtils.GetSheetIntoObjectArray(@"C:\\Users\\gauravsk\\Desktop\\C Sharpe\\AutomationBankProject\\XYZ Bank\\TestData\\XYZBankData.xlsx", "ValidBankManagerLogin");
             return data;
                }
    }
}
    

