#include <bits/stdc++.h>
using namespace std;
#define ll long long
const int mxN = 2e5+5;
int main() {
    ios_base::sync_with_stdio(false);
    cin.tie(0);
    cout.tie(0);
    int t;
    cin>>t;
    while(t--){
        int n;
        cin>>n;
        vector<ll> a(n);
        ll sum = 0;
        for(int i = 0 ; i < n;i++){
            cin>>a[i];
            sum+=a[i];
        }
        ll i = -sum / n;
        ll j = sum / n;
        
    }
    
    return 0;
}
