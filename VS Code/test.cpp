#include<iostream>
using namespace std;

//Write a method that takes in a string argument and return its reversed form
string Reverse(string str)
{
    int len=str.length();
    for(int i=0;i<len/2;i++)
    {
        swap(str[i],str[len-i-1]);
    }
    return str;
}
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.
void TwoSum(int arr[],int n,int target)
{
    int i,j;
    for(i=0;i<n;i++)
    {
        for(j=i+1;j<n;j++)
        {
            if(arr[i]+arr[j]==target)
            {
                cout<<i<<" "<<j;
                return;
            }
        }
    }
}

main()
{
    //create array of 10 elements
    int arr[10]={1,2,3,4,5,6,7,8,9,10};
    int n=sizeof(arr)/sizeof(arr[0]);
    int target=15;
    TwoSum(arr,n,target);

}