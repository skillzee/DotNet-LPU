using System;

namespace InterfaceDemo;

public interface IAdd
{
    int AddMe(int num1, int num2);
}
public interface ISub
{
    int SubMe(int num1, int num2);
}
public interface IProd
{
    int ProdMe(int num1, int num2);
}
public interface IDiv
{
    float DivMe(int num1, int num2);
}
