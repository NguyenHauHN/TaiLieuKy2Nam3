// de 14 xau con chung dai nhat theo phuong phap quy hoach dong
#include<iostream>
#include<string>
using namespace std;

string Xaucon(string s1, string s2)
{
	int n=s1.length()+1;
	int m=s2.length()+1;
	
	int a[n][m];
	int b[n][m];
	for(int i=0;i<n;i++)
	{
		b[i][0]=0;
		a[i][0]=0;
	}
	for(int j=1;j<m;j++)
	{
		b[0][j]=0;
		a[0][j]=0;
	}
	
	string s="";
	for(int i=1;i<n;i++)
	{
		for(int j=1;j<m;j++)
		{
			if(s1[i-1] == s2[j-1])
			{
				a[i][j]=a[i-1][j-1]+1;
				b[i][j]=3;
				if(s.find(s1[i-1] == string::npos))
					s+=s1[i-1];
			}
			else
			{
				if(a[i-1][j]>a[i][j-1])
				{
					a[i][j]=a[i-1][j];
					b[i][j]=2;
				}
				else
				{
					a[i][j]=a[i][j-1];
					b[i][j]=1;
				}
			}
		}
	}
	return s;
}

main()
{
	string s1="behappy";
	string s2="befree";
	cout<<Xaucon(s2,s1);
	
	
}
