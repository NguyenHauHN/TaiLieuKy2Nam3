#include <iostream>

using namespace std;


int a[5][5]{
	{ 0 , 1 , 2, 7, 5},
	{ 1 , 0 , 4 , 4, 3},
	{ 2, 4 , 0 , 1 , 2},
	{ 7, 4, 1 , 0 , 3},
	{ 5, 3, 2, 3, 0}
};

int n;//số lượng đỉnh
bool b[10] = { false };//mảng đánh dấu
int kq[12], duongtotnhat[12] = { 0 };//mảng tạm, và mảng lưu trữ cấu hình tốt nhất
int min = 32000, cost = 0;//giá trị thấp nhất khi đi qua các đỉnh và giá trị tạm
int start;//đỉnh bắt đầu

void Try(int i);

void Output() {
	for (int i = 0; i < n; i++) {
		cout << duongtotnhat[i] + 1 << "->";
	}
	cout << duongtotnhat[0] + 1 << endl;
	cout << "Chi phi: " << min << endl;
}

void main() {
	n = 5;
	start = 0;
	kq[0] = start; b[start] = true;
	Try(1);//bắt đầu gọi từ đỉnh đầu tiên, khi bằng n thì dừng
	
	system("pause");
}

void Try(int i) {
	//nếu i =n thì kiểm tra xem có phải là hành trình tốt hơn thì lưu lại
	if (i == n) {
		Output();
		if (cost + a[kq[i - 1]][kq[0]] < min) {
			min = cost + a[kq[i - 1]][kq[0]];
			for (int k = 0; k < n; k++) {
				duongtotnhat[k] = kq[k];
			}
		}
	}
	else
	{
		//duyệt qua các đỉnh có thể đi qua
		for (int j = 0; j < n; j++)
		{
			//nếu chưa đi qua và giá trị còn cho phép
			if (b[j] == false && cost + a[kq[i - 1]][j] < min) {
				//ghi nhớ kết quả
				kq[i] = j;
				b[j] = true;
				cost += a[kq[i - 1]][j];
				//gọi đệ quy đến bước tiếp theo
				Try(i + 1);
				//xóa bộ ghi nhớ
				b[j] = false;
				cost -= a[kq[i - 1]][j];
			}
		}
	}
}