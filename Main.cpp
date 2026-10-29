#include <iostream>
#include <string>
using namespace std;
int num1;
int num2;
string pmdu;
int main()
{
    while (true)
    {
        cout<<"===CALCULATOR=== \n";
        cout<<"num1 \n";
        cin>>num1;
        cout<<"+ or - or / or *";
        cin>>pmdu;
        cout<<"num2 \n";
        cin>>num2;
        if (pmdu == "+")
        {
            pmdu = num1 += num2;
            cout<<pmdu;
        }
        else if (pmdu == "-")
        {
            pmdu = num1 -= num2;
            cout<<pmdu;
        }
        else if (pmdu == "/")
        {
            pmdu = num1 *= num2;
            cout<<pmdu;
        }
        else if (pmdu == "*")
        {
            pmdu = num1 *= num2;
            cout<<pmdu;
        }
    }
    
}