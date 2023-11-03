#include <bits/stdc++.h>
using namespace std;
#pragma unroll
#pragma GCC optimize("Ofast")
#pragma GCC target("avx,avx2,fma")
#pragma GCC optimization ("unroll-loops")

// Hàm tính a^b % m mà có thể xử lý số lớn bằng cách lặp lại bình phương và nhân
long long modularExponentiation(long long a, long long b, long long m) {
    long long result = 1;
    a = a % m;
    while (b > 0) {
        if (b % 2 == 1)
            result = (result * a) % m;
        b = b / 2;
        a = (a * a) % m;
    }
    return result;
}

// Hàm kiểm tra xem n có phải là số nguyên tố hay không bằng thuật toán Miller-Rabin
bool isPrime(long long n, int k) {
    if (n <= 1 || n == 4) return false;
    if (n <= 3) return true;

    // Kiểm tra dạng 2^r * d + 1
    long long d = n - 1;
    while (d % 2 == 0)
        d /= 2;

    // Kiểm tra k lần
    for (int i = 0; i < k; i++) {
        long long a = 2 + rand() % (n - 3); // Chọn một số ngẫu nhiên từ 2 đến n-2
        long long x = modularExponentiation(a, d, n);

        if (x == 1 || x == n - 1)
            continue;

        while (d != n - 1) {
            x = (x * x) % n;
            d *= 2;

            if (x == 1) return false;
            if (x == n - 1) break;
        }

        if (x != n - 1) return false;
    }

    return true;
}

int main() {
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);
    srand(time(NULL));
   

    return 0;
}
