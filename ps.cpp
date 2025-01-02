#include <bits/stdc++.h>

using namespace std;
typedef long long ll;

#define all(a) a.begin(), a.end()
#define allr(a) a.rbegin(), a.rend()
int search(vector<int>& nums,int target){
    int left = 0 , right = nums.size()-1;
    while(left<=right){
        int mid = (left+right)/2;
        if(nums[mid] == target){
            return mid;
        }
        else if (nums[mid]>target){
            right = mid-1;
        }
        else{
            left = mid+1;
        }
    }
    return -1;
}

void solve() {
    vector<int> nums = {-1, 0, 3, 5, 9, 12};
    int target = 9; 
    cout<<search(nums,target);
}

int main() {
    ios_base::sync_with_stdio(NULL);
    cin.tie(NULL), cout.tie(NULL);

    int t = 1;
    // cin >> t;
    while (t--) solve();
}