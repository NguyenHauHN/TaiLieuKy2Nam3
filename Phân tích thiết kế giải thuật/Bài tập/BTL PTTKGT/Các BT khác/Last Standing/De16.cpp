// de 16 - bai toan 8 hau
#include<iostream>
using namespace std;

void Print(int x[])
{
	for(int i=0;i<8;i++)
	{
		cout<<"("<<i+1<<", "<<x[i]+1<<")\t";
	}
	cout<<endl;
}

void Try(int a[], int b[], int c[], int x[], int i)
{
	if(i<8)
	{
		for(int j=0;j<8;j++)
		{
			if(a[j]==0 && b[i+j]==0 && c[i-j+7]==0)
			{
				x[i]=j;
				a[j]=1;
				b[i+j]=1;
				c[i-j]=1;
				Try(a, b, c, x, i+1);
				
				// tra lai trang thai
				a[j]=0;
				b[i+j]=0;
				c[i-j]=0;
			}
		}
	}
	else
	{
		cout<<"Ket qua: ";
		Print(x);
	}
}

main()
{
	int a[8];
	int b[15]; // 0 -> 14
	int c[15]; // -7 -> 7
	for(int i=0;i<8;i++) a[i]=0; // chua xet
	for(int i=0; i<=14;i++) b[i]=0; // chua xet
	for(int i=0; i<=14; i++) c[i]=0; // chua xet
	int x[8]; // mang luu vi tri cot j
	
	Try(a, b, c, x, 0);
	
	system("pause");
}
