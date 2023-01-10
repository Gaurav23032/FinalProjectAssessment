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

            string[] dataSet1 = new string[4];
            dataSet1[0] = "Hermoine";
            dataSet1[1] = "Granger";
            dataSet1[2] = "E859AB";
            dataSet1[3] = "Hermoine Granger";
  


            string[] dataSet2 = new string[4];
            dataSet2[0] = "Harry";
            dataSet2[1] = "Potter";
            dataSet2[2] = "E725JB";
            dataSet2[3] = "Harry Potter";
           

            object[] allDataSet = new object[2];
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            return allDataSet;
     

        

        }
    }
}
    

