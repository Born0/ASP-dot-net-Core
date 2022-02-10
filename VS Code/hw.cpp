#include<iostream>
using namespace std;


//Find most frequent element in given string

char MostFrequentElement(string str,int len)
{
    int count[256]={0};
    int max=0;
    char res;
    for(int i=0;i<len;i++)
    {
        count[str[i]]++;
        if(count[str[i]]>max)
        {
            max=count[str[i]];
            res=str[i];
        }
    }
    return res;
}



int main()
{
    string str="aabbbcccckkkweelkmmamlklllle";
    int len=str.length();

    cout<<"most frequent element is "<<MostFrequentElement(str,len);
    
    return 0;
}
