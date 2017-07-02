#include <iostream>
using namespace std;
struct DoVat
{
	int v;
	int w;
};
int PATU[7], S, Gttu, TL, x[7], m, n=6;
DoVat a[] = { {0,0 }, { 7,3 },{ 10,4 },{ 20,5 },{ 19,7 },{ 13,6 },{ 40,9 } };


void init() {
	int i;
	for (i = 1; i <= n; i++) {
		PATU[i] = 0;
		x[i] = 0;
	}
	S = 0;
	Gttu = 0;
	TL = 0; 
}
void Gan() {
	int k;
	for (k = 1; k <= n; k++) {
		PATU[k] = x[k];
	}
}
void Try(int i) {
	int t, j, g = 0;
	t = (m - TL) / a[i].w;
	for (j = t; j >= 0; j--) {
		x[i] = j;
		TL = TL + a[i].w * x[i];
		S = S + a[i].v * x[i];
		if (i == n) {
			if (S > Gttu) {
				Gan();
				Gttu = S;
			}
		}
		else {
			g = S + a[i + 1].v * (m - TL) / a[i + 1].w;
			if (g > Gttu) {
				Try(i + 1);
			}
		}
		TL = TL - a[i].w * x[i];
		S = S - a[i].v * x[i];
	}
}
void Print() {
	int k;
	for (k = 1; k <= n; k++) {
		cout << PATU[k] << "-->";
	}
}
int main() {
	
	DoVat result[10];
	cout << "Nhap trong luong tui: ";
	cin >> m;
	init();
	Try(1);
	Print();
	system("pause");
	return 0;
}
