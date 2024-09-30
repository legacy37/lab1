using lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    abstract class Metods
    {
        public abstract double Resh(Func<double,double>f,double a,double b, int n);
    }
}
class IntegrateRect : Metods
{
    public override double Resh(Func<double, double> f, double upperbound, double lowerbound, int partcount)
    {
        double partlength = (upperbound - lowerbound) / partcount;
        double answer = 0;
        double x0 = lowerbound;
        for (int i = 0; i < partcount; i++)
        {
            x0 += partlength;
            answer += f(x0 + (partlength / 2));
        }
        answer *= partlength;
        return answer;
    }
}
class IntegrateTrap : Metods
{
    public override double Resh(Func<double, double> f, double upperbound, double lowerbound, int partcount)
    {
        double partlength = (upperbound - lowerbound) / partcount;
        double answer = 0;
        double x0 = lowerbound;
        for (int i = 0; i < partcount; i++)
        {
            x0 += partlength;
            answer += f(x0);
        }
        answer += (f(upperbound) + f(lowerbound)) / 2;
        answer *= partlength;
        return answer;
    }

}