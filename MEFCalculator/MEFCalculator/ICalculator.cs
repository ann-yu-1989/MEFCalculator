namespace MEFCalculator
{
    public interface ICalculator
    {
       string Calculate(string input);
    }
    public interface IOperation
    {
        int Operate(int left, int right);
    }

    public interface IOperationData
    {
        char Symbol { get; }
    }
}
