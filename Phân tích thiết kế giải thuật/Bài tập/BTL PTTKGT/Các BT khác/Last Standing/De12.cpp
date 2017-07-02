// de 12 bai toan cai tui theo phuong phap quy hoach dong
#include<iostream>
using namespace std;

struct Dovat
{
	int c;
	int w;
};

void CaiTui(Dovat a[], int n, int b)
{
	int m[n+1][b+1];
	for(int i=0;i<=n;i++)
	{
		m[i][0]=0;
	}
	for(int j=1;j<=b;j++)
	{
		m[0][j]=0;
	}
	
	for(int i=1;i<=n;i++)
	{
		for(int j=1;j<=b;j++)
		{
			m[i][j]=m[i-1][j];
			if(j>=a[i-1].w && m[i-1][j-a[i-1].w]+a[i-1].c>m[i][j])
			{
				m[i][j]=m[i-1][j-a[i-1].w]+a[i-1].c;
			}
		}
	}
	
	int i=n;
	while(b>0 && i>0)
	{
		while(m[i-1][b]==m[i][b]) i--;
		if(i>0 && a[i-1].w <= b)
		{
			cout<<"do vat thu "<<i<<" : gia tri "<<a[i-1].c<<", trong luong "<<a[i-1].w<<endl;
			b=b-a[i-1].w;
		}
		i--;
	}
}

main()
{
	Dovat a[]={{7,3},{10,4},{20,5},{19,7},{13,6},{40,9},{12,6},{18,5},{12,12},{28,10}};
	CaiTui(a, 10, 29);
	
	system("pause");
}
