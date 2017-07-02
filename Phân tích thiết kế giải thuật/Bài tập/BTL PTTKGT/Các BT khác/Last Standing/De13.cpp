// de 13 day con lien tiep co tong lon nhat theo phuong phap quy hoach dong
#include<iostream>
using namespace std;

void Daycon(int a[], int n)
{
	int s=0,s1=0,e=0;
	int me=0, ms=0;
	
	for(int i=0;i<n;i++)
	{
		if(me>0) me+=a[i];
		else
		{
			me=a[i];
			s1=i;
		}
		if(me>ms)
		{
			ms=me;
			e=i;
			s=s1;
		}
	}
	
	int sum=0;
	for(int i=s;i<=e;i++)
	{
		cout<<a[i]<<" ";
		sum+=a[i];
	}
	cout<<endl<<"tong = "<<sum<<endl;
}

main()
{
	int a[]={13,-15,2,-18,4,8,0,-5,-8,12,6,-18,5,22,-12};
	cout<<"day ban dau: ";
	for(int i=0;i<15;i++)
	{
		cout<<a[i]<<" ";
	}
	cout<<endl;
	Daycon(a, 15);
	
	system("pause");
}
