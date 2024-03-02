namespace Task1;

public class Staff : Person
{   string _school;
    double _pay;
    public Staff(string name, string address,string school,double pay) : base(name, address)
    {
        _school = school;
        _pay = pay;
    }

    public string GetSchool()
    {
        return _school;
    }

    public void SetSchool(string school)
    {
        _school = school;
    }
    public double GetPay()
    {
        return _pay;
    }

    public void SetPay(double pay)
    {
        _pay = pay;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, School: {_school},' Pay: {_pay}";
    }
}
