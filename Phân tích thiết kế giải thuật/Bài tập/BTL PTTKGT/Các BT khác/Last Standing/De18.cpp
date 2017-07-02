// de 18 - bai toan cai tui theo quay lui
#include<iostream>
using namespace std;

void Print(int k[], int c[], int w[], int n, int sum)
{
	cout<<"\nRES\n";
	for(int j=0;j<n;j++)
	{
		if(k[j]!=-1)
		cout<<"Do vat: gia tri "<<c[k[j]]<<", trong luong "<<w[k[j]]<<endl;
		cout<<"Tong trong luong = "<<sum<<endl;
	}
}

void Try(int k[], int c[], int w[], int n, int b, int i, int sum)
{
	if(i<n && sum<=b)
	{
		for(int j=0;j<n;j++)
		{
			if(w[j]<=b && k[j]==-1 && sum+w[j]<=b)
			{
				sum+=w[j];
				k[j]=i;
				Try(k, c, w, n, b, i+1, sum);
				
				sum-=k[j];
				k[j]=-1;
			}
		}
	}
	else
	{
		Print(k, c, w, n, sum);
	}
}

main()
{
	int c[]={20,16,8,10,16,28,36,13,9,22}; 	// gia tri
	int w[]={14,6,10,5,6,10,25,8,32,14};	//trong luong

	int b=39;
	int n=10;
	int k[10];
	int sum=0;
	for(int i=0;i<n;i++)
		k[i]=-1;
	
	Try(k, c, w, n, b, 0, sum);
	
	system("pause");
}
