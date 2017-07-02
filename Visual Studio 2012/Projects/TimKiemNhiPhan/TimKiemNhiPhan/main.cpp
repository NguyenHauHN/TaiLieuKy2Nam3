#include <iostream>
#include <stdio.h>
#define MAX 1000
using namespace std;


int TimKiemSo(int x, int a[], int l,int r){
	int mid ;
	if(l > r){
		return 0;
	}
	mid = (l + r)/2;
	if(x == a[mid]){
		return mid;
	}
	else{
		if(x > a[mid]){
			return TimKiemSo(x, a, mid + 1, r);
		}
		else{
			return TimKiemSo(x, a, l, mid -1);
		}
	}
}
void Nhap(int n, int a[]){
	
	for(int i = 0; i < n; i++){
		cout << "Nhap pham tu thu " << i + 1 << " : ";
		cin >> a[i];
		cout<< endl;
	}
}
void swap(int x, int y){
	int t;
	t = x;
	x = y;
	y = t;
}

int Partition(int a[], int l,int r){
	int x = a[l];
	int i = l + 1;
	int j = r;
	while (i < j)
	{
		while (i < j && a[i] < x)
		{
			i++;
		}
		while (j >= i && a[j] >= x)
		{
			j--;
		}
		if(i < j) swap(a[i], a[j]);
	}
	swap(a[l], a[j]);
	return j;
}

void QuickSort(int *a, int l, int r){
	if(l >= r){
		return;
	}
	int k = Partition(a, l, r);
	QuickSort(a, l, k -1);
	QuickSort(a, k + 1, r);
}

void In(int *a, int n){
	for(int i = 0; i < n; i++){
		cout << a[i] << "\t";
	}
}


int main(){
	int n = 0;
	int a[MAX];
	//int x;
	cout << "Nhap n = ";
	cin >> n;
	Nhap(n, a);
	//In(a, n);
	
	cout << "Truoc khi sap xep: "<< endl;
	for (int i=0; i<n; i++){
        cout << a[i] << "\t";
	}
	cout << "Sau khi sap xep: "<< endl;
	QuickSort(a, 0, n -1);
	for (int i=0; i<n; i++){
        cout << a[i] << "\t";
	}
	/*cout << "Nhap khoa:";
	cin >> x;
	int idx = TimKiemSo(x, a, 0, n);
	cout << "Vi tri tim thay trong mang : " <<  idx << endl;*/
	system("pause");
	return 0;
}