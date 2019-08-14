using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class PoliceArgs : EventArgs
    {
        string name;
        DateTime dtime;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime CurrentTime
        {
            get { return dtime; }
            set { dtime = value; }
        }
    }


    class Police
    {
        private string policeName;
        public string PoliceName
        {
            set
            {
                policeName = value;
            }
            get
            {
                return policeName;
            }
        }

        public delegate void PoliceCatchHedler(object sender,PoliceArgs policeArgs);

        public event PoliceCatchHedler PoliceCatchevent;

      

        //透視事件觸發 進而呼叫 hedler處理事件
        public void StartEven()
        {
            PoliceArgs args = new PoliceArgs();
            args.Name = "AAAA";
            args.CurrentTime = DateTime.Now;
            PoliceCatchevent(this,args);
        }

    }
    class Thief
    {
        private string thiefName;
        public string ThiefName
        {
            set
            {
                thiefName = value;
            }
            get
            {
                return thiefName;
            }
        }


        public void thiefMethod(object sender,PoliceArgs args)
        {
            Console.WriteLine("我是被委派的事件");
        }
    }



    class Program
    {

        public void test()
        {

        }

        static void Main(string[] args)
        {
            Program P = new Program();
            Thief A = new Thief();
            Police police = new Police();
            PoliceArgs policeArgs = new PoliceArgs();
            policeArgs.Name = "jason";
            police.PoliceCatchevent += new Police.PoliceCatchHedler(A.thiefMethod);
            //police.PoliceCatchevent += new Police.PoliceCatchHedler(P.test);
            police.StartEven();
        }
    }
    
   
}
// 結論
// 透過 event 類別進行觸發  進而呼叫 eventhadler 處理委派  
// 在event觸發時 若有arg 需先實體化 並帶上參數
