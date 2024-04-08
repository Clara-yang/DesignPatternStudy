using SimpleFactory;

class Program
{
    static void Main(string[] args)
    {
        double strResult;
        Operation oper;
        try
        {
            Console.WriteLine("请输入数字A：");
            string strNumA = Console.ReadLine();
            Console.WriteLine("请输入操作符号(+ - * /)：");
            string strOperate = Console.ReadLine();
            Console.WriteLine("请输入数字B：");
            string strNumB = Console.ReadLine();

            oper = OperationFactory.CreateOperation(strOperate);
            oper.NumberA = Convert.ToDouble(strNumA);
            oper.NumberB = Convert.ToDouble(strNumB);
            strResult = oper.GetResult();
            Console.WriteLine(oper.NumberA.ToString() + "+" + oper.NumberB.ToString() + "=" + strResult);
        }
        catch (Exception e)
        {
            Console.WriteLine("您的输入有误" + e.Message);
        }
    }
}





