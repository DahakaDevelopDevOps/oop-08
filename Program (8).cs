namespace oop_8
{
    public class Program
    {
        //обработчик событий
        static void DisplayMessage(string message)
        {
            Console.WriteLine("-------Уведомление!-------");
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Boss CMS = new Boss(10, 1);
            Boss CMS2 = new Boss(100, 2);
            Boss CMS3 = new Boss(1000, 0);
            Boss CMS4 = new Boss(0, 1);
            int bossCondition = 8;
            Console.WriteLine(CMS.ToString());
            Console.WriteLine(CMS2.ToString());
            Console.WriteLine(CMS3.ToString());
            Console.WriteLine(CMS4.ToString());
            CMS.Notify += DisplayMessage;
            CMS2.Notify += DisplayMessage;
            CMS3.Notify += DisplayMessage;
            CMS4.Notify += DisplayMessage;
            CMS.Upgrade(bossCondition, CMS.stateOfDevice );
            CMS2.Upgrade(bossCondition, CMS2.stateOfDevice );
            CMS3.Upgrade(bossCondition, CMS2.stateOfDevice);
            CMS4.Upgrade(bossCondition, CMS4.stateOfDevice );
            CMS.TurnOn(CMS.stateOfDevice);
            CMS4.changer( CMS4, 0);
            CMS3.changer(CMS3, 9);
            Console.WriteLine(CMS4.stateOfDevice);
            CMS2.TurnOn(CMS2.stateOfDevice);
            CMS3.TurnOn(CMS2.stateOfDevice);
            CMS3.Upgrade(CMS3.bossCondition, CMS3.stateOfDevice);
            Console.WriteLine(CMS.ToString());
            Console.WriteLine(CMS2.ToString());
            Console.WriteLine(CMS3.ToString());
            Console.WriteLine(CMS4.ToString());

            string changingStr = "Nice String";
            StrAct lowNup = StringAction.Lower;
            lowNup += StringAction.Upper;
            lowNup(changingStr);
            Predicate<int> isLong = (int x) => x > 5;
            Console.WriteLine(isLong(changingStr.Length));
            DoOperation(changingStr, StringAction.Remove);
            DoOperation(changingStr, StringAction.Insert);
            void DoOperation(string str, Action<string> op) => op(changingStr);
            Func<string, string> convertMethod = StringAction.RemoveEleminstr;
            Console.WriteLine(convertMethod(changingStr));
            convertMethod += StringAction.Reverse;
            Console.WriteLine(convertMethod(changingStr));
            Func<string, string> convert = delegate (string str)
            { return str.Insert(str.Length, "!!!!!"); };
            Console.WriteLine(convert(changingStr));
            string secOperation(string str, Func<string, string> operation) => operation(str);
            Console.WriteLine(secOperation(changingStr, str => str.Insert(1, "/")));
        }

    }
}