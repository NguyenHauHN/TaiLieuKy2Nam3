#include<iostream>
using namespace std;
int a[5][5] = {{0,15,30,50,20},
			 {15,0,10,35,32},
			 {30,10,0,15,40},
			 {50,35,15,0,43},
			 {20,32,40,43,0} };//mảng lưu thành phố và chi phí
int dinh;//số lượng đỉnh
bool b[5] = { false };//mảng check
int kq[10], best[10] = { 0 };//kq là mảng tạm và best là lưu mang có kết quả tốt nhất
int min = 32000, cost = 0;//giá trị thấp nhất khi đi qua các đỉnh và giá trị tạm
int start;//đỉnh bắt đầu
void output() {
	for (int i = 0; i < dinh; i++) {
		cout << best[i] + 1 <<"->";

	}
	cout << best[0] + 1 << endl;
	cout << "chi phi: " << min << endl;
}
void Try(int i){
	//nếu i=n thì kiểm tra để xem kết quả tốt hơn thì lưu lại
	if (i == dinh) {
		if (cost + a[kq[i - 1]][kq[0]] < min) {
			min = cost + a[kq[i - 1]][kq[0]];
			for (int k = 0; k < dinh; k++) {
				best[k] = kq[k];
			}
		}
		else {
			for (int j = 0; i < dinh; j++)//duyệt qua các đỉnh có thể đi qua
			{
				//nếu chưa đi qua và gia trị còn cho phép
				if (b[j] == false && cost + a[kq[i - 1]][j] < min)
				{
					//ghi nhớ lại kết quả
					kq[i] = j;
					b[j] = true;
					cost += a[kq[i - 1]][j];
					//gọi đến bước tiếp theo
					Try(i + 1);
					//xóa bỏ ghi nhớ
					b[j] = false;
					cost -= a[kq[i - 1]][j];
				}
			}
		}
	}
}
void main(){
	//khởi tạo ban đầu
	dinh = 5;
	start = 3;
	start--;
	kq[0] = start;
	b[start] = true;
	Try(1);//bắt đầu gọi từ đỉnh đầu tiên đi, khi bằng n thì dừng
	output();
	system("PAUSE");
}