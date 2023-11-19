#include <iostream>
#include <string.h>
using namespace std;

#define MAX 300

void DemKyTu(char s[]);
int myStrcmp(char& s1[MAX], char& s2[MAX]);
int myStrlen(char s[], int k);

int main()
{
    char s[MAX];
    // gets(s);   // Nhap chuoi s
    cin.getline(s, MAX);
    if (myStrcmp(s, '') == 0)
        cout << "Chuoi rong." << endl;
    else
        DemKyTu(s);

    return 0;
}

void DemKyTu(char s[])
{
    int n = myStrlen(s, MAX);
    int dem[MAX] = {0};
    int k = 0;
    for (int i = 0; i < n; i++)
    {
        if (s[i] != ' ')
        {
            dem[k]++;
        }
        else
        {
            k++;
        }
    }
    for (int i = 0; i <= k; i++)
    {
        cout << s[i] << dem[i] << " ";
    }
}

int myStrcmp(char s1[MAX], char s2[MAX])
{
    int i = 0;
    while (s1[i] != '\0' && s2[i] != '\0')
    {
        if (s1[i] != s2[i])
        {
            return s1[i] - s2[i];
        }
        i++;
    }
    return s1[i] - s2[i];
}

int myStrlen(char s[], int k)
{
    int len = 0;
    while (len < k && s[len] != '\0')
    {
        len++;
    }
    return len;
}
