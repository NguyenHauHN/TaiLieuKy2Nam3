/*Đề bài:
Cho một mạng lưới gồm n thành phố. Một người muốn đi du lịch khắp các thành phố, mỗi thành phố đi qua đúng một lần và sau đó quay về thành phố xuất phát. Giả sử biết chi phí đi lại giữa các thành phố (0<c[i,j]). Hãy lập trình tìm phương án với tổng chi phí ít nhất.

Thuật toán:Phương án của bài toán là x[1], x[2].. x[n], x[1]. Trong đó x[1] là đỉnh xuất phát, x là đỉnh thứ i trong hành trình của người du lịch. Lúc đó tổng chi phí S được tính như sau:

S = a[x[1],x[2]]+ a[x[2],x[3]]+...+ a[x[n-1],x[n]]+ a[x[n],x[1]].

Trong quá trình xây dựng các thành phần của phương án ta tiến hành đặt nhánh cận như sau:

Xây dựng thành phần thứ i của phương án (x) ta có tổng chi phí S của i-1 thành phần đã được xây dựng. Thành phần thứ i của phương án phải thoả mãn biểu thức sau:

S + a[x[i-1], x]+(n-i)*Amin +X1min < Min.

Trong đó: + Amin là chí phí nhỏ nhất trong bảng chi phí a[i,j].

+ X1min là chi phí nhỏ nhất từ x[1] đến các thành phố còn lại.

+ Min là chi phí của phương án mẫu.*/

//#include<iostream>
//#include<conio.h>
//#include<stdio.h>
//#include<stdlib.h>
//using namespace std;
//int n, c[100][100], x[100], chuaxet[100], kq[100];
//int MIN = 0;
//int a = 1;
//void Init() {
//	cout << "\n Nhap n="; cin >> n;
//	cout << "\n Nhap chi phi \n";
//	for (int i = 1; i <= n; i++)
//		for (int j = 1; j <= n; j++) {
//			if (i != j) {
//				cout << "c[" << i << "][" << j << "]="; cin >> c[i][j];
//			}
//			else c[i][j] = 0;
//		}
//	x[1] = 1;
//	for (int i = 2; i <= n; i++)  chuaxet[i] = 1;
//}
//void Result() {
//	cout << "\n T1->";
//	for (int i = 2; i <= n; i++) cout << "T" << kq[i] << "->";
//	cout << "T1";
//	cout << "\n Tong chi phi la: " << MIN;
//}
//void Work() {
//	int S = 0;
//	for (int i = 1; i <= n - 1; i++) {
//		S = S + c[x[i]][x[i + 1]];
//	}
//	S = S + c[x[n]][1];
//	if (S<MIN || a == 1) {
//		a = 0;
//		MIN = S;
//		for (int i = 1; i <= n; i++) kq[i] = x[i];
//	}
//}
//void Try(int i) {
//	for (int j = 2; j <= n; j++) {
//		if (chuaxet[j]) {
//			x[i] = j; chuaxet[j] = 0;
//			if (i == n) Work();
//			else Try(i + 1);
//			chuaxet[j] = 1;
//		}
//	}
//}
////void main() {
////	Init();
////	Try(2);
////	Result();
////	system("PAUSE");
////}